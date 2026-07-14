using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;


        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":

                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine(prompt);
                    Console.Write("> ");

                    string response = Console.ReadLine();


                    Entry entry = new Entry();

                    entry._date = DateTime.Now.ToString("MM/dd/yyyy");
                    entry._promptText = prompt;
                    entry._entryText = response;


                    journal.AddEntry(entry);

                    Console.WriteLine("Entry added!");

                    break;


                case "2":

                    journal.DisplayAll();

                    break;


                case "3":

                    Console.Write("Enter filename: ");

                    string saveFile = Console.ReadLine();

                    journal.SaveToFile(saveFile);

                    break;


                case "4":

                    Console.Write("Enter filename: ");

                    string loadFile = Console.ReadLine();

                    journal.LoadFromFile(loadFile);

                    break;


                case "5":

                    running = false;

                    Console.WriteLine("Goodbye!");

                    break;


                default:

                    Console.WriteLine("Invalid option.");

                    break;
            }
        }
    }
}