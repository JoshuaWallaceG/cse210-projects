public class SimpleGoal : Goal
{
    bool _isCompleted = false;

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
        if (_isCompleted)
        {
            Console.WriteLine("You have already completed this goal. No points awarded");
            return 0;
        }
        else{
            Console.WriteLine($"Congrats! You have completed the following goal: {_title}");
            Console.WriteLine($"You have been awarded {_associatedPoints} points.");
            _isCompleted = true;
            return _associatedPoints;
        }
    }

    public override void PrintGoal()
    {
        if (_isCompleted){
            Console.WriteLine($"[X] {_title} ({_details})");
        }
        else
        {
            Console.WriteLine($"[ ] {_title} ({_details})");
        }
    }

    public override string OutputGoalToFileString()
    {
        return $"1~{_title}~{_details}~{_associatedPoints}~{_isCompleted}";
    }

    public override void LoadGoalFromFileLine(string fileLine)
    {
        string[] splitLine = fileLine.Split('~');
        _title = splitLine[1];
        _details = splitLine[2];
        _associatedPoints = int.Parse(splitLine[3]);
        _isCompleted = bool.Parse(splitLine[4]);
    }
}