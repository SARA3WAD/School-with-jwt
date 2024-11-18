using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class INstructorDto
    {
        [MaxLength(20)]
        public string Name { get; set; }
        public string Salary { get; set; }
        public int subject { get; set; }
    }
}
