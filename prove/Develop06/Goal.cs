using System;
public abstract class Goal
{
    //private member variables
    private string =_name;
    private string=_description;
    private int=_points;
    private int=_progress;

    //intialize name and description
    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
        _points = 0;
        _progress = 0;

    }
    //public properties to get information
    public string Name = _name;
    public string Description = _description;
    public string Points = _points;
    public string Progress = _progress;
    //abstract method to be implemented by derived class
    public abstract void RecordEvent();
    public abstract void DisplayProgress();
    public abstract void MarkComplete();
    //method to accumulate points
    protected void AddPoints(int points)
    {
        _points += points;
    }
}