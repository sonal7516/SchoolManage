using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManage.Models
{
    public class Year
    {
        public int ID { get; set; }
        public string YearName { get; set; }
        public virtual List<Subject> Subjects { get; set; }
    }
}
