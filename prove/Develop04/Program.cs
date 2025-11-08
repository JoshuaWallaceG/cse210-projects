using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        string choice;
        while (running)
        {
            Console.Clear();
            DisplayMenuOptions();
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.DoActivity();
                    break;

                case "2":
                    Console.Clear();
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.DoActivity();
                    break;
                case "3":
                    Console.Clear();
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.DoActivity();
                    break;
                case "4":
                    Console.Clear();
                    MoodScanActivity moodScanActivity = new MoodScanActivity();
                    moodScanActivity.DoActivity();
                    break;
                case "0":
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid option. Please selection an option from the menu (0 - 3");
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