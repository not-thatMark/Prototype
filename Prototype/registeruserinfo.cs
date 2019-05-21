using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prototype
{
    public class registerUserInfo
    {
        string firstName, lastName, ip;
        int age, phoneNo;

        public string FirstName
        {
            set { firstName = value; }
            get { return firstName; }
        }
        public string LastName
        {
            set { lastName = value; }
            get { return lastName; }
        }
        public string IP
        {
            set { ip = value; }
            get { return ip; }
        }
        public int PhoneNumber {
            set { phoneNo = value; }
            get { return phoneNo; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }


    }
}