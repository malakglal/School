using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId {  get; set; }
        [ForeignKey("StudentId")]
        public int StudentId { get; set; }
        [ForeignKey("SubjectId")]
        public int SubjectId { get; set; }
        [Required]
        public DateTime EnrollmentDate {  get; set; }
        [Required,Range(0,100)]
        public decimal Grade {  get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
    }
}
