namespace WebApplication9.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
        public List<Student> Students { get;set; }
        public Subject Subject { get; set; }
        public int SubjectId { get; set; }
    }
}
