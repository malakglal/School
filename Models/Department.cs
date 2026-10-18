using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId {  get; set; }
        [Required,MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string? Description {  get; set; }
 
   
        public ICollection<Teacher> Teachers { get; set; }
    }
}
