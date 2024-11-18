using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class Subcard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public List<Student> Students { get; set; }
    }
}
