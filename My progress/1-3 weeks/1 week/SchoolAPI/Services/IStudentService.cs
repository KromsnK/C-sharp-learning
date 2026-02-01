using SchoolAPI.DTOs;
using SchoolAPI.Models;
namespace SchoolAPI.Services
{
    public interface IStudentService
    {
        Student GetStudent(int id);
        List<Student> GetStudents();
        Student Create(CreateStudentDto dto);
        void Update(int id, UpdateStudentDto dto);
        void Delete(int id);
    }
}
