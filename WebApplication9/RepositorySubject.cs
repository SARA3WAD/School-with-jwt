using WebApplication9.Models;

namespace WebApplication9
{
    public class RepositorySubject : IRepositorySubject
    {
        private readonly AppDbContext _context;
        public RepositorySubject(AppDbContext context)
        {
            _context = context;
        }


        public List<Subject> GetSubject()
        {
            var s = _context.Subjects.ToList();
            return s;

        }
        public void addsubject(SubjectDto subject)
        {
            Subject ss = new Subject
            {
                subject_name = subject.subject_name
            };
            _context.Subjects.Add(ss);
            _context.SaveChanges();
        }
    }
}
