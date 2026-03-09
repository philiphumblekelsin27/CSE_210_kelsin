using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "ABC Corp";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Senior Developer";
        job2._company = "XYZ Inc";
        job2._startYear = 2023;
        job2._endYear = 0; // Still working here

        // 3. Create the Resume instance
        Resume myResume = new Resume();
        myResume._name = "Philip Humble";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}