using Microsoft.EntityFrameworkCore;

namespace Delta.NearAcademy.Student;

public class NearAcademyDbContext : DbContext
{
    public NearAcademyDbContext(DbContextOptions<NearAcademyDbContext> options) : base(options) { }

    public DbSet<StudentEntity> Students { get; set; }
}
