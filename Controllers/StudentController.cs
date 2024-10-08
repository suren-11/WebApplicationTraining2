using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTraining2.model;

namespace WebApplicationTraining2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet("{name}/{dateOfBirth}")]
        public IActionResult Greet(string name, string dateOfBirth)
        {
            DateTime birthDate = DateTime.Parse(dateOfBirth);
            int age = DateTime.Now.Year - birthDate.Year;

            return Ok($"Hello, my name is {name} and I am {age} years old.");
        }

        [HttpPost()]
        public IActionResult GetFromStudent(Student student)
        {
            int age = DateTime.Now.Year - student.DateOfBirth.Year;

            return Ok($"Hello, my name is {student.FullName} and I am {age} years old.");

        }
    }
}
