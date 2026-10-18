using School.Models;
using System.ComponentModel.DataAnnotations;

namespace School.DTOs
{
    public class getteacherrdto
    {

        public int TeacherId { get; set; }

     
        public string Email { get; set; }
    
        public string Fristname { get; set; }
      
        public string Lastname { get; set; }
         
        public string PhoneNumber { get; set; }
        
        public decimal salary { get; set; }
       public int Departmentid {  get; set; }
    }
}
