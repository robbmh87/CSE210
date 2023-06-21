public class GoalsManager
{
    private List<Goal> goals;
    private int score;

    public GoalsManager()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        Goal goal = goals.Find(g => g.Name == goalName);
        goal.RecordEvent();
        score += goal.Points;
    }

    public void ShowGoals()
    {
        Console.WriteLine();
    }
}
