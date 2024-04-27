using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> array = new List<int>();
		string input;
		int number;
		int max = 0;
		int total = 0;
		
		do
		{
			Console.WriteLine("Enter your number: ");
			input = Console.ReadLine();
			number = int.Parse(input);
			array.Add(number);
			total += number;
			if (max < number) { max = number; }
		} while (number != 0);
		
		Console.WriteLine($"The sum is: {total}");
		Console.WriteLine($"The average is : {total/array.Count}");
		Console.WriteLine($"The largest number is: {max}");
    }
}