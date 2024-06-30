namespace Bounan.Common.Models.DirectInteraction.Matcher;

public interface IMatcherResultRequest<T> : IBundledModel<T>
    where T : IMatcherResultRequestItem;