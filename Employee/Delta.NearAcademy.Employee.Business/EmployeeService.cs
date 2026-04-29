namespace Delta.NearAcademy.Employee;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repository;

    public EmployeeService(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    public List<Employee> GetEmployees() => _repository.GetEmployees();

    public void AddEmployee(AddEmployeeDto dto) => _repository.AddEmployee(dto);
}
