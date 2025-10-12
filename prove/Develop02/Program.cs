using System;
using System.IO.Compression;

class Program
{

/*
I demonstrated creativity by adding a small part of mindfulness to the program. 
One of the reasons why I didn't journal for a long time was that I was only journaling informationally, in the sense that I was just documenting what happened in the day. 
Because of that, I was never getting anything out of it other than a log book of my daily life.
When I started journaling and adding in things like how I felt and logging my emotions, I was able to feel more mindful of my current state of mind and identify the different events that caused me to feel one way or the other. 

As such, I've decided to add a simple question: "In 1 word, what is your mood right now?"
As a moment is taken to reflect, and then recorded, we are able to become more and more aware of not only what we did, but how we felt as well.    
*/
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