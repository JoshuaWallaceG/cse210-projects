using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 25);
        int userGuess;

        do
        {
            Console.Write("Guess the magic number: ");
            userGuess = int.Parse(Console.ReadLine());
            if (userGuess > magicNumber)
            {
                Console.WriteLine("Too high!");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (userGuess == magicNumber)
            {
                Console.WriteLine($"You got it! The number was {magicNumber}");
            }
        } while (userGuess != magicNumber);
    }
}