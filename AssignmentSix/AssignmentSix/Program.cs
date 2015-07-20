using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher ta = new Teacher();
            //Console.WriteLine("Teacher's count:{0}", ta.count);
            Student[] student1 = new Student[3];
            for (int i = 0; i < 3;i++ ){
                student1[i] = new Student();
            }
            student1[0].FirstName = "su";
            student1[0].LastName = "1";
            student1[1].FirstName = "su";
            student1[1].LastName = "2";
            student1[2].FirstName = "su";
            student1[2].LastName = "3";

            //Console.WriteLine("Student's count: {0}",student1[1].countnum);

            Course cu = new Course("Programming with C#");
            //Console.WriteLine(cu.CourseName);
            for (int i = 0; i < 3; i++)
                cu.cStudents[i] = student1[i];
            ta.FirstName = "ta";
            ta.LastName = "1";
            cu.cTeachers = ta;

            Degree dg = new Degree("Bachelor");

            UProgram up = new UProgram("Information Technology");

            Console.WriteLine("The {0} program contains the {1} of Science degree\r\n", up.ProgrameName, dg.DegreeName);
            Console.WriteLine("The {0} of Science degree contains the course {1}\r\n", dg.DegreeName, cu.CourseName);
            Console.WriteLine("The {0} course contain {1} studeent(s)", cu.CourseName, student1[0].countnum);
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
    }
}
