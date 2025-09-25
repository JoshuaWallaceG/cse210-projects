using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        //Loops!

        //foreach
        List<string> fruits = new List<string>() { "Apple", "Bannana", "Cherry" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        fruits.Add("Eggplant");
        fruits[0] = "Apricot";

        Console.WriteLine(fruits[0]);
        Console.WriteLine(fruits[3]);

        //for loops
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"I: {i}");
        }

        //while loops
        /*
        Console.WriteLine("Make a choice (y or n): ");
        string value = Console.ReadLine().ToUpper();
        while(value != "Y" && value != "N"){
            Console.Write("Choose y or n!" );
            value = Console.ReadLine().ToUpper();
        }
        */
        //     string value;
        //     do{
        //         Console.Write("Enter y or n: ");
        //         value = Console.ReadLine().ToUpper();
        //     } while(value != "Y" && value != "N");

        // int a = 5;
        // int b = 7;
        // int sum;
        // sum = AdderFunction(a, b);
        // Console.WriteLine($"The sum of {a} and {b} is {sum}");

        // string theName = "Steve";
        // GreetUser(theName);

        int[] myArray = new int[] { 1, 2, 3, 4, 5 };

        foreach (int number in myArray)
        {
            Console.Write($"{number} ");
        }
        changeByReference(myArray);
        Console.WriteLine();
        foreach (int number in myArray)
        {
            Console.Write($"{number} ");
        }
    }

    static void changeByReference(int[] data)
{
    data[2] = 100;
}

}