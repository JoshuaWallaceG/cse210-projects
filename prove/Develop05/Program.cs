using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    /*
    I demonstrated creativity in this project by adding an additional goal type: a multiplicative goal

    There are many goals in life, especially the ones we do on the daily, that don't become inherently more difficult, they just become more boring, and thus, we don't do them. 
    For example, we can often feel a burst of motivation to start journaling daily or going to bed on time every night, but after a few days, the motivation dies and we drop the attempted habit.

    Thus, with a multiplicative goal, the point reward increases each time we do it. 
    At the beginning, the novelty of doing something new is often all the motivation we need, and thus, we start off with a very low point reward amount. 
    The multiplicative goal multiplies our point reward by an increasing amount each time we do the reward. (1.0x -> 1.1x -> 1.2x -> 1.3x -> etc) 
    As our motivation naturally decreases, the amount of awarded points we get increases, thus maintaining the incentive to complete our goal.
    */

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
                    //Switch statement to create the right type of goal
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
                        case 4:
                            MultiplicativeGoal mg = new MultiplicativeGoal();
                            mg.NewGoal();
                            goals.Add(mg);
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
                    if(goals.Count == 0)
                    {
                        Console.WriteLine("You have no goals yet!");
                    }
                    else{
                        ListGoals(goals);
                        points += goals[GetCompletedGoal()-1].CompleteGoal();
                    }
                    break;
                case "0": //Quit
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid option. Please select an option from the menu (0 - 5)");
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
            Console.WriteLine("4. Multiplicative Goal");
            Console.Write("What type of goal would you like to create? ");
            choice = int.Parse(Console.ReadLine());
            if(choice > 4 || choice < 1)
            {
                Console.Clear();
                Console.WriteLine("Invalid choice.");
            }
        }while(choice > 4 || choice < 1); //Only lets the user select the 4 types of choices available
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
        //Because there is no way to "check" where you are in a foreach loop, so we have a manual counter to print off our list
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



