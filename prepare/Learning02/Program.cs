using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._title = "Emergency Manager";
        job1._company = "Clark Regional Emergency Service Agency";
        job1._startYear = "2017";
        job1._endYear = "2037";
        Job job2 = new Job();
        job2._title = "Traffic Engineer";
        job2._company = "Washington State Department of Transportation";
        job2._startYear = "2019";
        job2._endYear = "2024";
        Resume r1 = new Resume();
        r1._name = "Alex Star";
        r1._jobs.Add(job1);
        r1._jobs.Add(job2);
        r1.Display();

    }
}