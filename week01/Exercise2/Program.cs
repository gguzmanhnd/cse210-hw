using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("Write a program that determines the letter grade for a course.");
        Console.WriteLine("");
        Console.Write("What is your grade percentage?");
        string userinput = Console.ReadLine(); 
        int grade = int.Parse(userinput);
        string letter = "";
        // Console.WriteLine($"Your grade is: {grade}."); I use this line for testing :)!
        if (grade >= 97)
       // {Console.WriteLine("Your score is an: A"); I use this line for testing :)!
            {
            letter = "A";
                }
        else if (grade >= 80 && grade <97 )
        //{Console.WriteLine("Your score is an: B"); I use this line for testing :)!
        { letter = "B";
        }     
        else if (grade >= 70 && grade < 80)
        //{Console.WriteLine("Your score is an C"); I use this line for testing :)!
        { letter = "C";
                }        
        else if (grade >= 60 && grade < 70)
        //{Console.WriteLine("Your score is an D"); I use this line for testing :)!
        {   letter = "D";
                }        
        else if (grade < 60)
        //{Console.WriteLine("Your score is an F"); I use this line for testing :)!
        {   letter = "F";
                }   
        Console.WriteLine($"Your letter grade is: {letter}");                     
        if (grade <70)
        {Console.WriteLine("You must have at least a 70 to pass the class, so this time you did not make, but we encourage you to come back");}
        else  {Console.WriteLine("Congratulations you have pass the class");}
    }
}