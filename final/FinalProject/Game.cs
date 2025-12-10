public class Game
{
    public static Random Random = new Random();
        
    List<Item> playerInventory = new List<Item>();
    //int playersMoney = 0;
    int vistingHeroAmount = 0;
    int currentDay = 1;

    public void Run(){

        for(int i = 0; i < 5; i++){
        playerInventory.Add(Item.GenerateRandomItem());
        }

        DisplayInventory();

        while(currentDay < 15){
            vistingHeroAmount = Game.Random.Next(2, 5); //2 to 4 heros will visit each day.

            while(vistingHeroAmount != 0){
            Hero h = Hero.GenerateRandomHero();
            h.EnterShop();
            if(h.GetTradeType() == TradeType.Buying)
                {
                    h.BuyOffer(playerInventory);
                }
            else
                {
                    //h.SellOffer();
                    Console.WriteLine("[INSERT SELL FUNCTIONALITY HERE]");
                }
            Console.WriteLine("------");
            --vistingHeroAmount;
            }

            ++currentDay;
        }
    }

    public void DisplayInventory()
    {
        Console.WriteLine($"═════════════════INVENTORY═════════════════");
        foreach(Item i in playerInventory)
        {
            Console.WriteLine($"{i.GetItemName()} ---- Value: ${i.GetItemTrueBaseValue()} -> ${i.GetItemCalculatedBaseValue()}");
        }
        Console.WriteLine($"═══════════════════════════════════════════");
    }

    public static void DisplayOfferMenu()
    {
        Console.WriteLine("╔══════════════════╗    ╔══════════════════╗");
        Console.WriteLine("║      ACCEPT      ║    ║       DENY       ║");
        Console.WriteLine("║     (A or Y)     ║    ║     (D or N)     ║");
        Console.WriteLine("╚══════════════════╝    ╚══════════════════╝");
    }
}
