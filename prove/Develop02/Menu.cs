using System.Collections.Immutable;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

public static class Menu
{
        public static void DisplayMenuOptions()
    {
        Console.WriteLine("1: Write Entry");
        Console.WriteLine("2: Display Entries");
        Console.WriteLine("3: Load Journal");
        Console.WriteLine("4: Save Journal");
        Console.WriteLine("0: Exit Program");
        Console.Write("Please choose your option: ");
    }

    public static int GetMenuChoice()
    {
        int menuChoice;
        bool validChoice;
        DisplayMenuOptions();
        do
        {
            //Validity checks for menu options
            menuChoice = int.Parse(Console.ReadLine());
            if (menuChoice > 4 || menuChoice < 0)
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