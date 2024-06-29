import { UserConfig } from '@hey-api/openapi-ts';

export default {
    input: 'common.yaml',
    output: {
        path: 'ts-generated',
        format: 'prettier',
        lint: 'eslint',
    },
    schemas: false,
    exportCore: false,
    services: false,
    types: true,
} as UserConfig;