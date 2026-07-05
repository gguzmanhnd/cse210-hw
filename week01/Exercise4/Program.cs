using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        
        int input = -1;
        while (input != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string valueUser = Console.ReadLine();
            input = int.Parse(valueUser);
            
          
            if (input != 0)
            {
                numbers.Add(input);
            }
        }

       
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}