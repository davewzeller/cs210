using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select what you would like to do\n");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load all journals");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        int number = Convert.ToInt16(Console.ReadLine());
       

        if (number > 4)
        {
            Console.WriteLine("Parting is sweet sorrow\n");
            Environment.Exit(0);
        }
        else if (number > 3)
        {
            Console.WriteLine("Saving");

        }
        else if (number > 2)
        {
            Console.WriteLine("Loading Journals");

        }
        else if (number > 1)
        {
            Console.WriteLine("Displaying Journals");

        }
        else if (number > 0)
        {
            MyWriting();
            SaveScript();


        }
    }

   static int magicNumeric()
   {
        int magicNumber;
        Random randomGenerator = new Random();
        magicNumber = randomGenerator.Next(0, 6);
        return (magicNumber);
    } 
    // writing promp
    static string MyWriting()
    {

        int magicNumber = magicNumeric();

        if (magicNumber > 4)
        {
            Console.WriteLine("What was the best part of your day?");
            return ("What was the best part of your day?");
        }
        else if (magicNumber > 3)
        {
            Console.WriteLine("Tell me about your workout.");
            return ("What was the best part of your day?");
        }
        else if (magicNumber > 2)
        {
            Console.WriteLine("When were you kind to someone?");
            return ("What was the best part of your day?");
        }
        else if (magicNumber > 1)
        {
            Console.WriteLine("Please tell me what you want todo tomorrow.");
            return ("What was the best part of your day?");
        }
        else if (magicNumber > 0)
        {
            Console.WriteLine("What did you do for fun today?");
            return ("What was the best part of your day?");

        }
        else{
            return ("bla");
        }
    }
    static void SaveScript()
    {
        Console.WriteLine("working ");

    }
}