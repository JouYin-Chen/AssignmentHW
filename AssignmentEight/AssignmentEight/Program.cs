using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEight
{
    class Program
    {
        static void Main(string[] args)
        {
            Course cu = new Course("Programming with C#");

            for (int i = 1; i <= 3; i++)
            {
                Student student = new Student("student" + i, "a" + i);
                for (int j = 0; j <= 4; j++)
                {
                    student.Grades.Push(100 - (j * 10));
                }

                cu.AddStudent(student);
            }
            cu.ListStudent();
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
    }
}
