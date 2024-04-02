using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    // http://localhost:port/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[] {"John", "Jane", "Mark", "Emily", "David" };
            return Ok(studentNames);
        }
    }
}