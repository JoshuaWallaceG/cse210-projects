using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        Journal currentJournal = new Journal();
        int userChoice;
        //Menu is heavily abstracted for readibility sake
        do
        {
            userChoice = Menu.GetMenuChoice();
            Console.Clear();
            switch (userChoice)
            {
                case 1:
                    currentJournal.AddEntry();
                    break;
                case 2:
                    currentJournal.DisplayJournal();
                    break;
                case 3:
                    currentJournal = new Journal();
                    currentJournal.LoadFromFile();
                    break;
                case 4:
                    currentJournal.SaveToFile();
                    break;
                //No need for default switch case because GetMenuChoice will never return a value outside of 1-4
            }
        } while (userChoice != 0);
        Console.WriteLine("Goodbye!");
    }

}