using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
{
    class Student : Person
    {
        public Student(string fname, string lname,string city)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.City = city;
        }

    }
}
