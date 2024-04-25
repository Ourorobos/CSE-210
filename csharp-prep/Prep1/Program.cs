using System;

class Program
{
    static void Main(string[] args)
    {
        string fname = "First";
		string lname = "Last";
		Console.WriteLine("What is your first name?");
		fname = Console.ReadLine();
		Console.WriteLine("What is your last name?");
		lname = Console.ReadLine();
		Console.WriteLine($"Your name is {lname}, {fname} {lname}");
    }
}