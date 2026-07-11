using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journual = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");


        // https://stackoverflow.com/questions/74472175/how-to-run-bool-function-if-if-statement-is-true
        bool running = true;
        
        
        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            string choice = Console.ReadLine();

            if (choice == "1")

            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                //https://stackoverflow.com/questions/7747960/c-sharp-formatting-current-time
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                journual.AddEntry(newEntry);

            }

            else if (choice == "2")
            {
                journual.DisplayAll();

            }

            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                journual.SaveToFile(file);

            }

            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                journual.LoadFromFile(file);

            }
            else if (choice == "5")
            {
                running = false;

            }
        }
    }
}
