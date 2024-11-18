using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class Subject
    {
        [Key] public int SubjectId { get; set; }
        public string subject_name { get; set; 
        }
        public List<Student> students { get; set; }
        public Instructor instructor { get; set; }
    }
}
