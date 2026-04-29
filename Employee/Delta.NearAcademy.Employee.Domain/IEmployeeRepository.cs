namespace Delta.NearAcademy.Employee;

public interface IEmployeeRepository
{
    List<Employee> GetEmployees();
    void AddEmployee(AddEmployeeDto dto);
}
