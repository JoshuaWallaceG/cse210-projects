public static class Animation
{
    public static void Typing(int seconds, string heroName)
    {
        Console.Write($"{heroName}: ");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(166);

            Console.Write(".");
            Thread.Sleep(166);

            Console.Write(".");
            Thread.Sleep(166);
            Console.Write("\b\b\b   \b\b\b");

            Console.Write(".");
            Thread.Sleep(166);

            Console.Write(".");
            Thread.Sleep(166);

            Console.Write(".");
            Thread.Sleep(166);
            Console.Write("\b\b\b   \b\b\b");
        }
    }
}