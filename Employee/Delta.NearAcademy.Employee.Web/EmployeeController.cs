using Microsoft.AspNetCore.Mvc;

namespace Delta.NearAcademy.Employee;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeApplication _application;

    public EmployeeController(IEmployeeApplication application)
    {
        _application = application;
    }

    [HttpGet]
    public ActionResult<List<Employee>> GetEmployees()
    {
        return Ok(_application.GetEmployees());
    }

    [HttpPost]
    public IActionResult AddEmployee([FromBody] AddEmployeeDto dto)
    {
        _application.AddEmployee(dto);
        return Created();
    }
}
