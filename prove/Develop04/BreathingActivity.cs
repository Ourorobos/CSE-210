using System;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string discription) : base(name, discription)
    {
        // ah yes?
    }

    //Overriding the ActivityLoop function
    public override void ActivityLoop(DateTime endtime)
    {
        bool flip = true;
        while (!this.IsTimeUp(endtime))
        {
            if (flip)
            {
                Console.WriteLine("Breath in...");
                flip = false;
            }
            else
            {
                Console.WriteLine("Breath out...");
                flip = true;
            }
            this.DispalyCountDown(5);
        }
    }
}