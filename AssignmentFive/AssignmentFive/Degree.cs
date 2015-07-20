using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFive
{
    class Degree
    {
        public string DegreeName { get; set; }
        public string faculty { get; set; }
        public string creditPoints { get; set; }

        public Course[] dCourse { get; set; }

        public Degree(string degreeName, string facu, string credit)
        {
            dCourse = new Course[1];
            this.DegreeName = degreeName;
            this.faculty = facu;
            this.creditPoints = credit;
        }

    }
}
