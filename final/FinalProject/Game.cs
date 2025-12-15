using System.Dynamic;

public class Game
{
    public static Random Random = new Random();
    private List<Item> playerInventory = new List<Item>();
    private int playerMoney = 125;
    private int vistingHeroAmount = 0;
    private int offerResult = 0;
    private int currentDay = 1;

    public void Run(){

        //Player starts off with 2 items
        for(int i = 0; i < 2; i++){
            playerInventory.Add(Item.GenerateRandomItem());
        }

        //This is all pre-game intro
        Animation.DisplayTitleScreen();
        Console.Clear();
        Animation.DisplayStoryIntro();
        Console.WriteLine($"\nPress enter to start!");
        Console.ReadLine();
        Console.Clear();

        while(currentDay <= 10){
            vistingHeroAmount = Game.Random.Next(1, 4); //1 to 3 heros will visit each day.
            Animation.DisplayDayCounter(currentDay);
            Animation.SlowWaiting(2);
            Console.Write($"\nPress enter to begin the day.");
            Console.ReadLine();
            Animation.ClearPastLine();

            //Daily loop
            while(vistingHeroAmount != 0){
                Animation.SlowWaiting(Random.Next(3, 7));
                Console.WriteLine("You hear a knock at the door... Press enter to answer it!");
                Console.ReadLine();
                Console.Clear();

                //Trading phase
                Animation.DisplayInventory(playerInventory, playerMoney);
                Hero h = Hero.GenerateRandomHero();
                h.EnterShop();
                //There is a 50/50 chance that the hero is buying or selling, so we branch off into two logic branches depending on which type
                if(h.GetTradeType() == TradeType.Buying)
                    {
                        offerResult = h.BuyOffer(playerInventory);
                        if(offerResult == 0)
                        {
                            h.LeaveShop(false);
                        }
                        else
                        {
                            playerMoney += offerResult;
                            h.LeaveShop(true);
                        }
                    }
                else
                    {
                        offerResult = h.SellOffer(playerInventory, playerMoney);
                        if(offerResult == 0)
                        {
                            h.LeaveShop(false);
                        }
                        else
                        {
                            playerMoney -= offerResult;
                            h.LeaveShop(true);
                        }
                    }
                --vistingHeroAmount;
            }
            //Ending day sequence
            ++currentDay;
            Animation.SlowWaiting(3);
            Console.WriteLine("The day comes to a close...");
        }
        //After the final day, the ending sequence is played.
        Animation.DisplayEnding(playerMoney);
    }

    public static bool GetAcceptBuyOfferChoice()
    {
        bool isValid;
        do{
            switch (Console.ReadLine().ToLower())
            {
                case "y" or "a":
                Animation.ClearPastLine();
                Console.WriteLine("You: \"Sure!\"                                                  ");
                return true;

                case "n" or "d":
                Animation.ClearPastLine();
                Console.WriteLine("You: \"No thank you.\"                                           ");
                return false;

                default:
                Animation.ClearPastLine();
                Console.WriteLine("Invalid input. Please type one of the listed options.  "); //Error message
                isValid = false;
                break;
            }
        }while(!isValid);

        //It will never reach here, but just as a precation
        return false;
    }
    
    public static bool GetAcceptSellOfferChoice(List<Item> playerInventory, int playerMoney, int buyingPrice)
    {
        bool isValid;
        do{
            switch (Console.ReadLine().ToLower())
            {
                case "y" or "a":
                if(buyingPrice > playerMoney)
                {
                    Animation.ClearPastLine();
                    Console.WriteLine("You don't have sufficient funds to make this purchase!"); //Error message
                    isValid = false;
                }
                else if(playerInventory.Count >= 4)
                {
                    Animation.ClearPastLine();
                    Console.WriteLine("You don't have sufficient space to make this purchase!"); //Error message
                    isValid = false;
                }
                else 
                {
                    Animation.ClearPastLine();
                    Console.WriteLine("You: \"Sure!\"                                              ");
                    return true;
                }
                break;

                case "n" or "d":
                Animation.ClearPastLine();
                Console.WriteLine("You: \"No thank you.\"                                             ");
                return false;

                default:
                Animation.ClearPastLine();
                Console.WriteLine("Invalid input. Please type one of the listed options.  "); //Error message
                isValid = false;
                break;
            }
        }while(!isValid);

        //It will never reach here, but just as a precation
        return false;
    }
}

