using WebApplication9.Models;

namespace WebApplication9
{
    public interface IRepositorySubject
    {
        public List<Subject> GetSubject();
        public void addsubject(SubjectDto subject);

    }
}
