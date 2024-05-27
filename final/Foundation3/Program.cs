using System;

class Program
{
    static void Main(string[] args)
    {
        Address add1 = new Address("200 Park Ave", "New York", "New York", "USA");
        Address add2 = new Address("2007 HalfLife Way", "No#17", "Californa", "USA");
        Address add3 = new Address ("2463 FL-16", "Green Cove", "Appalachia", "USA");

        Lecture lecture = new Lecture("Lecture", "Astro Thermal Dynamics", "If you have to ask that go reread the name and maybe don't come", "12th of May, 2040 @ 12AM", add1, "T Stark", 500);
        Reception reception = new Reception("Reception", "A&A", "Alex's and Alyx's Reception", "31st of Febuary 1932 @ 10AM", add2);
        Gathering gathering = new Gathering("Gathering", "Hill Billy Hearding", "Hearding Hill Billys", "4th of July @ Noon", add3);

        lecture.DetailsShort();
        Console.WriteLine("");
        lecture.DetailsMedium();
        Console.WriteLine("");
        lecture.DetailsLong();
        Console.WriteLine("");
        
        reception.DetailsShort();
        Console.WriteLine("");
        reception.DetailsMedium();
        Console.WriteLine("");
        reception.DetailsLong();
        Console.WriteLine("");
        
        gathering.DetailsShort();
        Console.WriteLine("");
        gathering.DetailsMedium();
        Console.WriteLine("");
        gathering.DetailsLong();
        Console.WriteLine("");

    }
}