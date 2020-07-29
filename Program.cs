using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Names());
            Console.WriteLine(Emails());
            Console.WriteLine(PhoneNumber());
            Console.WriteLine(Date());
        }

        public static string Names()
        {
            Console.WriteLine("Please Enter A Name (must start with a capital letter): ");
            string nameInput = Console.ReadLine();
            if (Regex.IsMatch(nameInput, @"\b[A-Z][a-z]{0,30}\b"))
            {
                string name = "That's a valid name.";
                return name;
            }
            else
            {
                string notName = "That's not a valid name.";
                return notName;
            }
        }
        public static string Emails()
        {
            Console.WriteLine("Please Enter A Valid Email Address: ");
            string emailName = Console.ReadLine();
            if (Regex.IsMatch(emailName, @"\b[A-Z,a-z,0-9]{5,30}\b[@]\b[A-Z,a-z,0-9]{5,10}\b[.]\b[A-Z,a-z,0-9]{2,3}\b"))
            {
                string email = "Thank you.";
                return email;
            }
            else
            {
                string notEmail = "That is not a valid email address.  Please try again.";
                return notEmail;
            }
        }
        public static string PhoneNumber()
        {
            Console.WriteLine("Please Enter In Your Phone Number With Area Code:(999-999-9999) ");
            string phone = Console.ReadLine();
            if (Regex.IsMatch(phone, @"\b[0-9]{3}[-][0-9]{3}[-][0-9]{4}\b"))
            {
                string number = "Thank You";
                return number;
            }
            else
            {
                string notNumber = "Please make sure to add in(-)inbetween.";
                return notNumber;
            }
        }
        public static string Date()
        {
            Console.WriteLine("Please Enter In The Current Date:(mm/dd/yyyy) ");
            string date = Console.ReadLine();
            if (Regex.IsMatch(date, @"\b[0-9]{2}[/][0-9]{2}[/][0-9]{4}\b"))
            {
                string theDate = "Thank You";
                return theDate;
            }
            else
            {
                string notTheDate = "Please be sure to use the following format: dd/mm/yyyy";
                return notTheDate;
            }
        }
    }
}
