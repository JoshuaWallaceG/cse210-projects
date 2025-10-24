using System;

class Program
{

    /*
    I demonstrated creativity by adding a "blank percentage" prompt and variable that allows the user to customize what percentage of the prompt they would like to hide each round, effectively adding a customizable difficulty option for the user. 
    To make sure that the user did not input a value like 0, which would cause the program to clear nothing each round, I also added a input validation check to only accept percentage values from 1-100. 
    Because the user could input low values like 1% and 2%, I also added code to assure that at least one word was blanked each round instead of the possibility of no words being blanked when using said lower percentages.
    */

    static void Main(string[] args)
    {

        //All the scriptures from the user
        string myScriptureText = "Therefore, dearly beloved brethren, let us cheerfully do all things that lie in our power; and then may we stand still, with the utmost assurance, to see the salvation of God, and for his arm to be revealed.";
        string myScriptureBook = "Doctrine and Covenants";
        string myScriptureChapter = "123";
        string myScriptureStartingVerse = "17";
        //If it was a longer scripture with 2+ verses, you could use the following extra variable and the 2nd Reference constructor
        //string myScriptureEndingVerse = "#";

        bool validBlankNum, fullyBlanked;
        int blankPercent;
        string userInput;
        
        Reference myScriptureReference = new Reference(myScriptureBook, myScriptureChapter, myScriptureStartingVerse);
        Scripture myScripture = new Scripture(myScriptureText, myScriptureReference);

        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.Write("Please enter your per-round blank percentage between 1-100: ");
        do
        {
            blankPercent = int.Parse(Console.ReadLine());
            //Simple check to confirm that blank percentage is within 1-100
            if (blankPercent > 100 || blankPercent < 1)
            {
                Console.Write("Please enter a valid blank percentage between 1-100: ");
                validBlankNum = false;
            }
            else
            {
                validBlankNum = true;
            }
        } while (!validBlankNum);

        //In order to both begin with no blanks AND end with it fully blanked, I have to have atleast 1 of the  prints/clear screens outside the loop.
        Console.Clear();
        myScripture.printReference();
        myScripture.printVerse();
        do
        {
            Console.WriteLine($"\nPress enter to blank {blankPercent}% more, or type \"quit\" to end.");
            userInput = Console.ReadLine().ToLower();
            myScripture.blankPercent(blankPercent);
            Console.Clear();
            myScripture.printReference();
            myScripture.printVerse();
            fullyBlanked = myScripture.checkIfFullyBlanked();
        } while (!fullyBlanked && userInput != "quit");
    }
}