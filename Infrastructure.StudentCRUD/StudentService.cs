
using Application.StudentCRUD;
using Domain.StudentCRUD;
using Infrastructure.StudentCRUD;
using Microsoft.EntityFrameworkCore;

namespace TutorialWebAPI.Service
{
    public class StudentService : IStudent
    {
        private readonly ApplicationDBContext _dbContext;

        public StudentService(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Student> AddStudent(Student student)
        {
            var result = await _dbContext.Students.AddAsync(student);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Student> DeleteStudent(Student student)
        {
            var result = await _dbContext.Students.AddAsync(student);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public Task<IEnumerable<Student>> GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Student>> GetStudentById(Student student)
        {
            var result = await _dbContext.Students.AddAsync(student);
            await _dbContext.SaveChangesAsync();
            return (IEnumerable<Student>)result.Entity;
        }

        public async Task<Student> UpdateStudent(Student student)
        {
            var result = await _dbContext.Students.AddAsync(student);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteStudent(string id)
        {
            var studentToDelete = await _dbContext.Students.FirstOrDefaultAsync(e => e.Id.ToString() == id);
            if (studentToDelete != null)
            {
                _dbContext.Students.Remove(studentToDelete);
                await _dbContext.SaveChangesAsync();
            }


        }


        public async Task<IEnumerable<Student>> GetStudentById(string id)
        {
            var result = await _dbContext.Students.Where(e => e.Id.ToString() == id).ToListAsync();
            return result;
        }

        Task IStudent.DeleteStudent(Student id)
        {
            throw new NotImplementedException();
        }
    }
}
