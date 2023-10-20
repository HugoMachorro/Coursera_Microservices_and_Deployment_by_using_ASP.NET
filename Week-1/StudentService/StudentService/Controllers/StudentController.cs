using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using StudentService.Services;

namespace StudentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository) => _studentRepository = studentRepository;

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_studentRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var student = _studentRepository.Get(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

      
    }
}
