# This script updates all git repositories in the current directory.
# 1. Check is all repositories are clean (no uncommitted changes).
# 2. If clean, switch to the main branch and pull the latest changes.
# 3. Apply 'npm-check-updates -u' and 'npm install' to update dependencies.
# 4. Commit changes.
# 5. Sanitize using `npm run prerelease`.
# 6. Deploy using `cdk deploy --profile hra-prod`.
# 7. Find last published version tag and create a new tag with an incremented patch version.
# 8. Push changes and tags to the remote repository.

$ErrorActionPreference = "Stop"

function ApplyForEachRepo {
    param (
        [System.IO.DirectoryInfo[]]$repos,
        [ScriptBlock]$action
    )

    foreach ($repo in $repos) {
        Write-Host "Processing repository: $($repo.FullName)" -ForegroundColor Cyan

        $oldLocation = Get-Location
        Set-Location $repo.FullName

        try {
            Write-Host "pwd: $(Get-Location)" -ForegroundColor DarkGray
            & $action
        }
        catch {
            Write-Host "Error processing repository $($repo.FullName): $_" -ForegroundColor Red
            exit 1
        }
        finally {
            Set-Location $oldLocation
        }
    }
}

function EnsureRepoIsClean {
    param ([string]$repoPath)

    $status = & git status --porcelain
    if ($status) {
        throw "Repository $repoPath has uncommitted changes. Please commit or stash them before running this script."
    }

    $aheadStatus = & git rev-list --left-right --count origin/master...master
    $counts = $aheadStatus -split "`t"
    if ($counts[1] -gt 0) {
        throw "Repository is ahead of origin/master. Please push your changes before running this script."
    }
}

function UpdateRepo {
    param ([string]$repoPath)

    & git switch master
    & git pull
}

function UpdateDependencies {
    param ([string]$repoPath)

    & npx npm-check-updates -u
    & npm install
    & npm audit fix

    & git add package.json package-lock.json
}

function UpdateSubmodules {
    param ([string]$repoPath)

    & git submodule update --remote --merge
    & git add .
}

function CommitChanges {
    param ([string]$repoPath)

    & git commit -m "Update dependencies"
}

function Sanitize {
    param ([string]$repoPath)

    & npm run prerelease
    if ($LASTEXITCODE -ne 0) {
        throw "Prerelease script failed in repository $repoPath."
    }
}

function Deploy {
    param ([string]$repoPath)

    & npx cdk deploy --profile hra_prod
    if ($LASTEXITCODE -ne 0) {
        throw "CDK deploy failed in repository $repoPath."
    }
}

function CreateTags {
    param ([string]$repoPath)

    $latestTag = & git describe --tags --abbrev=0
    if (-not $latestTag) {
        throw "No tags found in repository $repoPath."
    }

    $versionParts = $latestTag -split "\."
    $major = [int]$versionParts[0]
    $minor = [int]$versionParts[1]
    $patch = [int]$versionParts[2] + 1

    $newTag = "$major.$minor.$patch"
    & git tag $newTag
}

function PushChanges {
    param ([string]$repoPath)

    & git push origin master --tags
}


$npmRepos = @(
    "Bounan.AniMan"
    "Bounan.Bot"
    "Bounan.Ongoing"
    "Bounan.Publisher"
)

if ($args -contains "--hard-reset") {
    throw "Blocked: Use with caution!"
    Write-Host "Force applying changes..." -ForegroundColor Red
    ApplyForEachRepo -repos $npmRepos -action {
        & git switch master
        & git reset --hard origin/master --recurse-submodules
    }
    throw "Done"
}

Write-Host "`nChecking if all repositories are clean..." -ForegroundColor Yellow
ApplyForEachRepo -repos $npmRepos -action ${function:EnsureRepoIsClean}

Write-Host "`nUpdating repositories..." -ForegroundColor Yellow
ApplyForEachRepo -repos $npmRepos -action ${function:UpdateRepo}

Write-Host "`nApplying npm-check-updates and installing dependencies..." -ForegroundColor Yellow
ApplyForEachRepo -repos $npmRepos -action ${function:UpdateDependencies}

Write-Host "`nUpdating git submodules..." -ForegroundColor Yellow
ApplyForEachRepo -repos $npmRepos -action ${function:UpdateSubmodules}

Write-Host "`nCommitting changes..." -ForegroundColor Yellow
ApplyForEachRepo -repos $npmRepos -action ${function:CommitChanges}

Write-Host "`nPerforming prerelease checks..." -ForegroundColor Yellow
ApplyForEachRepo -repos $npmRepos -action ${function:Sanitize}

Write-Host "`nDeploying..." -ForegroundColor Yellow
ApplyForEachRepo -repos $npmRepos -action ${function:Deploy}

Write-Host "`nCreating and pushing new version tags..." -ForegroundColor Yellow
ApplyForEachRepo -repos $npmRepos -action ${function:CreateTags}

Write-Host "`nPushing changes to remote repositories..." -ForegroundColor Yellow
ApplyForEachRepo -repos $npmRepos -action ${function:PushChanges}

Write-Host "`nAll repositories have been updated and deployed successfully." -ForegroundColor Green
