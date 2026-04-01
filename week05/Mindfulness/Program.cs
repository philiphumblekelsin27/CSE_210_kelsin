using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        BreathingActivity breathing = new BreathingActivity();
        breathing.DisplayStartingMessage();
    }
}