using SchoolAPI.DTOs;
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
        private int nextId = 1;
        public Student GetById(int id)
            =>students.FirstOrDefault(s=>s.Id == id);
        public List<Student> GetAll()
            => students;
        public void Add(Student student)
        {
            student.Id = nextId++;
        }
        public void Update(Student student)
        {
            var existing = GetById(student.Id);
            if (existing == null) return;
            existing.Name = student.Name;
            existing.Age = student.Age;
        }
        public void Delete(int id)
        {
            var student = GetById(id);
            if (student != null)
            {
                students.Remove(student);
            }
        }

    }
}
