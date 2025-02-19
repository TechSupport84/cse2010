 class Swimming :Activity
{
    private int _laps;
    private double _lapDistance = 50/1000.0;

    public Swimming(string date, int minutes ,int laps): base(date, minutes)
    {
      _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * _lapDistance;
    }
    public override double GetSpeed()
    {
        return GetDistance() /GetMinutes() *60;
    }
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}

