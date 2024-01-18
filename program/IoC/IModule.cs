using Autofac;

namespace minimal_local_AI.IoC;

public interface IModule<T>
{
    IContainer Container();
    T Configuration();
};