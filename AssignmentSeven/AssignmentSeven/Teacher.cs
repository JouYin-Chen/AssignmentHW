using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSeven
{
    class Teacher : Person
    {
        public static int count;
        public Teacher()
        {
            count++;
        }
        public int countnum
        {
            get { return count; }
        }
    }
}
