using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Delta.NearAcademy.Employee;

public class EmployeeInjector : IInjector
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        //builder.Services.AddDbContext<NearAcademyDbContext>(options =>
        //    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        //builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        builder.Services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
        builder.Services.AddScoped<IEmployeeService, EmployeeService>();
        builder.Services.AddScoped<IEmployeeApplication, EmployeeApplication>();
    }
}
