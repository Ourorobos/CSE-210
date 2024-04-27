using System;

class Program
{
    static void Main(string[] args)
    {
        string input;
		string running = "yes";
		Random generator = new Random();
		
		while (running == "yes")
		{
			int ranNum = generator.Next(1, 11);
			//int ranNum = 5;
			int guessNum = 0;
			int countNum = 0;
			
			//Console.WriteLine($"ranNum is {ranNum}");
			
			while (guessNum != ranNum)
			{
				countNum++;
				Console.Write("What is your new guess?: ");
				input = Console.ReadLine();
				guessNum = int.Parse(input);
				
				if (guessNum > ranNum) { Console.WriteLine("Try lowwer"); }
				else if (guessNum < ranNum) { Console.WriteLine("Try higher"); }
			}
			
			Console.WriteLine("Correct!");
			Console.WriteLine($"You gussed it in {countNum} tries");
			
			Console.WriteLine("Do you want to play once more?: yes/no");
			input = Console.ReadLine();
			if (!(input == "yes" || input == "Yes")) { running = "no"; Console.WriteLine("Goodbye!"); }
		}
    }
}