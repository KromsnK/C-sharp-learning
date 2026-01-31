using SchoolAPI.Models;
using SchoolAPI.Repositories;
namespace SchoolAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> students = new()
        {
            new Student { Id = 1, Name = "Oleg", Age = 19 },
            new Student { Id = 2, Name = "Anton", Age = 18 }
        };
        public Student GetById(int id)
            =>students.FirstOrDefault(s=>s.Id == id);
        public List<Student> GetAll()
            => students;
        
    }
}
