using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string number = Console.ReadLine();
        int per = int.Parse(number);


        int remander = per % 10;

        string plus = " ";

        if (remander >= 7)
        {
            plus = "+";
        }
        else if (remander <= 3)
        {
            plus = "-";

        }
        else
        {
            plus = " ";
        }

        string grade = "";

        if (per >= 90)
        {
            grade = "A";
        }
        else if (per >= 80)
        {
            grade = "B";
        }
        else if (per >= 70)
        {
            grade = "C";
        }
        else if (per >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is: {grade}{plus}");

        if (per >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}