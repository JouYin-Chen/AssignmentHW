using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            String FirstName = "Tom";
            String LastName = "Lusis";
            String Birthdate = "1991/1/23";
            String AddressLine1 = "蓮海路";
            String AddressLine2 = "鼓山區";
            String City = "高雄市";
            String State_Province = "台灣省";
            int Zip_Postal = 70;
            String Country = "Taiwan";

            Console.WriteLine("Name : {0} {1}\r\n",FirstName, LastName);
            Console.WriteLine("Birthdate : {0}\r\n",Birthdate);
            Console.WriteLine("Address : {0} {1} {2} {3} No. {4}\r\n" , AddressLine1 , AddressLine2 , City , State_Province , Zip_Postal);
            Console.WriteLine("Country : {0}", Country);
            Console.ReadKey();
        }
    }
}
