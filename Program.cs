using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Take_2
{
    class User
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private string dateOfBirth;
        public string DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; } }

        private string phoneNumber;
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }

        private string city;
        public string City { get { return city; } set { city = value; } }

        private string postCode;
        public string PostCode { get { return postCode; } set { postCode = value; } }

        private string activated;
        public string Activated { get { return activated; } set { activated = value; } }

        private string logins;
        public string Logins { get { return logins; } set { logins = value; } }
    }
        class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Enter Name");
            string user.Name = Console.ReadLine();
            
            var users = new List<User>();

            var user = users.Where(u => u.FirstName == "John");
            user.Count


            Console.WriteLine("Enter Date of Birth");
            Console.WriteLine("Enter Phone Number");
            Console.WriteLine("Enter City");
            Console.WriteLine("Enter Postal Code");
            Console.WriteLine("Account Activated? Y/N");
            Console.WriteLine("Number of Loggins");

        }
    }
}
