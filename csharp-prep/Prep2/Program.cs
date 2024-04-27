using System;

class Program
{
    static void Main(string[] args)
    {
        // set up
        string letter;
        bool pass;
        
        Console.WriteLine("Please enter your grade precentage: ");
        string input = Console.ReadLine();
        int percent = int.Parse(input);
        
        if (percent > 89) { letter = "A"; pass = true; }
        else if (percent > 79) { letter = "B"; pass = true; }
        else if (percent > 69) { letter = "C"; pass = true; }
        else if (percent > 59) { letter = "D"; pass = false; }
        else { letter = "F"; pass = false; }
        
        Console.WriteLine(letter);
       
       if (pass) { Console.Write("You passed!"); }
       else { Console.Write("You didn't pass. Better luck next time."); }
    }
}