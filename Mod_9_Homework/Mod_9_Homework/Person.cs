using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
{
    class Person
    {
        private string _FirstName;
        private string _LastName;
        private string _City;

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
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
    }
}
