//To exceed the requierments I add a list of scriptures
//and add a command to the terminal interface to rotate through the avaible scriptures
//if you finish the list it restarts the list over again

using System;

class Program
{
    private static int _arrayIndex = 0;
    private static List<Scripture> _scriptures = new List<Scripture>();
    static void Main(string[] args)
    {
        BuildList();
        bool running = true;
        string command;
        Scripture scripture = _scriptures[0];
        Random random = new Random();
        while (running)
        {
            command = GetUserInput(scripture.GetStringWords());
            if ("Quit" == command || "quit" == command) // Quit program
            {
                Console.WriteLine("Goodbye!");
                running = false;
            }
            else if ("Next" == command || "next" == command) // Go  to the next one in the list
            {
                scripture = NextScripture();
            }
            else if ("" == command) // Continue
            {
                if (scripture.IsFullyHidden())
                {
                    scripture = NextScripture();
                }
                else
                {
                    for (int i = 0; i <= random.Next(4) && !scripture.IsFullyHidden(); i++) // hide 1 to 3 words if possible
                    {
                        scripture.HideRandomWord();
                    }
                }
            }
        }
    }
    private static string GetUserInput(string promptText)
    {
        Console.Clear();
        Console.WriteLine(promptText);
        Console.WriteLine("");
        Console.Write("Press 'Enter' to continue, type 'Quit' to Exit or 'Next' for a new scripture: ");

        return Console.ReadLine();
    }
    private static Scripture NextScripture()
    {
        if (1 + _arrayIndex == _scriptures.Count()) // if at the end of the list restart the index
        {
            _arrayIndex = 0;
        }
        else
        {
            _arrayIndex++;
        }
        _scriptures[_arrayIndex].ResetWords(); // so we dont start in the midde or with one that is finished
        return _scriptures[_arrayIndex];
    }
    private static void BuildList()
    {
        Reference[] refArry = {new Reference("1 Nephi", 1, 1), new Reference("Moroni", 10, 3, 5),new Reference("Ether", 12, 27)};
        string[] textArry = {"I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.",
        "3 Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts. 4 And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. 5 And by the power of the Holy Ghost ye may know the truth of all things.",
        "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."};

        _scriptures.Add(new Scripture(refArry[0], textArry[0]));
        _scriptures.Add(new Scripture(refArry[1], textArry[1]));
        _scriptures.Add(new Scripture(refArry[2], textArry[2]));
    }
}