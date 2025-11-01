using System;

class Program
{
    static void Main(string[] args)
    {
        
        string n1 = "Ben Board";
        string t1 = "Science";
        
        string n2 = "James John";
        string t2 = "Maths";
        string c2 = "Section 3";
        string p2 = "6.2 - 6.7";

        string n3 = "Mary Wander";
        string t3 = "Writing";
        string b3 = "How To Fly";

        Assignment myAssignment = new Assignment(n1, t1);
        MathAssignment myMathAssignment = new MathAssignment(n2, t2, c2, p2);
        WritingAssignment myWritingAssignment = new WritingAssignment(n3, t3, b3);
        
        Console.WriteLine(myAssignment.GetSummary());
        Console.WriteLine();
        Console.WriteLine(myMathAssignment.GetSummary());
        Console.WriteLine(myMathAssignment.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(myWritingAssignment.GetSummary());
        Console.WriteLine(myWritingAssignment.GetWritingInformation());
    }
}