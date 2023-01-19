using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._startYear = 2022;
        job1._jobTitle = "Manager";
        job1._companyName = "Google";

        Job job2 = new Job();
        job2._startYear = 2021;
        job2._jobTitle = "Software Engineer";
        job2._companyName = "Google";

        Resume myResume = new Resume();
        myResume._name = "Billy Bob";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.Display();
    }
}