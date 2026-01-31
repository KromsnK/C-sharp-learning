using SchoolAPI.Models;
namespace SchoolAPI.Services
{
    public interface IStudentService
    {
        Student GetStudent(int id);
        List<Student> GetStudents();
    }
}
