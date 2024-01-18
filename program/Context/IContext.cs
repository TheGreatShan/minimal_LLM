namespace minimal_local_AI.Context;

public interface IContext<T>
{
    public Task<T> Init();
}