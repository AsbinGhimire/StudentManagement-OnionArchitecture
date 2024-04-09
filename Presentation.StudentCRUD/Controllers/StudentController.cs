using Application.StudentCRUD;
using Domain.StudentCRUD;
using Microsoft.AspNetCore.Mvc;
using TutorialWebAPI.Service;

namespace TutorialWebAPI.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent _studentService;

        public StudentController(IStudent studentService)
        {
            _studentService = studentService;
        }

        [HttpPost, Route("AddStudent")]
        public async Task<IActionResult> AddStudent(Student student)
        {
            var addStudent = await _studentService.AddStudent(student);
            return Ok(addStudent);
        }

        [HttpPut, Route("UpdateStudent")]

        public async Task<IActionResult> UpdateStudent(Student student)
        {
            var updateStudent = await _studentService.UpdateStudent(student);
            return Ok(updateStudent);
        }
        [HttpGet, Route("GetStudent")]

        public async Task<IActionResult> GetStudent(string id)
        {
            var getStudent = await _studentService.GetStudentById(id);
            return Ok(getStudent);
        }
        [HttpDelete, Route("DeleteStudent")]
        public async Task<IActionResult> DeleteStudent(string id)
        {
            var deleteResult = await _studentService.GetStudentById(id);
            if (deleteResult != null)
            {
                await _studentService.DeleteStudent(id);
                return Ok();
            }
            return NotFound();
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
