using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSix
{
    class Course
    {
        public string CourseName;

        public Student[] cStudents { get; set; }
        public Teacher cTeachers { get; set; }

        public Course(string CourseName) {
            this.CourseName = CourseName;
            cStudents = new Student[3];
            cTeachers = new Teacher();
        }

    }
}
