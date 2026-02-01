using Microsoft.AspNetCore.Mvc;
using SchoolAPI.DTOs;
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
    /*[HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var student = service.GetStudent(id);
        if(student == null) return NotFound();
        return Ok(student);
    }
    */
    [HttpPost]
    public IActionResult Create(CreateStudentDto dto)
    {
        try
        {
            var student = service.Create(dto);
            return Ok(student);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, UpdateStudentDto dto)
    { 
        service.Update(id, dto);
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        service.Delete(id);
        return NoContent();
    }
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        try
        {
            return Ok(service.GetStudent(id));
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

}