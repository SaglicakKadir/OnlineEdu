using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
    public class AppUser:IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ImageURL { get; set; }
        public List<Course> Courses { get; set; } //her bir kişinin birden fazla kursu olabilir
        public List<CourseRegister> CourseRegisters { get; set; } //her bir kişinin birden fazla kursu olabilir
    }
}
