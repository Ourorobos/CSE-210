//To exceed the requirements I added a 4th activity

using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breath = new BreathingActivity("Breathing","you relax by breathing in and out slowly. focus on your breathing");
        ReflectionActivity reflect = new ReflectionActivity("Reflection","you will reflect on difrent times in your life");
        ListingActivity list = new ListingActivity("Listing","you will make a list of things about a time in your life");
        WritingActivity write = new WritingActivity("Writing","you will record any thoughts that come to mind and how you feel about them");
        string command;

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"""
            0.Exit
            1.Breathing Activity
            2.Reflection Activity
            3.Listing Activity
            4.Writing Activity
            """);
            Console.Write("Please enter a command: ");
            command = Console.ReadLine();

            if ("0" == command)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else if ("1" == command)
            {
                breath.Run();
            }
            else if ("2" == command)
            {
                reflect.Run();
            }
            else if ("3" == command)
            {
                list.Run();
            }
            else if ("4" == command)
            {
                write.Run();
            }
            else
            {
                Console.Write("Enter 1, 2, 3, or 4: ");
                command = Console.ReadLine();
            }
        }
    }
}