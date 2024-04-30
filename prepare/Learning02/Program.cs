using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Micosoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Job job3 = new Job();
        job3._jobTitle = "AI Engineer";
        job3._company = "N10 Dynamics";
        job3._startYear = 2023;
        job3._endYear = 2033;

        Job job4 = new Job();
        job4._jobTitle = "Producer";
        job4._company = "Point Less Productions";
        job4._startYear = 2040;
        job4._endYear = 2145;

        Resume myResume = new Resume();
        myResume._name = "Allison 'Ally' Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        myResume._jobs.Add(job4);
        myResume.Display();
    }
}