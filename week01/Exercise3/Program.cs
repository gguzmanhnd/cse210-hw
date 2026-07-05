using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1, 11);
            
        int guess = -1;

        while (guess != magicnumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());


            if (magicnumber == guess)
            {
                Console.Write("You guessed it!");
            }
            else if (guess < magicnumber)
            {
                Console.Write("Higher ");
            }
            else {Console.Write("Lower ");
            
            }
        }
    }
}