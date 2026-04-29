namespace Delta.NearAcademy.Employee;

public interface IEmployeeService
{
    List<Employee> GetEmployees();
    void AddEmployee(AddEmployeeDto dto);
}
