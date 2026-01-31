using SchoolAPI.Repositories;
using SchoolAPI.Models;
namespace SchoolAPI.Services
{
    public class StudentServices : IStudentService
    {
        private readonly IStudentRepository repo;
        public StudentServices(IStudentRepository repo)
        {
            this.repo = repo;
        }
        public Student GetStudent(int id)
            =>repo.GetById(id);
        public List<Student> GetStudents()
            =>repo.GetAll();
    }
}
