using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Delta.NearAcademy.Student;

public class StudentInjector : IInjector
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<NearAcademyDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        builder.Services.AddScoped<IStudentRepository, StudentRepository>();
        builder.Services.AddScoped<IStudentService, StudentService>();
        builder.Services.AddScoped<IStudentApplication, StudentApplication>();
    }
}
