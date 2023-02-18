using System;

namespace JournalApp
{
    class Program
    {
        static Journal journal = new Journal();

        static void Main(string[] args)
        {
            bool quit = false;

            while (!quit)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Quit");

                string input = Console.ReadLine();
                Console.WriteLine("");

                switch (input)
                {
                    case "1":
                        GeneratePrompt();
                        break;
                    case "2":
                        DisplayJournal();
                        break;
                    case "3":
                        SaveJournal();
                        break;
                    case "4":
                        LoadJournal();
                        break;
                    case "5":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select again.");
                        break;
                }
            }
        }

        static void GeneratePrompt()
        {
            string[] prompts = new string[]
            {
                "What is something thats working well in your life right now?",
                "What kind of day are you having, and why?",
                "How can you make tomorrow (even) better than today?",
                "What was the strongest emotion I felt today?",
                "What is one thing you want to remember from today?"
            };

            Random random = new Random();
            int index = random.Next(prompts.Length);
            string prompt = prompts[index];

            Console.WriteLine(prompt);
            Console.WriteLine("Enter your response:");

            string response = Console.ReadLine();

            Console.WriteLine("Entry saved.");

            Console.WriteLine("");

            journal.AddEntry(new Entry(prompt, response));
        }

        static void DisplayJournal()
        {
            Console.WriteLine("Journal entries:");
            Console.WriteLine("");
            journal.DisplayEntries();
        }

        static void SaveJournal()
        {
            journal.SaveToFile();
        }

        static void LoadJournal()
        {
            journal.LoadFromFile();
        }
    }
}
