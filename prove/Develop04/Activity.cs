using System;

class Activity
{
    private Random _random = new Random();
    private string _name;
    private string _discription;
    private int _duration;

    public Activity(string name, string discription)
    {
        _name = name;
        _discription = discription;
    }

    //Main fucntions
    public void Run()
    {
        Console.Clear();
        this.DisplayMessageStarting();
        this.InputDuration();
        Console.WriteLine("Get Ready!");
        this.DisplayAnimation(4);
        this.ActivityLoop(DateTime.Now.AddSeconds(_duration));
        this.DisplayMessageEnding();
    }
    public virtual void ActivityLoop(DateTime endTime)
    {
        Console.WriteLine("You need to override this function");
    }

    // Misc Functions
    public void InputDuration()
    {
        Console.Write("Please enter a time duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }
    public bool IsTimeUp(DateTime endTime)
    {
        if (DateTime.Now < endTime)
        {
            return false;//still have time
        }
        else
        {
            return true;//time is up
        }
    }

    //Display funtions
    public void DisplayMessageStarting()
    {
        Console.WriteLine($"""
        This is the {_name} activity.

        In this activity you will {_discription}.
        """);
    }
    public void DisplayMessageEnding()
    {
        Console.WriteLine("Good job!");
        this.DisplayAnimation(7 + _random.Next(3));
        Console.WriteLine($"you have completed the {_name} in {_duration} seconds.");
        this.DisplayAnimation(10 + _random.Next(5));
    }
    public void DisplayRandomString(string[] array)
    {
        Console.WriteLine(array[_random.Next(array.Count())]);
    }
    public void DisplayAnimation(int time)
    {
        int step = 150;
        string thing = @"\-/|"; // had to add the @ to keep the \ from finding an excape char

        DateTime endTime = DateTime.Now.AddSeconds(time);
        foreach (char symbol in thing)
        {
            Console.Write($"{symbol}\b");
            Thread.Sleep(step);
            if (this.IsTimeUp(endTime))
            {
                break;
            }
        }
    }
    public void DispalyCountDown(int time)
    {
        while (0 < time)
        {
            Console.Write(time);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            time--;
        }
        Console.WriteLine("0");
    }
}