using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("Red", 5);
        Rectangle r1 = new Rectangle("Green", 10, 2);
        Circle c1 = new Circle("Purple", 3);

        Console.WriteLine($"The color of the square is {s1.GetColor()} and the area is {s1.GetArea()}");
        Console.WriteLine($"The color of the rectangle is {r1.GetColor()} and the area is {r1.GetArea()}");
        Console.WriteLine($"The color of the circle is {c1.GetColor()} and the area is {c1.GetArea()}");
    }
}