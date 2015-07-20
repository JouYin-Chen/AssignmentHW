using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFive
{
    class UProgram
    {

        public string ProgrameName { get; set; }
        public string departmentHead { get; set; }
        public string degrees { get; set; }
        public Degree[] uDegree { get; set; }

        public UProgram(string programName, string dep, string deg)
        {
            uDegree = new Degree[4];
            this.ProgrameName = programName;
            this.departmentHead = dep;
            this.degrees = deg;
        }
    }
}
