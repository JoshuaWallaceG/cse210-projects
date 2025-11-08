using System.Reflection.Metadata;

public class ListingActivity : Activity
{
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    private static List<string> _listingPrompts = new List<string>
    {
        "What is something kind someone did for you recently?",
        "What is a challenge you've overcome lately?",
        "When have you felt guided or protected?",
        "What made you smile this week?",
        "What is something you are learning about yourself?",
        "Who have you seen show quiet courage?",
        "What is a prayer that was answered recently?",
        "When did you feel genuine peace lately?",
        "What is a scripture or quote that has stayed with you?",
        "Who has been an example of patience to you?",
        "What act of service have you given recently?",
        "What blessings are you noticing more often?",
        "Who has helped you feel understood?",
        "What new habit are you trying to build?",
        "When have you felt joy in simple things?",
        "What is something you are thankful your past self did?",
        "Who has shown you love in a quiet way?",
        "What spiritual gift are you developing?",
        "What moment recently felt meaningful to you?",
        "Who have you tried to lift or encourage this week?"
    };
    private static Random random = new Random();

    public void DoActivity()
    {
        Console.Clear();
        base.PrintStartingMessage();
        _duration = base.PromptAndReturnSessionLength();
        Console.Clear();
        base.PlayGetReadyCycle();
        Console.Clear();
        
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---{_listingPrompts[random.Next(0, _listingPrompts.Count)]}---\n");
        Console.Write("You will begin in: ");
        base.CountDown(5);
        Console.Write("Now!\n");

        //Lets the user input until they are out of time, but makes sure that it doesn't cut the user off while typing
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int listCounter = 0;
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            listCounter++;
        }
        Console.WriteLine($"You listed {listCounter} items!");

        Console.WriteLine();
        base.PlayEndingMessageCycle();

    }
}