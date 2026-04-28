namespace Delta.NearAcademy.Student;

public class StudentRepository : IStudentRepository
{
    private readonly NearAcademyDbContext _context;

    public StudentRepository(NearAcademyDbContext context)
    {
        _context = context;
    }

    public List<Student> GetStudents()
    {
        return _context.Students
            .Select(e => new Student
            {
                Id = e.Id,
                Name = e.Name,
                Email = e.Email
            })
            .ToList();
    }
}
