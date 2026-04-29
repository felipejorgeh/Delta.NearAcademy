namespace Delta.NearAcademy.Student;

public interface IStudentApplication
{
    List<Student> GetStudents();
    void AddStudent(AddStudentDto dto);
}
