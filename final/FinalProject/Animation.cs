public static class Animation
{
    public static void Typing(int seconds)
    {
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