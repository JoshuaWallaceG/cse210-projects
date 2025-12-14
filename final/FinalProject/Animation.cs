public static class Animation
{
    public static void Typing(int seconds, string heroName)
    {
        Console.Write($"{heroName}: ");
        Thread.Sleep(1000);
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
    public static void SlowWaiting(int seconds)
    {
        int i = 0;
        while(i < seconds){
            Thread.Sleep(500);
            Console.Write(".");

            Thread.Sleep(500);
            Console.Write(".");
            i++;
            if((i % 3) == 0)
                {
                    Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
                }

        }
        Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
    }

    public static void ClearPastLine()
    {
        Console.SetCursorPosition(0, Console.CursorTop - 1); //Moves arrow back up to where they just entered
        Console.Write(new string(' ', Console.BufferWidth)); //Clears their input
        Console.SetCursorPosition(0, Console.CursorTop - 1); //Sets it back to where it wiill be before
    }

    public static void DisplayInventory(List<Item> playerInventory, int playerMoney)
    {
        Console.WriteLine($"╔═══════════════════INVENTORY═══════════════════╗");
        foreach(Item i in playerInventory)
        {
            Console.WriteLine($"║{i.GetItemName(), 25} - Value: ${i.GetItemTrueBaseValue(), -3} -> ${i.GetItemCalculatedBaseValue(), -3}║");
        }
        Console.WriteLine($"╠═══════════════════════╦═══════════════════════╣");
        Console.WriteLine($"║      Cash: ${playerMoney, -5}     ║      Items: {playerInventory.Count(), -1}/4       ║");
        Console.WriteLine($"╚═══════════════════════╩═══════════════════════╝");
    }

    public static void DisplayOfferMenu()
    {
        Console.WriteLine("╔══════════════════╗      ╔══════════════════╗");
        Console.WriteLine("║      ACCEPT      ║      ║       DENY       ║");
        Console.WriteLine("║     (A or Y)     ║      ║     (D or N)     ║");
        Console.WriteLine("╚══════════════════╝      ╚══════════════════╝\n");
    }

    public static void DisplayDayCounter(int currentDay)
    {
        Console.WriteLine("            ╔═════════════════╗");
        Console.WriteLine($"            ║      DAY {currentDay}      ║");
        Console.WriteLine("            ╚═════════════════╝");
    }

    public static void DisplayTitleScreen()
    {
        Console.WriteLine("▄▄▄▄▄▄▄▄▄ ▄▄                               ||      ||           "); 
        Console.WriteLine("▀▀▀███▀▀▀ ██                               ||      ||           ");
        Console.WriteLine("   ███    ████▄ ▄█▀█▄                      ||      ||           ");   
        Console.WriteLine("   ███    ██ ██ ██▄█▀                 ╔═════════════════╗       ");   
        Console.WriteLine("   ███    ██ ██ ▀█▄▄▄                 ║      WE'RE      ║       ");
        Console.WriteLine("                                      ║       OPEN      ║       ");                                                    
        Console.WriteLine(" ▄▄▄▄▄▄▄ ▄▄                           ╚═════════════════╝       ");
        Console.WriteLine("█████▀▀▀ ██                ▄▄                                   ");
        Console.WriteLine(" ▀████▄  ████▄ ▄███▄ ████▄ ██ ▄█▀ ▄█▀█▄ ▄█▀█▄ ████▄ ▄█▀█▄ ████▄ ");
        Console.WriteLine("   ▀████ ██ ██ ██ ██ ██ ██ ████   ██▄█▀ ██▄█▀ ██ ██ ██▄█▀ ██ ▀▀ ");
        Console.WriteLine("███████▀ ██ ██ ▀███▀ ████▀ ██ ▀█▄ ▀█▄▄▄ ▀█▄▄▄ ████▀ ▀█▄▄▄ ██    ");
        Console.WriteLine("                     ██                       ██                ");
        Console.WriteLine("                     ▀▀                       ▀▀                ");
        Console.WriteLine("\nPress enter to continue!");
        Console.ReadLine();
    }

    public static void DisplayStoryIntro()
    {
        Console.WriteLine("The war is coming. Travelers pass through town more often now, searching both to buy and sell. They all seem to stop at the same place along the road: your shop.");
        SlowWaiting(4);
        Console.WriteLine("\nYou aren't a fighter. You just run the counter. But in 7 days, the war will begin and your doors will close. Your goal? Make as much coin now to be able to outlast the war.");
        SlowWaiting(5);
        Console.WriteLine("\nEach day, heros will visit your shop. They will either make you an offer on your own items or try to sell you one of their own. As any good businessman, you try to buy low and sell high. Take note! Different heros fancy different types of items- and will pay a higher rate for them.");
        SlowWaiting(3);
        Console.WriteLine("\nAs such, try to keep a varied stock of items for your visitors. And watch out: some days might bring events, so hope for the best and prepare for the worst.");
        SlowWaiting(3);
    }

}




