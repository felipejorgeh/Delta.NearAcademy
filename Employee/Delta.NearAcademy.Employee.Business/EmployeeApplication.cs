namespace Delta.NearAcademy.Employee;

public class EmployeeApplication : IEmployeeApplication
{
    private readonly IEmployeeService _service;

    public EmployeeApplication(IEmployeeService service)
    {
        _service = service;
    }

    public List<Employee> GetEmployees() => _service.GetEmployees();

    public void AddEmployee(AddEmployeeDto dto) => _service.AddEmployee(dto);
}
