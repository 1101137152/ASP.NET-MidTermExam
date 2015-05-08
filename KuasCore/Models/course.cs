using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Models
{
    public class course
    {
        public string course_id { get; set; }

        public string course_name { get; set; }

        public string course_Description { get; set; }

        public override string ToString()
        {
            return "course: id = " + course_id + ", Name = " + course_name + ", course_Description = " + course_Description + ".";
        }

    }
}
