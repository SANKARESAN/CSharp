using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Faculty : IPerson, IAddress, IContact
    {
        public int rollno { get; set; }
        public string pname { get; set; }
        public char gender { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long Zipcode { get; set; }
        public long mobile { get; set; }
        public long email { get; set; }

        public static int id = 0;
        
        public static int incrementID()
        {
            return ++id;
        }

        public void showDetails()
        {
            if (rollno > 0)
            {
                Console.WriteLine("Roll No: " + rollno);
            }
            if (pname != "")
            {
                Console.WriteLine("Name of Student: " + pname);
            }
            if (gender != ' ')
            {
                Console.WriteLine("Gender: " + gender);
            }
        }

        public string getAddress()
        {
            return $"City: {City}, State: {State}, Zipcode: {Zipcode}";
        }


        public string showContact()
        {
            return $"Phone Number: {mobile}, Email: {email}";
        }
    }
}
