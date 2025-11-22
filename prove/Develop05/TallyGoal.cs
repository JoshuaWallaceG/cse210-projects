public class TallyGoal : Goal
{
    int _tallyCount = 0;
    int _tallyGoal;
    int _associatedBonusPoints;
    bool _isCompleted;


    public override void NewGoal()
    {
        Console.Write("Please enter what would like to title this goal: ");
        _title = Console.ReadLine();
        Console.Write("Please enter details of this goal: ");
        _details = Console.ReadLine();
        Console.Write("Please enter the amount of points to be awarded upon completion: ");
        _associatedPoints = int.Parse(Console.ReadLine());
        Console.Write("Please enter the amount of tallies you'd like for this goal: ");
        _tallyGoal = int.Parse(Console.ReadLine());
        Console.Write("Please enter the amount of bonus points to be awarded upon completion: ");
        _associatedBonusPoints = int.Parse(Console.ReadLine());

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
            _tallyCount++;
            if(_tallyCount == _tallyGoal)
            {
                Console.WriteLine("You have also completed your final tally of your goal!");
                Console.WriteLine($"You have been awarded {_associatedBonusPoints} bonus points!");
                _isCompleted = true;
                return _associatedPoints + _associatedBonusPoints;
            }
            else
            {
                return _associatedPoints;
            }
        }
    }

    public override void PrintGoal()
    {
        Console.WriteLine($"[{_tallyCount}/{_tallyGoal}] {_title} ({_details})");
    }

    public override string OutputGoalToFileString()
    {
        //Format: Type~Goal~GoalDetails~Points~TallyCount~TallyGoal~BonusPoints~IsCompleted
        return $"2~{_title}~{_details}~{_associatedPoints}~{_tallyCount}~{_tallyGoal}~{_associatedBonusPoints}~{_isCompleted}";
    }

    public override void LoadGoalFromFileLine(string fileLine)
    {
        string[] splitLine = fileLine.Split('~');
        _title = splitLine[1];
        _details = splitLine[2];
        _associatedPoints = int.Parse(splitLine[3]);
        _tallyCount = int.Parse(splitLine[4]);
        _tallyGoal = int.Parse(splitLine[5]);
        _associatedBonusPoints = int.Parse(splitLine[6]);
        _isCompleted = bool.Parse(splitLine[7]);
    }
}