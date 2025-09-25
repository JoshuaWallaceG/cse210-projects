using System;

class Program
{
    static void Main(string[] args)
    {
        string userName;
        int userNumber, userBirthYear, squaredNumber;

        DisplayWelcome();
        userName = PromptUserName();
        userNumber = PromptUserNumber();
        PromptUserBirthYear(out userBirthYear);
        squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber, userBirthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter the year you were born: ");
        year = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int userNumber)
    {
        return userNumber * userNumber;
    }

    static void DisplayResult(string userName, int squaredNumber, int userBirthYear)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}.");
        Console.WriteLine($"{userName}, you will turn {2025 - userBirthYear} this year.");
    }
}