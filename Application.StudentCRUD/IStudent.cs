using Domain.StudentCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.StudentCRUD
{
    public interface IStudent
    {
        Task<Student> AddStudent(Student student);
        Task<IEnumerable<Student>> GetAllStudent();
        Task<Student> UpdateStudent(Student student);
        Task DeleteStudent(Student id);
        Task<IEnumerable<Student>> GetStudentById(String id);
        Task DeleteStudent(string id);
    }
}
