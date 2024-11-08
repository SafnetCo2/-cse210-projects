using System;
using System.Collections.Generic;
class Job
{
//private fields
private string _company;
private string _jobTitle;
private int _startYear;
private int _endYear;

    public string Company
    {
        get { return _company; }
        set{ _company = value; }
    }
    public string JobTitle
    {
        get{ return _jobTitle; }
        set { _jobTitle = value; }

    }
    public int StartYear
    {
        get{ return _startYear; }
        set { _startYear = value; }

    }
    public int EndYear
    {
        get{return _endYear;}
        set{ _endYear = value; }


    }
    //display job information
    public void Display()
    {
        Console.WriteLine($"{JobTitle}({Company}){StartYear}-{EndYear}");

    }


}
class Resume
{
    private string _name;
    private List<Job> _jobs = new List<Job>();
    public string Name{
        get{return _name; }
        set { _name = value; }
    }
    public List <Job> Jobs
    { get { return _jobs; }
    }


    //display resume
    public void Display()
    {
        Console.WriteLine ($"Name: {Name}");
        Console.WriteLine("Jobs: ");
            foreach (Job job in _jobs)
            {
                job.Display();
            }
        }
    }
class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job
        {
            JobTitle = "Software Engineer",
            Company = "Google",
            StartYear = 2020,
            EndYear = 2022

        };
        Job job2 = new Job
        {
            JobTitle = "System Analyst",
            Company = "Microsoft",
            StartYear = 2023,
            EndYear = 2024
        };
        //create Resume and add jobs
        Resume myResume = new Resume { Name = "Josephine Mueni" };
        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);
        myResume.Display();
    }
}



