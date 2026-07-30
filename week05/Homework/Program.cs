using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
         //  1: Assignment
            Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
            Console.WriteLine(assignment1.GetSummary());
            Console.WriteLine();

            //  2: Math Assignment
            MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
            Console.WriteLine(math1.GetSummary());
            Console.WriteLine(math1.GetHomeworkList());
            Console.WriteLine();

            // 3: Writing Assignment
            WritingAssignment writing1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
            Console.WriteLine(writing1.GetSummary());
            Console.WriteLine(writing1.GetWritingInformation());
        }
    }
}