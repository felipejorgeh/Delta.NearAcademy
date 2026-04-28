using Microsoft.AspNetCore.Builder;
using System.Reflection;

namespace Delta.NearAcademy;

public static class Injector
{
    public static void AddInjections(WebApplicationBuilder builder)
    {
        var outputDir = AppContext.BaseDirectory;
        foreach (var dll in Directory.GetFiles(outputDir, "*.dll"))
        {
            try { Assembly.LoadFrom(dll); }
            catch { }
        }

        var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies();

        var injectorType = typeof(IInjector);
        var injectors = loadedAssemblies
            .SelectMany(a => { try { return a.GetTypes(); } catch { return []; } })
            .Where(t => t is { IsClass: true, IsAbstract: false } && injectorType.IsAssignableFrom(t));

        foreach (var type in injectors)
        {
            var injector = (IInjector)Activator.CreateInstance(type)!;
            injector.RegisterServices(builder);
        }
    }
}
