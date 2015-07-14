using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GetStudentInformation();
                try
                {
                    ValidatingBirthdate();
                }
                catch (NotImplementedException)
                {
                    Console.WriteLine("ValidatingBirthdate method 有誤!!");
                }
                GetTeacherInformation();
                GetUprogramInformation();
                GetCourseInformation();
                GetDegreeInformation();
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("method 有誤!!");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);

        }
        static void PrintTeacherDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);

        }
        static void PrintUprogramInformation(string first, string last, string Degrees)
        {
            Console.WriteLine("Program name : {0},Department Head : {1}, Degrees : {2}", first, last, Degrees);

        }
        static void PrintDegreeInformation(string first, string last)
        {
            Console.WriteLine("Degree name:{0},Credits Required : {1}", first, last);

        }
        static void PrintCourseInformation(string first, string last, string Duration, string teacher)
        {
            Console.WriteLine("Course name : {0},Credits : {1},Duration : {2} and Teacher:{3}", first, last, Duration, teacher);

        }
        static void GetUprogramInformation()
        {
            Console.WriteLine("Enter the Program name: ");
            string ProgramName = Console.ReadLine();
            Console.WriteLine("Enter the Department Head");
            string DepartmentHead = Console.ReadLine();
            Console.WriteLine("Enter the Degrees");
            string Degrees = Console.ReadLine();
            PrintUprogramInformation(ProgramName, DepartmentHead, Degrees);
        }
        static void GetDegreeInformation()
        {
            Console.WriteLine("Enter the Degree name: ");
            string DegreeName = Console.ReadLine();
            Console.WriteLine("Enter the Credits Required");
            string Credits = Console.ReadLine();
            PrintDegreeInformation(DegreeName, Credits);
        }
        static void GetCourseInformation()
        {
            Console.WriteLine("Enter the Course name: ");
            string CourseName = Console.ReadLine();
            Console.WriteLine("Enter the Credits");
            string Credits = Console.ReadLine();
            Console.WriteLine("Enter the Duration ");
            string Duration = Console.ReadLine();
            Console.WriteLine("Enter the Teacher ");
            string Teacher = Console.ReadLine();
            PrintCourseInformation(CourseName, Credits, Duration, Teacher);
        }
        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday");
            string birthdate = Console.ReadLine();

            PrintStudentDetails(firstName, lastName, birthdate);
        }
        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birthday");
            string birthdate = Console.ReadLine();
            PrintTeacherDetails(firstName, lastName, birthdate);

        }
        static void ValidatingBirthdate()
        {
            throw new NotImplementedException();
        }
    }
}
