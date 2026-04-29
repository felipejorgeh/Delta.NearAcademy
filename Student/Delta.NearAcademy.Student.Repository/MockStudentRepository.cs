namespace Delta.NearAcademy.Student;

public class MockStudentRepository : IStudentRepository
{
    private readonly List<Student> _cache =
    [
        new Student { Id = 1, Name = "Alice Smith", Email = "alice@example.com" },
        new Student { Id = 2, Name = "Bob Johnson", Email = "bob@example.com" },
    ];

    private int _nextId = 3;

    public List<Student> GetStudents() => [.. _cache];

    public void AddStudent(AddStudentDto dto)
    {
        _cache.Add(new Student
        {
            Id = _nextId++,
            Name = dto.Name,
            Email = dto.Email
        });
    }
}
