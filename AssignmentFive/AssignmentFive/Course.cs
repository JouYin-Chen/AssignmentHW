using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFive
{
    class Course
    {
        public string CourseName { get; set; }
        public string credits { get; set; }
        public int durationInWeeks { get; set; }
        public Student[] cStudents { get; set; }
        public Teacher cTeachers { get; set; }

        public Course(string CourseName, string credit, int dura)
        {
            this.CourseName = CourseName;
            this.credits = credit;
            this.durationInWeeks = dura;
            cStudents = new Student[3];
            cTeachers = new Teacher();
        }
    }
}
