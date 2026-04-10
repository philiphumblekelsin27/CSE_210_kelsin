using System;
// CREATIVITY REPORT:
// I exceeded requirements by implementing a Leveling System. 
// The user's level is calculated based on their score (1 level per 1000 points).
// The level and a custom rank title are displayed every time the score is shown,
// adding a gamified progression feel to the "Quest".

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}