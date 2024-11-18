using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IRepositoryStudent _repo;
        public StudentController(IRepositoryStudent repo)
        {
            _repo = repo;
        }
        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
           var res= _repo.GetAll();
            return Ok(res);
        }
        [HttpPost]
        public IActionResult Add(StudentDto student)
        {
          _repo.Add(student);
            return Ok();    
        }

        [HttpDelete("{id}")]
        public IActionResult Deletestudent(int id) { 
            _repo.Deletestudent(id);
            return Ok();
        }
        //[HttpPost]
        //public IActionResult addstudent(StudentDto student)
        //{
        //Student student1 = new Student
        //{
        //    Name = student.Name,
        //    password = student.password,
        //    email = student.email,
        //    SubjectId = student._Id
        //};
        //_context.Students.Add(student1);
        //    _context.SaveChanges();
        //    return Ok(student);
        //}
        //[HttpGet]
        //public IActionResult getstudent()
        //{
        //    var g = _context.Students.Include(x => x.SubjectSubject).Select(i=>new
        //    {
        //        i.Name,
        //        i.email,
        //        i.SubjectSubject.subject_name
        //    }
        //    );
        //    return Ok(g);
        //}
    }
}
