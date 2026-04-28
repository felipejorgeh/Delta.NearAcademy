using System.Reflection;
using Delta.NearAcademy;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.DependencyInjection;

namespace Delta.NearAcademy;

public static class ControllerAggregator
{
    public static void AddControllers(WebApplicationBuilder builder)
    {
        var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies();

        var controllerServiceType = typeof(IControllerService);
        var controllerAssemblies = loadedAssemblies
            .Where(a => a.GetTypes().Any(t =>
                t is { IsClass: true, IsAbstract: false } && controllerServiceType.IsAssignableFrom(t)))
            .Distinct()
            .ToList();

        builder.Services
            .AddControllers()
            .ConfigureApplicationPartManager(manager =>
            {
                foreach (var assembly in controllerAssemblies)
                {
                    var part = new AssemblyPart(assembly);
                    if (!manager.ApplicationParts.OfType<AssemblyPart>().Any(p => p.Assembly == assembly))
                        manager.ApplicationParts.Add(part);
                }
            });
    }
}
