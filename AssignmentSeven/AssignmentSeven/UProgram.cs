using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSeven
{
    class UProgram
    {
        public string ProgrameName { get; set; }
        public Degree[] uDegree { get; set; }
        public UProgram(string programName)
        {
            uDegree = new Degree[4];
            this.ProgrameName = programName;
        }

    }
}
