using System.Reflection;
using Autofac;
using minimal_local_AI.Execution;
using minimal_local_AI.IoC;

namespace minimal_local_AI;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
        new IoCModule(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "config.json"))
            .Container().Resolve<IRun>().Run();
    }
}