using System;
using System.Collections.Generic;


// CREATIVITY REPORT:
// 1. I added a 'Scripture Library'. Instead of one scripture, the program 
// contains a list of multiple scriptures and selects one at random 
// each time the program starts.
// 2. I improved the 'HideRandomWords' logic so it only selects from words 
// that are NOT already hidden (Stretch Challenge).


class Program
{
    static void Main(string[] args)
    {
        List<Scripture> library = new List<Scripture>();

        library.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son"));
        library.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding"));
        library.Add(new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me"));
        Random random = new Random();
        Scripture selectedScripture = library[random.Next(library.Count)];

        string input = "";

        // 3. Main Loop
        while (input.ToLower() != "quit" && !selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("\nPress enter to hide words or type 'quit' to finish:");

            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                selectedScripture.HideRandomWords(3);
            }
        }
        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Good luck memorizing!");
    }
}