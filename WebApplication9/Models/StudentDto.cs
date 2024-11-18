using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class StudentDto
    {
        public string Name { get; set; }
        public string password { get; set; }
        [EmailAddress]
        public string email { get; set; }
        public int _Id { get; set; }
        public string SubjectName { get; set; }
    }
}
