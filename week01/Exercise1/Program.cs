using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your First name? ");
        string Fname = Console.ReadLine();
        Console.WriteLine("What is your Last name? ");
        string Lname = Console.ReadLine();
        Console.WriteLine($"Your name is {Lname}, {Fname} {Lname}");
    }
}