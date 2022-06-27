using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManage.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Subjectname { get; set; }
        public virtual List<StudentSubject> StudentCourse { get; set; }
        public virtual List<TeacherSubject> TeacherCourse { get; set; }
        public virtual Class Class { get; set; }
        public virtual Year Year { get; set; }
        public DateTime Created_On { get; set; }
        public DateTime Modified_On { get; set; }

    }
}
