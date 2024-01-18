namespace minimal_local_AI.Context;

public interface Illm<T, C, G> : IDisposable
{
    public T Infer(C prompt);
    public G InferParams();
}