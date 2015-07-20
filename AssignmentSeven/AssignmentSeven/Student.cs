using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSeven
{
    class Student : Person
    {
        public static int count;
        public Stack Grades;
        public Student(string fname,string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
            Grades= new Stack();
            count++;
        }
        public int countnum
        {
            get { return count; }
        }

    }
}
