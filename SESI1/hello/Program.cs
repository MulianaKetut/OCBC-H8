using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string firstName, lastName, address;
            int age;
            DateTime birthDate;

            Console.Write("Enter Your First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter Your Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Enter Your Address: ");
            address = Console.ReadLine();

            Console.Write("Enter Your Birth Date (MM/dd/yyyy): ");
            birthDate = DateTime.Parse(Console.ReadLine());

            // Console.Write("Enter Your Age: ");
            // age = int.Parse(Console.ReadLine());

            //improve
            var today = DateTime.Today;
            var age1 = today.Year - birthDate.Year;

            Console.Read();
            Console.WriteLine("Name : " + firstName + " " + lastName);
            Console.WriteLine("Address : " + address);
            Console.WriteLine("Birth Date : " + birthDate.ToString("dd/MM/yyyy"));
            Console.Write("Age : " + age1);

        }
    }
}
