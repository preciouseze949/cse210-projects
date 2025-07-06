using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 97)
        {
            letter = "A+";
        }
        else if (percent < 93 && percent >= 90)
        {
            letter = "A-";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 87)
        {
            letter = "B+";
        }
        else if (percent < 83 && percent >= 80)
        {
            letter = "B-";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 77)
        {
            letter = "C+";
        }
        else if (percent < 73 && percent >= 70)
        {
            letter = "c-";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else if (percent >= 67)
        {
            letter = "D+";
        }
        else if (percent < 63 && percent >= 60)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else if (percent >= 97)
        {
            Console.WriteLine("You passed with a plus mark!");
        }
        else if (percent >= 87)
        {
            Console.WriteLine("You passed with a plus mark!");
        }
        else if (percent >= 77)
        {
            Console.WriteLine("You passed with a plus mark!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}