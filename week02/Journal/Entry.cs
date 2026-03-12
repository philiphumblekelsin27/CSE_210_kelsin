using System;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";
    public string _mood = ""; // creativity added; tracks user's mood
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - prompt: {_promptText}");
        Console.WriteLine($"{_entryText}\n");
        Console.WriteLine($"Mood: {_mood}");
    }
}