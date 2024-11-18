using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class Student
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public Subject SubjectSubject { get; set; }

        public int SubjectId { get; set; }
        public Instructor Instructor { get; set; }
        public List<Subcard> Subcards { get; set; }
    }
}
