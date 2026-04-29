using Xunit;

namespace Delta.NearAcademy.Employee;

public class EmployeeTest
{
    [Fact]
    public void CreateAndGetEmployeeTest()
    {
        // Arrange
        IEmployeeRepository repository = new MockEmployeeRepository();
        IEmployeeService service = new EmployeeService(repository);

        var dto = new AddEmployeeDto
        {
            Name = "Test Employee",
            Email = "test@example.com"
        };

        // Act
        service.AddEmployee(dto);
        var employees = service.GetEmployees();

        // Assert
        Assert.Contains(employees, e => e.Name == dto.Name && e.Email == dto.Email);
    }
}
