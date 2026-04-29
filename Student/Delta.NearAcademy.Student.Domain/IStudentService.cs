namespace Delta.NearAcademy.Student;

public interface IStudentService
{
    List<Student> GetStudents();
    void AddStudent(AddStudentDto dto);
}
