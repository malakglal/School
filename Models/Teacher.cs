using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId {  get; set; }

        [Required, EmailAddress,MaxLength(150)]
        public string Email {  get; set; }
        [Required,MaxLength(50)]
        public string Fristname { get; set; }
        [Required, MaxLength(50)]
        public string Lastname {  get; set; }   
        [Required, MaxLength(20)]
        public string PhoneNumber {  get; set; }
        [Required ,Range(0,int.MaxValue)]
        public decimal salary {  get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<Subject> Subjects { get; set; }

    }
}
