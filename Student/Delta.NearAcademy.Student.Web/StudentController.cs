using Delta.NearAcademy;
using Microsoft.AspNetCore.Mvc;

namespace Delta.NearAcademy.Student;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase, IControllerService
{
    private readonly IStudentApplication _application;

    public StudentController(IStudentApplication application)
    {
        _application = application;
    }

    [HttpGet]
    public ActionResult<List<Student>> GetStudents()
    {
        return Ok(_application.GetStudents());
    }
}
