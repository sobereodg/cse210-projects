
class Swimming : Activity
{
    private int _laps; // Number of laps

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0 * 0.62; // Distance in miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Duration) * 60; // Speed in mph
    }

    public override double GetPace()
    {
        return Duration / GetDistance(); // Pace in min per mile
    }
}
