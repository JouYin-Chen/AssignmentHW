using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFive
{
    class Program
    {
        static void Main(string[] args)
        {

            Student[] student1 = new Student[3];

            for (int i = 0; i < student1.Length; i++)
            {
                student1[i] = new Student();
            }
            student1[0].FirstName = "student1";
            student1[1].FirstName = "student2";
            student1[2].FirstName = "student3";


            Course cou = new Course("Programming with C#", "4", 12);
            for (int i = 0; i < 3; i++)
                cou.cStudents[i] = student1[i];

            Teacher teacher1 = new Teacher();
            teacher1.FirstName = "teacher1";
            cou.cTeachers = teacher1;

            Degree dg = new Degree("Bachelor", "資工系", "3");

            UProgram up = new UProgram("Information Technology", "Li", "博士");


            Console.WriteLine("The {0} program contains the {1} of Science degree\r\n", up.ProgrameName, dg.DegreeName);
            Console.WriteLine("The {0} of Science degree contains the course {1}\r\n", dg.DegreeName, cou.CourseName);
            Console.WriteLine("The {0} course contain {1} studeent(s)", cou.CourseName, student1.Length);
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
    }
}

