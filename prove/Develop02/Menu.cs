using System.Collections.Immutable;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

public static class Menu
{
        public static void DisplayMenuOptions()
    {
        Console.WriteLine("Please choose your option:");
        Console.WriteLine("1: Write Entry");
        Console.WriteLine("2: Display Entries");
        Console.WriteLine("3: Load Journal");
        Console.WriteLine("4: Save Journal");
        Console.WriteLine("0: Exit Program");
    }

    public static int GetMenuChoice()
    {
        int menuChoice;
        bool validChoice;
        DisplayMenuOptions();
        do
        {
            menuChoice = int.Parse(Console.ReadLine());
            if (menuChoice > 8 || menuChoice < 0)
            {
                Console.Clear();
                Console.WriteLine($"{menuChoice} is not a valid choice, please try again.");
                DisplayMenuOptions();
                validChoice = false;
            }
            else
            {
                validChoice = true;
            }

        } while (!validChoice);
        return menuChoice;
    }


}