using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFive
{
    class Teacher
    {
        public static int count;
        private string _FirstName;
        private string _LastName;
        private string _Addr1;
        private string _Addr2;
        private string _City;
        private string _State;
        private string _Zip;
        private string _Country;
        private DateTime _Dob;

        public Teacher()
        {
            count++;
        }
        public int countnum
        {
            get { return count; }
        }
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public string Addr1
        {
            get { return _Addr1; }
            set { _Addr1 = value; }
        }

        public string Addr2
        {
            get { return _Addr2; }
            set { _Addr2 = value; }
        }

        public string City
        {
            get { return _City; }
            set { _City = value; }
        }

        public string State
        {
            get { return _State; }
            set { _State = value; }
        }

        public string Zip
        {
            get { return _Zip; }
            set { _Zip = value; }
        }

        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }

        public DateTime Dob
        {
            get { return _Dob; }
            set { _Dob = value; }
        }
    }
}
