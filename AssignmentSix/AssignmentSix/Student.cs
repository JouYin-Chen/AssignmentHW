using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSix
{
    class Student : Person
    {
        public static int count;
        public Student()
        {
            count++;
        }
        public int countnum {
            get { return count; }
        }
    }
}
