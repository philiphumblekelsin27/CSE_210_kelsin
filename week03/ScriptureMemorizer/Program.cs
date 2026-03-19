using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world...");
        Console.WriteLine("Scripture Memorizer Stubs Ready.");
        Console.WriteLine("Reference Display: " + reference.GetDisplayText());

    }
}