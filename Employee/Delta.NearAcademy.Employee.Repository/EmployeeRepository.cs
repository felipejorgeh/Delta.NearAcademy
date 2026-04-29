namespace Delta.NearAcademy.Employee;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly NearAcademyDbContext _context;

    public EmployeeRepository(NearAcademyDbContext context)
    {
        _context = context;
    }

    public List<Employee> GetEmployees()
    {
        return _context.Employees
            .Select(e => new Employee
            {
                Id = e.Id,
                Name = e.Name,
                Email = e.Email
            })
            .ToList();
    }

    public void AddEmployee(AddEmployeeDto dto)
    {
        var entity = new EmployeeEntity
        {
            Name = dto.Name,
            Email = dto.Email
        };

        _context.Employees.Add(entity);
        _context.SaveChanges();
    }
}
