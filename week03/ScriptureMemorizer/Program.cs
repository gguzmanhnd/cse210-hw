using System;
using System.Collections.Generic;

using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // 1. Initialize a small library of scriptures to exceed requirements
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
            new Scripture(new Reference("Joshua", 1, 9), "Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest.")
        };

        // 2. Pick a random scripture from the library
        Random random = new Random();
        Scripture selectedScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        // 3. UI Loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();

            // If everything is hidden, break out immediately after displaying the final blank state
            if (selectedScripture.IsCompletelyHidden())
            {
                Console.WriteLine("Great job! You've completely memorized the scripture.");
                break;
            }

            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            // Hide 3 words on each press (you can adjust this number)
            selectedScripture.HideRandomWords(3);
        }

        Console.WriteLine("\nGoodbye!");
    }
}