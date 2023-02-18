using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    class Journal
    {
        private List<Entry> entries = new List<Entry>();

        public void AddEntry(Entry entry)
        {
            entries.Add(entry);
        }

        public void DisplayEntries()
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine("Date: " + entry.GetDate());
                Console.WriteLine("Prompt: " + entry.GetPrompt());
                Console.WriteLine("Response: " + entry.GetResponse());
                Console.WriteLine("");
            }
        }

        public void SaveToFile()
        {
            Console.WriteLine("Enter filename:");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine(entry.GetDate() + "|" + entry.GetPrompt() + "|" + entry.GetResponse());
                }
            }

            Console.WriteLine("Journal saved to " + filename);
            Console.WriteLine("");
        }

        public void LoadFromFile()
        {
          Console.Write("Enter the file name: ");
          string fileName = Console.ReadLine();

          if (File.Exists(fileName))
          {
            string[] lines = File.ReadAllLines(fileName);

            entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string prompt = parts[0];
                string response = parts[1];
                DateTime date = DateTime.Parse(parts[2]);

                entries.Add(new Entry(prompt, response, date));
            }

            Console.WriteLine("Journal loaded successfully from file.");
          }
          else
          {
            Console.WriteLine("File not found.");
          }
        }
    }
}
