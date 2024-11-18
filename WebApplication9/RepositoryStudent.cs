using Microsoft.EntityFrameworkCore;
using WebApplication9.Models;

namespace WebApplication9
{
    public class RepositoryStudent:IRepositoryStudent
    {
        private readonly AppDbContext _context;
        public RepositoryStudent(AppDbContext context)
        {
            _context = context;
        }
        public List<StudentDto> GetAll()
        {
           var s =  _context.Students.Include(i => i.SubjectSubject).Select(i => new StudentDto
            {
                Name= i.Name,
                email = i.email,
                password= i.password,
               SubjectName = i.SubjectSubject.subject_name,
           }).ToList();
            return s;
        }
        public void Add(StudentDto student)
        {
            Student student1 = new Student
            {
                Name = student.Name,
                password = student.password,
                email = student.email,
                SubjectId = student._Id,
                
                
            };
            _context.Students.Add(student1);
            _context.SaveChanges();
        }
        public void Deletestudent(int id)
        {
            var res = _context.Students.FirstOrDefault(i => i.Id == id);
            _context.Students.Remove(res);
            _context.SaveChanges();

        }

        
    }
}
