public class Warrior : Hero
{
    public Warrior(string name, TradeType tradeType, Item ownedItem, double buySellMultiplier) 
        : base(name, tradeType, ownedItem, buySellMultiplier)
    {
        _heroType = HeroType.Warrior;
    }

    public override void EnterShop()
    {
        Console.WriteLine($"{_name} the Warrior storms into your shop!");
        switch(Game.Random.Next(0, 3))
        {
            case 0:
            Animation.Typing(2, _name);
            Console.WriteLine($"\"Ah! A fine day to trade friend, and an even finer day to prepare for battle!\"");
            break;
            case 1:
            Animation.Typing(2, _name);
            Console.WriteLine($"\"Shopkeeper! Stand proud; your wares keep our homeland strong.\"");
            break;
            case 2:
            Animation.Typing(2, _name);
            Console.WriteLine($"\"Glory to the kingdom! Now, what have you got for a soldier today?\"");
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
            if(i.GetPreferredHero() == HeroType.Warrior)
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
            Console.WriteLine("\"Shopkeeper! I don't see any armors for war in your wares currently. What a shame.\"");
            Animation.Typing(2, _name);
            Console.WriteLine($"\"But this {wantedItem.GetItemName()} could still serve me well...\"");
            Animation.Typing(3, _name);
            Console.WriteLine($"\"I'll buy it for ${buyingPrice}! Will you accept my offer?\"");
            Game.DisplayOfferMenu();
            Console.ReadLine();
        }
        else
        {
            wantedItem = preferredItemsList[Game.Random.Next(0, preferredItemsList.Count())];
            buyingPrice = (int)(wantedItem.GetItemCalculatedBaseValue() * _buySellMultiplier * _itemMatchMultiplier);
            Animation.Typing(2, _name);
            Console.WriteLine("\"Magnificant! You have a truly well-stocked store of defensive goods.\"");
            Animation.Typing(2, _name);
            Console.WriteLine($"\"Your {wantedItem.GetItemName()} will be perfect in defenese of the kingdom.\"");
            Animation.Typing(3, _name);
            Console.WriteLine($"\"Shopkeeper, will you accept ${buyingPrice} for this fine piece?\"");
            Game.DisplayOfferMenu();
        }
    }

    public override void SellOffer()
    {
    }

    public override void LeaveShop()
    {
    
    }

    public override void DebugPresentSelf()
    {
        if(_tradeType == TradeType.Buying)
        {
            Console.WriteLine($"Hello! My name is {_name} the Warrior, and I want to buy anything using a multiplier of {_buySellMultiplier}");
        }
        else
        {
            Console.WriteLine($"Hello! My name is {_name} the Warrior, and I want to sell my {_ownedItem.GetItemName()} using a multiplier of {_buySellMultiplier}");
        }

    }
}