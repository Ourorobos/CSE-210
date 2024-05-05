using System;

class Entry
{
    string _dateTime;
    string _prompt;
    string _responce;
     public Entry(string dateTime, string prompt, string responce)
    {
        _dateTime = dateTime;
        _prompt = prompt;
        _responce = responce;
    }
    public void Display()
    {
        Console.WriteLine($"Entry Date/Time: {_dateTime}, Entry Prompt: {_prompt}");
        Console.WriteLine($"Entry Responce: {_responce}");
    }
    public string ReturnAsString()
    {
        return $"{_dateTime}|{_prompt}|{_responce}";
    }
}