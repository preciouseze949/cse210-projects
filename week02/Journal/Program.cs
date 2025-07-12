using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        Console.WriteLine("Welcome to the Journal Program!");

        while (running)
        {
            Console.WriteLine("\nPlease select one of the following options:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. View all journal entries");
            Console.WriteLine("3. Load journal from file and display");
            Console.WriteLine("4. Save journal to file");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice (1-5): ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid input, please enter a number between 1 and 5.");
            }

            switch (choice)
            {
                case 1:
                    string prompt = promptGenerator.GeneratePrompt();
                    Console.WriteLine(prompt);
                    string entryContent = Console.ReadLine();
                    journal.AddEntry(entryContent); // Write a new journal entry
                    break;

                case 2:
                    journal.ViewEntries(); // Display all journal entries
                    break;

                case 3:
                    Console.Write("Enter the filename to load (e.g., journal.txt): ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadJournal(loadFileName);
                    journal.ViewEntries(); // Automatically display after loading
                    break;

                case 4:
                    Console.Write("Enter the filename to save the journal (e.g., journal.txt): ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveJournal(saveFileName);
                    break;

                case 5:
                    running = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
            }
        }
    }
}
