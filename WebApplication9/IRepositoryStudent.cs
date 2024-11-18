using WebApplication9.Models;

namespace WebApplication9
{
    public interface IRepositoryStudent
    {
        public List<StudentDto> GetAll();
        public void Add(StudentDto student);
        public void Deletestudent(int id);
    }
}
