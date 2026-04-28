namespace Delta.NearAcademy.Student;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _repository;

    public StudentService(IStudentRepository repository)
    {
        _repository = repository;
    }

    public List<Student> GetStudents() => _repository.GetStudents();
}
