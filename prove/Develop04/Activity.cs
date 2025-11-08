public class Activity()
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public void PrintStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
    }

    public void PlayEndingMessageCycle()
    {
        Console.WriteLine("Well done!");
        SpinnerAnimation(2);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}. Returning to menu...");
        SpinnerAnimation(3);
    }

    public int PromptAndReturnSessionLength()
    {
        Console.Write("How long, in seconds, would you like your session to be? ");
        return int.Parse(Console.ReadLine());
    }

    public void PlayGetReadyCycle()
    {
        Console.WriteLine("Get ready...");
        SpinnerAnimation(3);
    }

    protected void SpinnerAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("<");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("v");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write(">");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("^");
            Thread.Sleep(250);
            Console.Write("\b \b");

        }
    }

    protected void CountDown(int countFrom)
    {
        for (int i = 0; i < countFrom; i++)
        {
            Console.Write(countFrom - i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}