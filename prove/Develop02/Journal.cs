using System;

class Journal
{
    List<Entry> _entries = new List<Entry>();
    List<string> _prompts = new List<string>();
    Random _random = new Random();

    public Journal()
    {
        // Starts the Journal with the default prompts
        _prompts.Add("What did you have for Lunch today?");
        _prompts.Add("What would you tell a family member or friend about your day?");
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("Did you learn somthing today?");
    }

    public void LoadFile(string filePath)
    {
        if(File.Exists(filePath))
        {
            //Yay! We have a working file. Time for some setup
             StreamReader fileReader = new StreamReader(File.OpenRead(filePath));
             int fileLineIndex = 0;
             int fileLineCounter = 0;

            //Make sure that we don't add new data to our old Journals
             _entries.Clear();
             _prompts.Clear();

            //Read file
             while(!fileReader.EndOfStream)
             {
                if (fileLineCounter == 0) //Find how many lines of prompts we have
                {
                    fileLineIndex = int.Parse(fileReader.ReadLine());
                    fileLineCounter++;
                }
                else if (fileLineCounter <= fileLineIndex) //Read all saved prompts
                {
                    _prompts.Add(fileReader.ReadLine());
                    fileLineCounter++;
                }
                else if (fileLineCounter > fileLineIndex) //Read all entries stored after the prompts
                {
                    var LineData = fileReader.ReadLine().Split("|");
                    _entries.Add(new Entry(LineData[0], LineData[1], LineData[2]));
                }
                else //How did you get to this!?
                {
                    Console.WriteLine("File Line Counter/Index Error!");
                    break;
                }
             }
        }
        else
        {
            Console.WriteLine("File Not Found!");
        }
    }

    public void SaveFile(string filePath)
    {
         using(StreamWriter fileWriter = new StreamWriter(File.OpenWrite(filePath)))
         {
            fileWriter.WriteLine(_prompts.Count()); //writes the file line index to file

            foreach(string prompt in _prompts) //writes prompts to file
            {
                fileWriter.WriteLine(prompt);
            }
            foreach(Entry entry in _entries) //write entries to file
            {
                fileWriter.WriteLine(entry.ReturnAsString());
            }
         }

         

         
    }

    public void AppendEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void AppendPrompt(string newPrompt)
    {
        _prompts.Add(newPrompt);
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("");
        }
    }

    public string ReturnRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count())];
    }
}