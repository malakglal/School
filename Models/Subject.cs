using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId {  get; set; }
        [Required,MaxLength(100)]
        public string SubjectName { get; set; }

        [Required,MaxLength(500)]
        public string? SubjectDescription { get; set; }

        [Required,Range(0,100)]
        public int Maxgrade {  get; set; }
        public int TeacherId { get; set; }
      public Teacher Teacher { get; set; }


        public ICollection<Enrollment> Enrollments { get; set; }


    }
}
