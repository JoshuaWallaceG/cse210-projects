using System;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        int userNumber;
        int sum = 0, largest = 0;
        float average = 0;
        List<int> numberList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Get all numbers
        do
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

        //Making sure 0 doesn't get included
            if (userNumber != 0)
            {
                numberList.Add(userNumber);
            }
        } while (userNumber != 0);

        // Get sum
        //We also get the largest number, because we already happen to be looping through the list.
        largest = numberList[0];
        foreach (int number in numberList)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
        }

        //Calculate average
        average = (float)sum / numberList.Count();

        //Print Results
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Largest: {largest}");
    }
}