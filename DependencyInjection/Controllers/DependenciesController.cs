using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DependenciesController : ControllerBase
    {
        private readonly ITeacher _teacher;

        public  DependenciesController(ITeacher teacher)
        {
            _teacher=teacher;
        }

        [HttpGet("teacher")]
        public IActionResult GetTeacher()
        {
            var classRoom = new ClassRoom(_teacher);
            return Ok(classRoom.GetTeacherInfo());
        }
    }
}
