using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //I was told to leave this here...
        /*
        Console.WriteLine("Hello Prep1 World!");

        string firstName = "Bob";
        Console.WriteLine($"Hello {firstName}");

        Console.Write("What is your favorite color? ");
        string favoriteColor = Console.ReadLine();

        Console.WriteLine($"{firstName}, your favorite color is {favoriteColor}.");

        Console.Write("How old are you? ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"{firstName}, you are {age} years old.");

        int a = 13;
        int b = 7;
        int c = a + b;

        Console.WriteLine($"c is {c}");
        Console.WriteLine($"a/b is {a / b}");
        Console.WriteLine($"a/b is {(double)a / b}");

        bool isDone = false;

        if (isDone)
        {
            Console.WriteLine("All done!");
        }
        else
        {
            Console.WriteLine("Not done yet.");
        }
        */

        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        
        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.");
    }
}