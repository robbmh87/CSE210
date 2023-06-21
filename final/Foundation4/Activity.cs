
abstract class Activity
{
    private DateTime date;
    private int length;

    public Activity(DateTime date, int length)
    {
        this.date = date;
        this.length = length;
    }

    public DateTime Date
    {
        get { return date; }
    }

    public int Length
    {
        get { return length; }
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} {GetType().Name} ({length} min) - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min/km";
    }
}
