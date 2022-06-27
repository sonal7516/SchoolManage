using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManage.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime Created_On { get; set; }
        public DateTime Modified_On { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string EnrollmentNo { get; set; }
        public int RoleCode { get; set; }
        public string Gender { get; set; }

        public virtual List<StudentSubject> Students { get; set; }
        public virtual List<TeacherSubject> Teachers { get; set; }

    }

    
}
