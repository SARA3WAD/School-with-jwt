using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly IRepositorySubject _repo;
        private readonly ITaken _taken;
        public SubjectController(IRepositorySubject repo, ITaken taken)
        {
            _repo = repo;
            _taken = taken;
        }
        [Authorize]

        [HttpGet]
        public IActionResult GetSubject()
        {
            var s = _repo.GetSubject();
            return Ok(s);
        }
        [HttpPost]
        public IActionResult addsubject(SubjectDto subject)
        {
            _repo.addsubject(subject);
            var s = _taken.GetJwt();
            return Ok(s);
        }
        //[HttpPost]
        //public IActionResult addsubject(SubjectDto subject)
        //{
        //    Subject s1 = new Subject
        //    {
        //        subject_name = subject.subject_name
        //    };
        //    _context.Subjects.Add(s1);
        //    _context.SaveChanges();
        //    return Ok(subject);
        //}
        //[HttpGet]
        //public IActionResult getsubject()
        //{
        //    var s = _context.Subjects.ToList();
        //    return Ok(s);
        //}

        


    }
}
