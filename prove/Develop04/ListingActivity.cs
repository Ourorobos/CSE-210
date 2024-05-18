using System;

class ListingActivity : Activity
{
    private string[] _prompts = {"Who are people that you appreciate?", "What are personal strengths of yours?",
    "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    public ListingActivity(string name, string discription) : base(name, discription)
    {
        // so... we meet at last.
    }

    public override void ActivityLoop(DateTime endTime)
    {
        int total = 0;
        this.DisplayRandomString(_prompts);
        this.DispalyCountDown(9);
        do
        {
            Console.Write("-> ");
            Console.ReadLine();
            total++;
        }
        while(!this.IsTimeUp(endTime));
        Console.WriteLine($"You listed {total} item(s).");
    }
}