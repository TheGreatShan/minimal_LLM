namespace minimal_local_AI.Context;

public interface IPromptConstruct<T>
{
    T Construct(string prompt);
}