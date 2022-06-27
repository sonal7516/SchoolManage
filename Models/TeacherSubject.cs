using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManage.Models
{
    public class TeacherSubject
    {
        public int Id { get; set; }
        public string ApplicationUserID { get; set; }
        public int SubjectId { get; set; }
        public virtual ApplicationUser Teacher { get; set; }
        public virtual Class Class { get; set; }
        public DateTime Created_On { get; set; }
        public DateTime Modified_On { get; set; }
    }
}
