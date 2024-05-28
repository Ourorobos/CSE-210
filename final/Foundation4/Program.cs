using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> list = new List<Activity>();

        list.Add(new Running("4th of July 2034 @ 10pm", 120, 2.5));
        list.Add(new Cycling("25th of December 2068 @ 3am", 60, 10));
        list.Add(new Swimming("16th of December 1773 @ 6pm", 60, 50));

        foreach (Activity activity in list)
        {
            activity.Display();
        }
    }
}