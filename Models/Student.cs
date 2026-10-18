using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class Student
    {
        [Key]
        public int StudentId {  get; set; }
        [Required, MaxLength(50)]
        public string FristName { get; set; }
        [Required, MaxLength(50)]
        public string LastName {  get; set; }
        [Required, EmailAddress, MaxLength(150)]
        public string Email {  get; set; }
        [Required, MaxLength(20)]
        public string  PhoneNumber {  get; set; }
        [Required]
        public DateOnly Dateofbirth { get; set; }

        public Classroom Classroom { get; set; }
        public int ClassroomId { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
       


    }
}
