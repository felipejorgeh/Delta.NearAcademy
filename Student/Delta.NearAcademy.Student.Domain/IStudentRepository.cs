namespace Delta.NearAcademy.Student;

public interface IStudentRepository
{
    List<Student> GetStudents();
    void AddStudent(AddStudentDto dto);
}
