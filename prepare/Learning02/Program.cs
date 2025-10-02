using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Apple";
        job1._startYear = 2013;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "Hardware Tester";
        job2._company = "IBM";
        job2._startYear = 2018;
        job2._endYear = 2020;

        // job1.Display();
        // job2.Display();

        Resume myResume = new Resume();

        myResume._name = "James Shmart";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


    }
}