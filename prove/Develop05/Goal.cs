public abstract class Goal
{
    protected string _title;
    protected string _details;
    protected int _associatedPoints;

    public abstract int CompleteGoal();
    public abstract void NewGoal();
    public abstract void PrintGoal();
    public abstract string OutputGoalToFileString();
    public abstract void LoadGoalFromFileLine(string fileLine);


}