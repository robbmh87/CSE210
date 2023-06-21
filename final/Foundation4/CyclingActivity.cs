

class CyclingActivity : Activity
{
    private int speed;

    public CyclingActivity(DateTime date, int length, int speed) : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return speed / 60.0 * Length;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60.0 / speed * GetDistance();
    }
}