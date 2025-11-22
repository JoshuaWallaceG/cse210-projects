public class EternalGoal : Goal
{
    int _tallyCount = 0;

    public override void NewGoal()
    {
        Console.Write("Please enter what would like to title this goal: ");
        _title = Console.ReadLine();
        Console.Write("Please enter details of this goal: ");
        _details = Console.ReadLine();
        Console.Write("Please enter the amount of points to be awarded upon completion: ");
        _associatedPoints = int.Parse(Console.ReadLine());

    }

    public override int CompleteGoal()
    {
        Console.Clear();
        Console.WriteLine($"Congrats! You have completed the following goal: {_title}");
        Console.WriteLine($"You have been awarded {_associatedPoints} points.");
        _tallyCount++;
        return _associatedPoints;
    }
    
    public override void PrintGoal()
    {
        Console.WriteLine($"[{_tallyCount}] {_title} ({_details})");
    }

    public override string OutputGoalToFileString()
    {
        //Format: Type~Goal~GoalDetails~Points~TallyCount
        return $"2~{_title}~{_details}~{_associatedPoints}~{_tallyCount}";
    }

    public override void LoadGoalFromFileLine(string fileLine)
    {
        string[] splitLine = fileLine.Split('~');
        _title = splitLine[1];
        _details = splitLine[2];
        _associatedPoints = int.Parse(splitLine[3]);
        _tallyCount = int.Parse(splitLine[4]);
    }
}