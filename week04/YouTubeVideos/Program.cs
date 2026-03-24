using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videos = new List<Video>();


        Video v1 = new Video("C# Tutorial", "CodeMaster", 600);
        v1._comments.Add(new Comment("User1", "Great video!"));
        v1._comments.Add(new Comment("User2", "Very helpful, thanks."));
        v1._comments.Add(new Comment("User3", "Can you do Java next?"));
        videos.Add(v1);


        Video v2 = new Video("Cooking Pasta", "Chef Luigi", 300);
        v2._comments.Add(new Comment("Foodie", "Looks delicious."));
        v2._comments.Add(new Comment("KitchenNoob", "I burned my water. Help."));
        v2._comments.Add(new Comment("Italiano", "Authentic recipe!"));
        videos.Add(v2);


        Video v3 = new Video("Cat Fails 2024", "FunnyPets", 120);
        v3._comments.Add(new Comment("CatLover", "LOL!"));
        v3._comments.Add(new Comment("DogPerson", "Dogs are better."));
        v3._comments.Add(new Comment("MemeLord", "Classic."));
        videos.Add(v3);

        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v._title}");
            Console.WriteLine($"Author: {v._author}");
            Console.WriteLine($"Length: {v._length} seconds");
            Console.WriteLine($"Number of Comments: {v.GetCommentCount()}");
            foreach (Comment c in v._comments)
            {
                Console.WriteLine($"- {c._name}: {c._text}");
            }
            Console.WriteLine();
        }
    }
}