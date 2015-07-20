using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFour
{
    struct Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime birthdate { get; set; }
    }
    struct Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime birthdate { get; set; }
    }
    struct program
    {
        public string ProgramName { get; set; }
        public string DepartmentHead { get; set; }
        public int Degrees { get; set; }
    }
    struct Course
    {
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public int Duration { get; set; }
        public string Teacher { get; set; }
    }
    class Program
    {
        enum Day : short { Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        static void Main(string[] args)
        {

            int x = (int)Day.Monday;
            Student[] student1 = new Student[5];
            for (int i = 0; i < student1.Length; i++)
            {
                Console.WriteLine("第{0}位, Enter the student's first name: ", i + 1);
                student1[i].FirstName = Console.ReadLine();
                Console.WriteLine("第{0}位, Enter the student's last name: ", i + 1);
                student1[i].LastName = Console.ReadLine();
                Console.WriteLine("第{0}位, Enter the student's birthdate(DD/MM/YYYY): ", i + 1);
                string birthday = Console.ReadLine();
                try
                {
                    DateTime birthdayDate = DateTime.Parse(birthday);
                    student1[i].birthdate = birthdayDate;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
            for (int i = 0; i < student1.Length; i++)
            {
                Console.WriteLine("第{0}位,Student's name : {1} {2},Student's birthdate ; {3}", i + 1, student1[i].FirstName, student1[i].LastName, student1[i].birthdate);
            }
            Console.ReadKey();
        }
    }
}