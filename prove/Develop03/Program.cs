using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber;
        int intGuess;

        Random randomGenerator = new Random();




        string Number = Console.ReadLine();
        magicNumber = randomGenerator.Next(1, 5);

        do
        {


            Console.Write("What is your guess? ");
            string Guess = Console.ReadLine();
            intGuess = int.Parse(Guess);

            if (intGuess < magicNumber)
            {
                Console.Write("Higher\n");

            }
            else if (intGuess > magicNumber)
            {

                Console.Write("Lower\n");
            }
            else
            {
                Console.Write("You guessed it!");
            }
        }
        while (intGuess != magicNumber);
    }
}
