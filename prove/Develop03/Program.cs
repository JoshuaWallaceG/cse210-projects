using System;

class Program
{
    static void Main(string[] args)
    {
        string myScriptureText = "Therefore, dearly beloved brethren, let us cheerfully do all things that lie in our power; and then may we stand still, with the utmost assurance, to see the salvation of God, and for his arm to be revealed.";
        string myScriptureBook = "Doctrine and Covenants";
        string myScriptureChapter = "123";
        string myScriptureVerse = "17";

        bool fullyBlanked;
        int blankPercent;
        
        Reference myScriptureReference = new Reference(myScriptureBook, myScriptureChapter, myScriptureVerse);
        Scripture myScripture = new Scripture(myScriptureText, myScriptureReference);

        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.Write("Please enter your per-round blank percentage: ");
        blankPercent = int.Parse(Console.ReadLine());
        // Console.Write($"The scripture you will be memorizing is: ");
        // myScripture.printReference();
        // Console.WriteLine("When you are ready, press enter to start!");
        // Console.ReadLine();

        Console.Clear();
        myScripture.printReference();
        myScripture.printVerse();
        do
        {
            Console.WriteLine($"\nWhen you are ready, press enter to blank {blankPercent}% more!");
            Console.ReadLine();
            myScripture.blankPercent(blankPercent);
            Console.Clear();
            myScripture.printReference();
            myScripture.printVerse();
            fullyBlanked = myScripture.checkIfFullyBlanked();
        } while (!fullyBlanked);
    }
}