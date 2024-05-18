using System;

class ReflectionActivity : Activity
{
    private string[] _promptsType1 = {"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private string[] _promptType2 = {"Why was this experience meaningful to you?","Have you ever done anything like this before?",
    "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};

    public ReflectionActivity(string name, string discription) : base(name, discription)
    {
        // mmm.... yes...
    }

    // Overriding the ActivityLoop function
    public override void ActivityLoop(DateTime endtime)
    {
        bool type = true;
        do
        {
            if (type)
            {
                this.DisplayRandomString(_promptsType1);
                type = false;
            }
            else
            {
                this.DisplayRandomString(_promptType2);
                type = true;
            }
            this.DisplayAnimation(30);
        }
        while (!this.IsTimeUp(endtime));
    }
}