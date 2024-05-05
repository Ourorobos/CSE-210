// To exceed the requirments
// You can now add your own prompts to the program
// All prompts are saved to the journal file
using System;

class Program
{
    static void Main(string[] args)
    {
        //set up
        Journal journal = new Journal();
        bool running = true;
        string command;
        string prompt;
        //string folderPath = @"D:\School Stuff\CSE-210\prove\Develop02\";
        string folderPath = Directory.GetCurrentDirectory();
        Console.WriteLine("Wellcome To Journal.cs!");

        //start of the Terminal UI
        while(running)
        {
            command = PromptUser("Please Enter A Command Or Type 'Help': ");

            if("Save" == command || "save" == command)
            {
                command = PromptUser("Please Enter The Name Of A Text File: ");
                journal.SaveFile($"{folderPath}{command}.txt");
            }
            else if ("Load" == command || "load" == command)
            {
                command = PromptUser("Please Enter The Name Of A Text File: ");
                journal.LoadFile($"{folderPath}{command}.txt");
            }
            else if ("View" == command || "view" == command)
            {
                journal.DisplayAll();
            }
            else if ("Prompt" == command || "prompt" == command)
            {
                command = PromptUser("Please Enter A New Prompt: ");
                journal.AppendPrompt(command);
            }
            else if ("Entry" == command || "entry" == command)
            {
                prompt = journal.ReturnRandomPrompt();
                Console.WriteLine("Your prompt for this Entry is:");
                Console.WriteLine(prompt);
                command = PromptUser("Please Enter A New Entry: ");
                Entry newEntry = new Entry(DateTime.Now.ToString(), prompt, command);
                journal.AppendEntry(newEntry);
            }
            else if ("New" == command || "new" == command)
            {
                journal = new Journal();
            }
            else if ("Quit" == command || "quit" == command)
            {
                Console.WriteLine("Goodbye!");
                running = false;
            }
            else if ("Help" == command || "help" == command)
            {
                Console.WriteLine("Here is a list of commands!");
                Console.WriteLine("Save <- To save your Journal");
                Console.WriteLine("Load <- To load an old Journal");
                Console.WriteLine("Veiw <- Will display all your Journal entries");
                Console.WriteLine("Prompt <- To add a new prompt to your Journal");
                Console.WriteLine("Entry <- To add a entry to your Journal");
                Console.WriteLine("New <- Starts a new Journal");
                Console.WriteLine("Quit <- To Leave you Journal");
            }
            else
            {
                Console.WriteLine("Invalad Command");
            }
        }
    }
    static string PromptUser(string promptText)
    {
        //This is really becuse I got sick of typing Console.WriteLine
        //This is a C# version of the Python input() function
        Console.WriteLine("");
        Console.Write(promptText);
        return Console.ReadLine();
    }
}