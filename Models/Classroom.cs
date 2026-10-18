using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace School.Models
{
    public class Classroom
    {
        [Key]
        public int ClassroomId { get; set; }

        [Required,MaxLength(50)]
        public string Name { get; set; }
        [Required,Range (1,12)]
        public int GradeLevel {  get; set; }
        [Required, Range(1, 100)]
        public int  Capacity { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
