namespace Delta.NearAcademy.Employee;

public class MockEmployeeRepository : IEmployeeRepository
{
    private readonly List<Employee> _cache =
    [
        new Employee { Id = 1, Name = "Carlos García", Email = "carlos@example.com" },
        new Employee { Id = 2, Name = "Laura Martínez", Email = "laura@example.com" },
    ];

    private int _nextId = 3;

    public List<Employee> GetEmployees() => [.. _cache];

    public void AddEmployee(AddEmployeeDto dto)
    {
        _cache.Add(new Employee
        {
            Id = _nextId++,
            Name = dto.Name,
            Email = dto.Email
        });
    }
}
