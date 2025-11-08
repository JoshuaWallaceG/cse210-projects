public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }
    
    public void DoActivity()
    {
        Console.Clear();
        base.PrintStartingMessage();
        _duration = base.PromptAndReturnSessionLength();
        Console.Clear();
        base.PlayGetReadyCycle();
        Console.Clear();

        //Finds the amount of "excess" seconds (seconds that aren't a a multiple of 10)
        int excess = _duration % 10;
        //Because the main "standard" breathing exercise is done in 10 second chunks (4 seconds in, 6 seconds out), this part checks for the time that isn't a multiple of 10, and starts the breathing exercise with that.
        if (excess != 0)
        {
            int breathInExcess = excess / 2;
            int breathOutExcess;
            if ((excess % 2) == 0)
            {
                breathOutExcess = breathInExcess;
            }
            else
            {
                breathOutExcess = breathInExcess + 1;
            }
            Console.Write("\nBreath in...");
            base.CountDown(breathInExcess);
            Console.Write("\nBreath out...");
            base.CountDown(breathOutExcess);
            Console.WriteLine();
        }

        //The previously mentioned "standard" breathing excercise (10 second chunks)
        for (int i = 1; i * 10 <= _duration; i++)
        {
            Console.Write("\nBreath in... ");
            base.CountDown(4);
            Console.Write("\nBreath out... ");
            base.CountDown(6);
            Console.WriteLine();
        }

        Console.WriteLine();
        base.PlayEndingMessageCycle();

    }
}