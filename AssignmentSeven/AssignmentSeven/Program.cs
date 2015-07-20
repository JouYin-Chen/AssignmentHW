using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher ta = new Teacher();
            Course cu = new Course("Programming with C#");
           
            for(int i = 1; i <= 3 ; i++){
                Student student = new Student("student"+i, "a" + i);
                for (int j = 0; j <= 4; j++) {
                    student.Grades.Push(100-(j*10));
                }
                   
                    cu.AddStudent(student);
            }

            cu.ListStudent();
            ta.FirstName = "ta";
            ta.LastName = "1";

            Degree dg = new Degree("Bachelor");

            UProgram up = new UProgram("Information Technology");

            Console.WriteLine("The {0} program contains the {1} of Science degree\r\n", up.ProgrameName, dg.DegreeName);
            Console.WriteLine("The {0} of Science degree contains the course {1}\r\n", dg.DegreeName, cu.CourseName);
            Console.WriteLine("The {0} course contain {1} studeent(s)", cu.CourseName, cu.countnum);
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
    }
}
