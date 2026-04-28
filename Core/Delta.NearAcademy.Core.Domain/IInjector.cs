using Microsoft.AspNetCore.Builder;

namespace Delta.NearAcademy;

public interface IInjector
{
    void RegisterServices(WebApplicationBuilder builder);
}
