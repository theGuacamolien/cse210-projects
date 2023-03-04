using System;

namespace ScriptureDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the reference for the scripture you would like to memorize e.g. (1 Nephi 3:7):");
            string reference = Console.ReadLine();
            Console.WriteLine("Please enter the text of the scripture:");
            string text = Console.ReadLine();

            // Create a new scripture object with the user-provided reference and text
            Scripture scripture = new Scripture(reference, text);

            // Prompt the user to press enter or type quit
            Console.WriteLine("\nPress enter to hide a single word from the passage or type 'quit' to exit.");
            var input = Console.ReadLine();

            while (input != "quit")
            {
                // Hide a few random words and display the updated scripture
                scripture.HideWords(1);
                Console.Clear();
                Console.WriteLine(scripture.GetRenderedText());

                // Check if all words are hidden and prompt the user to quit or continue
                if (scripture.IsFullyHidden())
                {
                    Console.WriteLine("\nAll words are hidden. Press enter to exit.");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("\nPress enter to hide more words or type 'quit' to exit.");
                    input = Console.ReadLine();
                }
            }
        }
    }
}
