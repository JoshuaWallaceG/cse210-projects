public class MultiplicativeGoal : Goal
{
    double _multiplier = 1;
    int _multipliedPoints = 0;

    public override void NewGoal()
    {
        Console.Write("Please enter what would like to title this goal: ");
        _title = Console.ReadLine();
        Console.Write("Please enter details of this goal: ");
        _details = Console.ReadLine();
        Console.Write("Please enter the amount of starting points to be awarded upon completion: ");
        _associatedPoints = int.Parse(Console.ReadLine());

    }

    public override int CompleteGoal()
    {
        Console.Clear();
        _multipliedPoints = (int)(_associatedPoints * _multiplier);
        _multiplier+= .1;
        Console.WriteLine($"Congrats! You have completed the following goal: {_title}");
        Console.WriteLine($"You have been awarded {_multipliedPoints} points.");
        return _multipliedPoints;
    }
    
    public override void PrintGoal()
    {
        Console.WriteLine($"[{_multiplier:0.0}x] {_title} ({_details})");
    }

    public override string OutputGoalToFileString()
    {
        //Format: Type~Goal~GoalDetails~Points~Multiplier
        return $"4~{_title}~{_details}~{_associatedPoints}~{_multiplier:0.0}";
    }

    public override void LoadGoalFromFileLine(string fileLine)
    {
        string[] splitLine = fileLine.Split('~');
        _title = splitLine[1];
        _details = splitLine[2];
        _associatedPoints = int.Parse(splitLine[3]);
        _multiplier = double.Parse(splitLine[4]);
    }
}