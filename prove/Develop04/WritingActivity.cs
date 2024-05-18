using System;

class WritingActivity : Activity
{
    public WritingActivity(string name, string discription) : base(name, discription)
    {
        // very well
    }

    //Override the Activity function
    public override void ActivityLoop(DateTime endTime)
    {
        do
        {
            Console.Write("->");
            Console.ReadLine();
            Console.Write("what do you think about this thought: ");
            Console.ReadLine();
        }
        while (!this.IsTimeUp(endTime));
    }
}