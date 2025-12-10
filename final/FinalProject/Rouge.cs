public class Rouge : Hero
{
    public Rouge(string name, TradeType tradeType, Item ownedItem, double buySellMultiplier) 
        : base(name, tradeType, ownedItem, buySellMultiplier)
    {
        _heroType = HeroType.Rouge;
    }

    public override void EnterShop()
    {
        Console.WriteLine($"{_name} the Rouge strolls into your shop!");
        switch(Game.Random.Next(0, 3))
        {
            case 0:
            Animation.Typing(2, _name);
            Console.WriteLine($"\"Well hey there. I'm sure you missed me..\"");
            break;
            case 1:
            Animation.Typing(2, _name);
            Console.WriteLine($"\"Howdy bud! Guess who's back? Don't worry, no warrants this time.\"");
            break;
            case 2:
            Animation.Typing(2, _name);
            Console.WriteLine($"\"Hey keep', mind if I poke around? I promise to leave everything where I found it.\"");
            break;
        }
    }

    public override void BuyOffer(List<Item> playerInventory)
    {
        int preferredItems = 0;
        List<Item> preferredItemsList = new List<Item>();
        Item wantedItem;
        int buyingPrice;

        foreach(Item i in playerInventory) //Finding total amount of items that the warrior likes
        {
            if(i.GetPreferredHero() == HeroType.Rouge)
            {
                preferredItemsList.Add(i);
                preferredItems++;
            }
        }
        
        if (preferredItemsList.Count() == 0)
        {
            wantedItem = playerInventory[Game.Random.Next(0, playerInventory.Count())];
            buyingPrice = (int)(wantedItem.GetItemCalculatedBaseValue() * _buySellMultiplier);

            Animation.Typing(2, _name);
            Console.WriteLine("\"Aw man, you don't got anything that can stab in here. Huge bummer.\"");
            Animation.Typing(2, _name);
            Console.WriteLine($"\"But honestly, this {wantedItem.GetItemName()} isn't half bad...\"");
            Animation.Typing(3, _name);
            Console.WriteLine($"\"I'll take it off your hands for ${buyingPrice}. What do you say?\"");
            Game.DisplayOfferMenu();
            Console.ReadLine();
        }
        else
        {
            wantedItem = preferredItemsList[Game.Random.Next(0, preferredItemsList.Count())];
            buyingPrice = (int)(wantedItem.GetItemCalculatedBaseValue() * _buySellMultiplier * _itemMatchMultiplier);

            Animation.Typing(2, _name);
            Console.WriteLine("\"Oh hey, you got some good stuff for slicing in here!\"");
            Animation.Typing(2, _name);
            Console.WriteLine($"\"This {wantedItem.GetItemName()} here is really speaking my language.\"");
            Animation.Typing(3, _name);
            Console.WriteLine($"\"Tell me keep', would you take ${buyingPrice} for this guy?\"");
            Game.DisplayOfferMenu();
            Console.ReadLine();
        }
    }

    public override void LeaveShop(){}
    public override void SellOffer(){}
    public override void DebugPresentSelf()
    {
        if(_tradeType == TradeType.Buying)
        {
            Console.WriteLine($"Hello! My name is {_name} the Rouge, and I want to buy anything using a multiplier of {_buySellMultiplier}");
        }
        else
        {
            Console.WriteLine($"Hello! My name is {_name} the Rouge, and I want to sell my {_ownedItem.GetItemName()} using a multiplier of {_buySellMultiplier}");
        }

    }
}