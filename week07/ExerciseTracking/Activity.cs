using System;
using System.Collections.Generic;

abstract class Activity
{
    private DateTime _date;
    private int _duration; // in minutes

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public DateTime Date => _date;
    public int Duration => _duration;

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // GetSummary method to create the summary string
    public string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({Duration} min): Distance {GetDistance():F1}, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}