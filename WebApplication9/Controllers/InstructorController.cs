using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InstructorController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult AddINstructor([FromForm]INstructorDto instryctor)
        {

            Instructor i1 = new Instructor
            {
                Name = instryctor.Name,
                Salary = instryctor.Salary,
                SubjectId=instryctor.subject,
            };
            _context.Instructors.Add(i1);
            _context.SaveChanges();
            return Ok();
        }
        [HttpGet] public IActionResult GetInstructors()
        {
            var s = _context.Instructors.ToList();
            return Ok(s);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateInstructor(INstructorDto nstructorDto,int id) { 
             var res=_context.Instructors.FirstOrDefault(x=>x.InstructorId==id);
          
            res.Name = nstructorDto.Name;
            res.Salary = nstructorDto.Salary;
            res.SubjectId = nstructorDto.subject;
            _context.Instructors.Update(res);
            _context.SaveChanges();
        
            return Ok(res);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteInstructor(int id)
        {
            var s = _context.Instructors.FirstOrDefault(i => i.InstructorId == id);
            _context.Instructors.Remove(s);
            _context.SaveChanges();
            return Ok(s);
        }
    }
}
