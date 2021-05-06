using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace CSharp_Take_2
{
    internal class User
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

    internal class Program
    {
        private static User addUser(string name)
        {
            User user = new User();
            user.Name = name;

            //Console.WriteLine("Enter Date of Birth <DD/MM/YYYY>");
            //user.DateOfBirth = Console.ReadLine();

            //Console.WriteLine("Enter Phone Number");
            //user.PhoneNumber = Console.ReadLine();

            //Console.WriteLine("Enter City");
            //user.City = Console.ReadLine();

            //Console.WriteLine("Enter Postal Code");
            //user.PostCode = Console.ReadLine();

            //Console.WriteLine("Account Activated? Y/N");
            //user.Activated = Console.ReadLine();

            Console.WriteLine("Number of Loggins");
            user.Logins = Console.ReadLine();

            return user;
        }

        private static void Main(string[] args)
        {
            dynamic users = new ExpandoObject();

            for (int i = 0; i >= 0; i++ )
            {
                Console.WriteLine("1. Add New User");
                Console.WriteLine("2. Print List");
                Console.WriteLine("3. Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.WriteLine("Enter Username");
                            string username = Console.ReadLine();
                            users.username = addUser(username);
                            break;
                        }
                    case "2":
                        foreach (KeyValuePair<string, object> obj in users)
                        {
                            Console.WriteLine(obj.Key);
                            //foreach (object Key in obj.Key);
                        }
                        Console.WriteLine("Press Any Key");
                        Console.ReadLine();
                        break;
                    case "3":
                        i = -10;
                        break;
                }
            }

        }
    }
}