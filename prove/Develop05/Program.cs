//To exceed reqirements i added player levels
// each level needs a 100 more point then the last to level up

using System;

class Program
{
    static GoalManager _manager = new GoalManager();
    static string _filePath = @"D:\School Stuff\CSE-210\prove\Develop05\";
    static void Main(string[] args)
    {
        string command;
        bool running = true;

        while (running)
        {
            Console.WriteLine("""
            0.Show Player Stats
            1.Add Goal
            2.List Goal
            3.Goal Event
            4.Load Goal File
            5.Save Goal File
            6.Exit
            7.New Manager
            """);

            Console.Write("Command: ");
            command = Console.ReadLine().ToLower().Trim();

            switch (command)
            {
                case "0":
                    _manager.DisplayPlayerStats();
                    break;

                case "1":
                    _manager.AddGoal();
                    break;

                case "2":
                    _manager.DisplayGoals();
                    break;

                case "3":
                    _manager.GoalEvent();
                    break;

                case "4":
                    Console.Write("Enter File Name: ");
                    command = Console.ReadLine();
                    _manager.LoadFile($"{_filePath}{command}.txt");
                    break;

                case "5":
                    Console.Write("Enter File Name: ");
                    command = Console.ReadLine();
                    _manager.SaveFile($"{_filePath}{command}.txt");
                    break;
                
                case "6":
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;
                
                case "7":
                    _manager = new GoalManager();
                    break;
                
                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }

            Console.Write("Press Enter To Continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}