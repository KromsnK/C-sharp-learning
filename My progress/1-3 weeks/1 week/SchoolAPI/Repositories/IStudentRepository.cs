using SchoolAPI.Models;
namespace SchoolAPI.Repositories
{
    public interface IStudentRepository
    {
        Student GetById(int id);
        List<Student> GetAll();
    }
}
