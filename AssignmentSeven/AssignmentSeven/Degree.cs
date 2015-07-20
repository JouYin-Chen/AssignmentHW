using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSeven
{
    class Degree
    {
        public string DegreeName { get; set; }
        public Course[] dCourse { get; set; }

        public Degree(string degreeName)
        {
            dCourse = new Course[1];
            this.DegreeName = degreeName;
        }
    }
}
