class Cycling : Activity
{
    private double _speed; // Speed in miles per hour

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * Duration) / 60; // Distance in miles
    }

    public override double GetSpeed()
    {
        return _speed; // Speed in mph (already given)
    }

    public override double GetPace()
    {
        return 60 / _speed; // Pace in min per mile
    }
}