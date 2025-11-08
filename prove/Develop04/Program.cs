using System;

class Program
{
    /*
    I demonstrated creativity in this project by adding an addition activity to the program: a mood-scan. 

    I believe that one of the most important aspects of mindfulness is being able to identify how you feel at the current moment, 
     and then identify what current factors or aspects of your life that are contributing to that feeling.

    For example, if I can realize that I'm stressed, and that X or Y is contributing to that stress,
     I can begin to deal with X and Y to hopefully decrease the stress instead of trying to ignore it/fix the stress without fixing the underlying problem.

    Thus, the activity I added prompts the user to think and identify how they feel, and then in their selected amount of time,
     asks the user to list off as many things as possible that they believe are responsible for that feeling.
     It then outputs a quantity of how many things there were able to identify.
    */

    static void Main(string[] args)
    {
        bool running = true;
        string choice;
        Console.Clear();
        while (running)
        {
            DisplayMenuOptions();
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.DoActivity();
                    Console.Clear();
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.DoActivity();
                    Console.Clear();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.DoActivity();
                    Console.Clear();
                    break;
                case "4":
                    MoodScanActivity moodScanActivity = new MoodScanActivity();
                    moodScanActivity.DoActivity();
                    Console.Clear();
                    break;
                case "0":
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid option. Please selection an option from the menu (0 - 4)");
                    break;
            }
        }
    }
    public static void DisplayMenuOptions()
    {
        Console.WriteLine("1: Start breathing activity");
        Console.WriteLine("2: Start reflecting activity");
        Console.WriteLine("3: Start listing activity");
        Console.WriteLine("4. Start mood-scan activity");
        Console.WriteLine("0: Quit");
        Console.Write("Please choose your option: ");
    }
}