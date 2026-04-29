namespace Delta.NearAcademy.Student;

public class StudentApplication : IStudentApplication
{
    private readonly IStudentService _service;

    public StudentApplication(IStudentService service)
    {
        _service = service;
    }

    public List<Student> GetStudents() => _service.GetStudents();

    public void AddStudent(AddStudentDto dto) => _service.AddStudent(dto);
}
