namespace Delta.NearAcademy.Employee;

public interface IEmployeeApplication
{
    List<Employee> GetEmployees();
    void AddEmployee(AddEmployeeDto dto);
}
