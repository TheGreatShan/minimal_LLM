using Autofac;
using System.IO;
using Newtonsoft.Json;
using Configuration;
using Context;
using Run;

namespace IoC;
public class IoCModule: IModule <Config>
{   
    readonly ContainerBuilder _builder;
    readonly IContainer _container;
    readonly Config _configuration;
    public IoCModule(string configPath)
    {
        _builder = new ContainerBuilder();

        //settings
        _configuration = JsonConvert.DeserializeObject<Config>(File.ReadAllText(configPath));
        
        //register
         _builder.Register(c => new LlamaSharpContext(_configuration)).As<IContext<LlamaInstance>>();
         _builder.Register(c => new RunLlama(c.Resolve<IContext<LlamaInstance>>())).As<IRun>();

        //build module container
        _container = _builder.Build();
    }
    public IContainer Container() => _container;
    public Config Configuration() => _configuration;
}