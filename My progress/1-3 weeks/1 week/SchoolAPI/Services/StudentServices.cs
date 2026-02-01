using SchoolAPI.DTOs;
using SchoolAPI.Models;
using SchoolAPI.Repositories;
using System.Xml.Linq;
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
        public Student Create(CreateStudentDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name))
                throw new ArgumentException("Name is required");

            if (dto.Age <= 0 || dto.Age > 110)
                throw new ArgumentException("Invali age");

            var student = new Student
            {
                Name = dto.Name,
                Age = dto.Age
            };
            repo.Add(student);
            return student;
        }
        public void Update(int id, UpdateStudentDto dto)
        {
            var student = new Student
            {
                Name = dto.Name,
                Age = dto.Age
            }; repo.Update(student);
        }
        public void Delete(int id)
        {
            repo.Delete(id);
        }
        public Student GetById(int id)
        {
            var student = repo.GetById(id);
            if (student == null)
                throw new KeyNotFoundException("Student not found");
            return student;
        }
    }
}
