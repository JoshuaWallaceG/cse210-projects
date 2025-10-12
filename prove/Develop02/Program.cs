using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        Journal currentJournal = new Journal();
        int userChoice;
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
            }

        } while (userChoice != 0);
        Console.WriteLine("Goodbye!");
    }

}