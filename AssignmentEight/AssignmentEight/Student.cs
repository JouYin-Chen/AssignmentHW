using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEight
{
    class Student : Person
    {
        public static int count;
        public Stack<int> Grades;
        public Student(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
            Grades = new Stack<int>();
            count++;
        }
        public int countnum
        {
            get { return count; }
        }
    }
}
