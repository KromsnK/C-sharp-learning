using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Services;
[ApiController]
[Route("api/students")]
public class StudentController : ControllerBase
{
    private readonly IStudentService service;
    public StudentController(IStudentService service)
    {
        this.service = service;
    }
    [HttpGet]
    public IActionResult GetAll()
        => Ok(service.GetStudents());
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var student = service.GetStudent(id);
        if(student == null) return NotFound();
        return Ok(student);
    }

}