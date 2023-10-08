using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();
        Entry entry = new Entry();

        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Welcome to the journal program!");
        Console.WriteLine("--------------------------------------------------");

        do
        {
            Random randomPrompt = new Random();
            int number = randomPrompt.Next(0, 5);

            journal.DisplayJournal();

            if (journal._userNumber == 1)
            {
                Console.WriteLine("");
                string rnd = prompt._prompts[number];
                Console.WriteLine(rnd);

                Console.Write("> ");
                string userEntry = Console.ReadLine();

                entry._displayPrompts.Add(rnd);
                entry._entries.Add(userEntry);
            }
            else if (journal._userNumber == 2)
            {
                for (int i = 0; i < entry._entries.Count; i++)
                {
                    Console.WriteLine("");
                    Console.Write("- Prompt: ");
                    Console.WriteLine(entry._displayPrompts[i]);
                    Console.WriteLine(entry._entries[i]);
                }
            }
            else if (journal._userNumber == 3)
            {
                ReadFromFile();
            }
            else if (journal._userNumber == 4)
            {
                SaveToFile();
            }

        } while (journal._userNumber <= 4);

        Console.WriteLine("--------------------------------------------------");

        void SaveToFile()
        {
            Console.WriteLine("");
            Console.WriteLine("Saving to file...");

            Console.WriteLine("What is the filename?");
            Console.Write("> ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = File.AppendText(filename))
            {
                outputFile.WriteLine("");

                for (int i = 0; i < entry._entries.Count; i++)
                {
                    outputFile.Write("- Prompt: ");
                    outputFile.WriteLine(entry._displayPrompts[i]);
                    outputFile.WriteLine(entry._entries[i]);
                    outputFile.WriteLine("");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Your file was saved succesfully! ☺");
        }

        void ReadFromFile()
        {
            Console.WriteLine("");
            Console.WriteLine("Reading file...");

            Console.WriteLine("What is the filename?");
            Console.Write("> ");
            string filename = Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines(filename);

            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Filename: '{filename}'");
            Console.WriteLine("--------------------------------------------------");

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("--------------------------------------------------");

        }
        
    }
}