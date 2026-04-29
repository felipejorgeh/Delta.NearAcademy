using Xunit;

namespace Delta.NearAcademy.Student;

public class StudentTest
{
    [Fact]
    public void CreateAndGetStudentTest()
    {
        // Arrange
        IStudentRepository repository = new MockStudentRepository();
        IStudentService service = new StudentService(repository);

        var dto = new AddStudentDto
        {
            Name = "Test Student",
            Email = "test@example.com"
        };

        // Act
        service.AddStudent(dto);
        var students = service.GetStudents();

        // Assert
        Assert.Contains(students, s => s.Name == dto.Name && s.Email == dto.Email);
    }
}
