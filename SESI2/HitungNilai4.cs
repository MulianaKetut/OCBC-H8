using System;

class HitungNilai4
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        bool isAdult = age > 18;
        bool isPassword = password == "OCBC";

        //logic
        if (isAdult && isPassword)
        {
            Console.WriteLine("WELCOME TO THE OCBC!");
        }
        else
        {
            Console.WriteLine("Sorry, Try again!");
        }
    }
}