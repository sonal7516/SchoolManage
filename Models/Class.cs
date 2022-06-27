using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManage.Models
{
    public class Class
    {
        public int ID { get; set; }
        public string ClassName { get; set; }
        public virtual List<Subject> Subjects { get; set; }
        public DateTime Created_On { get; set; }
        public DateTime Modified_On { get; set; }
    }
}
