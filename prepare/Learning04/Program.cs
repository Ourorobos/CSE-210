using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("Matt","Functions","9.75","42-111");
        WritingAssignment writing = new WritingAssignment("Phill","New Californa Repulic","The Battle of Hoover Dam");

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine("");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}