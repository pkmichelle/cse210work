using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Statistics Teaching Assistant";
        job1._company = "BYU-I";
        job1._startYear = 2021;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Math Tutor";
        job2._company = "Outlier";
        job2._startYear = 2022;
        job2._endYear = 2024;
        
        job1.DisplayJobInfo();
        job2.DisplayJobInfo();


        Resume myResume = new Resume();
        myResume._name = "Paige Koster";

        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);

        myResume.DisplayResume();
    }
}