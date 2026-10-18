using System.Net.WebSockets;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.DTOs;
using School.Models;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class teachersController : ControllerBase
    {
        private readonly SchoolDBcontext contextt;

        public  teachersController()
        {
            contextt = new SchoolDBcontext();
        }


        [HttpGet("{id}")]

        public async Task<IActionResult> getteacher(int id )
        {
            var r = await contextt.Teachers.FindAsync(id);
            if (r == null)
            {
                return NotFound();
            }

            var e = new getteacherrdto
            {
               TeacherId=r.TeacherId,
               Fristname=r.Fristname,
               Lastname=r.Lastname,
               PhoneNumber=r.PhoneNumber,
               Email=r.Email,
               salary=r.salary
            };

            return Ok(e);

        }


        [HttpPost]

        public IActionResult postteacher(createTeacherDto t)
        {
          
           
            var y = new Teacher
            {
                Fristname = t.Fristname,
                Lastname = t.Lastname,
                PhoneNumber = t.PhoneNumber,
                Email = t.Email,
                salary = t.salary,
                DepartmentId = t.DeptId

               
                
            };

         


                contextt.Teachers.Add(y);
             contextt.SaveChanges();
            return Ok(y);



        }

          public IActionResult getall()
           {
               var t = contextt.Teachers.ToList();
               if(t == null || t.Count == 0)
               {
                   return NotFound();
               }
               var r = new  List<getteacherrdto>();
               {
                  foreach(var item in t)
                   {
                       var tt = new getteacherrdto() { 

                           TeacherId = item.TeacherId,
                           Lastname=item.Lastname,
                           PhoneNumber = item.PhoneNumber,
                           Email = item.Email,
                           salary=item.salary,
                           Fristname=item.Fristname,

                       };
                       r.Add(tt);

                   }
               };
               return Ok(r);



           }


        [HttpDelete("{id}")]

        public IActionResult delete(int id)
        {
            var e = contextt.Teachers.FirstOrDefault(t => t.TeacherId == id);
            if (e == null) { return NotFound(); }
            contextt.Teachers.Remove(e);
            contextt.SaveChanges();
            return Ok(e);

        }


        [HttpPut("{id}")]

        public IActionResult putteacher(int id , Teacher t)
        {
            var r = contextt.Teachers.FirstOrDefault(t => t.TeacherId == id);
            if(r == null) { return NotFound(); };
            contextt.Teachers.Update(r);
            contextt.SaveChanges();
            return Ok(r);
        }

        [HttpPatch]

         






    }
}
