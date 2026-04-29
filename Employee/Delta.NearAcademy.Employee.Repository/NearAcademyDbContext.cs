using Microsoft.EntityFrameworkCore;

namespace Delta.NearAcademy.Employee;

public class NearAcademyDbContext : DbContext
{
    public NearAcademyDbContext(DbContextOptions<NearAcademyDbContext> options) : base(options) { }

    public DbSet<EmployeeEntity> Employees { get; set; }
}
