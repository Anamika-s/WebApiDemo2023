using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IActionResult Get()
        {
            List<Student> students = new List<Student>()
                {
                 new Student{ Id = 1,Name="ajay"},
                 new Student{ Id = 2,Name="ajay"}
            };
            return Ok(students);
        
        }
        
    }
}
