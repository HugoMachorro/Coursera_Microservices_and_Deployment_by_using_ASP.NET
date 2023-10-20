using Microsoft.AspNetCore.Mvc;
using TeacherService.Services;

namespace TeacherService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherController(ITeacherRepository teacherRepository) => _teacherRepository = teacherRepository;
        
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_teacherRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var student = _teacherRepository.Get(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
    }
}
