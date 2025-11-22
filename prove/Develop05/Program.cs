using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        int points = 0;
        string choice;
        List<Goal> goals = new List<Goal>();
        Console.Clear();
        while (running)
        {
            Console.WriteLine($"You have {points} points.\n");    
            DisplayMenuOptions();
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1": //Create Goal
                    Console.Clear();
                    switch (GetCreateGoalType())
                    {
                        case 1:
                            SimpleGoal sg = new SimpleGoal();
                            sg.NewGoal();
                            goals.Add(sg);
                            break;
                        case 2:
                            EternalGoal eg = new EternalGoal();
                            eg.NewGoal();
                            goals.Add(eg);
                            break;
                        case 3:
                            TallyGoal tg = new TallyGoal();
                            tg.NewGoal();
                            goals.Add(tg);
                            break;
                    }
                    break;
                case "2": //List Goals
                    Console.Clear();
                    ListGoals(goals);
                    break;
                case "3": //Save Goals
                    FileFunctions.SaveToFile(points, goals);
                    Console.Clear();
                    Console.WriteLine("Goals have been saved.");
                    break;
                case "4": //Load Goals
                    points = FileFunctions.LoadFromFile(goals);
                    Console.Clear();
                    Console.WriteLine("Goals have been loaded.");
                    break;
                case "5": //Record event
                    Console.Clear();
                    ListGoals(goals);
                    points += goals[GetCompletedGoal()-1].CompleteGoal();
                    break;
                case "0": //Quit
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid option. Please selection an option from the menu (0 - 5)");
                    break;
            }
        }
    }
    public static void DisplayMenuOptions()
    {
        Console.WriteLine("1: Create new goal");
        Console.WriteLine("2: List Goals");
        Console.WriteLine("3: Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record event");
        Console.WriteLine("0: Quit");
        Console.Write("Please choose your option: ");
    }

    public static int GetCreateGoalType()
    {
        int choice = 0;
        do{
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Tally Goal");
            Console.Write("What type of goal would you like to create? ");
            choice = int.Parse(Console.ReadLine());
            if(choice > 3 || choice < 1)
            {
                Console.Clear();
                Console.WriteLine("Invalid choice.");
            }
        }while(choice > 3 || choice < 1);

        return choice;
    }

    public static int GetCompletedGoal()
    {
        Console.Write("Please select which goal you acomplished: ");
        return int.Parse(Console.ReadLine());
    }

    public static void ListGoals(List<Goal> goals)
    {
        Console.WriteLine("Your goals are:");
        int counter = 1;
        foreach (Goal g in goals)
        {
            Console.Write($"{counter}. ");
            g.PrintGoal();
            counter++;
        }
        Console.WriteLine();
    }

    
}



