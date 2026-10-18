using System.ComponentModel.DataAnnotations;

namespace School.DTOs
{
    public class GetdepartmentDTOcs
    {
        public int DepartmentId { get; set; }
      
        public string Name { get; set; }
        
        public string? Description { get; set; }
    }
}
