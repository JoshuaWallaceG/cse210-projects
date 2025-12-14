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

    public override void LeaveShop(bool performedTrade)
    {
        if (performedTrade)
        {
            switch(Game.Random.Next(0, 2))
            {
                case 0:
                Animation.Typing(2, _name);
                Console.WriteLine($"\"A strong trade! The realm thanks you! Take care, shopkeeper!\"");
                break;
                case 1:
                Animation.Typing(2, _name);
                Console.WriteLine($"\"Well bargained, shopkeeper! This will see me through the fight! Cheers!\"");
                break;
            }
        }
        else
        {
            switch(Game.Random.Next(0, 2)){
                case 0:
                Animation.Typing(2, _name);
                Console.WriteLine($"\"I shall march on without it. The war waits for no one! Godspeed!\"");
                break;
                case 1:
                Animation.Typing(2, _name);
                Console.WriteLine($"\"I suppose then it was not meant to be today! Until next time!\"");
                break;
            }
        }
        Console.WriteLine($"{_name} the Warrior marches out of your shop.");
    }

    public override void PreferredItemOfferDialouge(Item wantedItem, int buyingPrice)
    {
        Animation.Typing(2, _name);
        Console.WriteLine("\"Magnificant! You have a truly well-stocked store of defensive goods.\"");
        Animation.Typing(2, _name);
        Console.WriteLine($"\"Your {wantedItem.GetItemName()} will be perfect in defenese of the kingdom.\"");
        Animation.Typing(3, _name);
        Console.WriteLine($"\"Shopkeeper, will you accept ${buyingPrice} for this fine piece?\"");
    }
    
    public override void NonPreferredItemOfferDialouge(Item wantedItem, int buyingPrice)
    {
        Animation.Typing(2, _name);
        Console.WriteLine("\"Shopkeeper! I don't see any armors for war in your wares currently. What a shame.\"");
        Animation.Typing(2, _name);
        Console.WriteLine($"\"But this {wantedItem.GetItemName()} could still serve me well...\"");
        Animation.Typing(3, _name);
        Console.WriteLine($"\"I'll buy it for ${buyingPrice}! Will you accept my offer?\"");
    }

    public override void EmptyInventoryDialogue()
    {
        switch(Game.Random.Next(0, 2))
        {
            case 0:
            Animation.Typing(2, _name);
            Console.WriteLine($"\"Wow! I wanted to buy, but your shelves stand empty, shopkeeper! What a shame.\"");
            break;
            case 1:
            Animation.Typing(2, _name);
            Console.WriteLine($"\"Err, an empty stockhouse will not stop the war... but it does indeed stop this purchase!\"");
            break;
        }
    }

    public override void ItemSellOfferDialouge(Item ownedItem, int sellingPrice)
    {
        Animation.Typing(2, _name);
        Console.WriteLine("\"I bring sturdy gear to sell, earned through honest effort and battle!\"");
        Animation.Typing(2, _name);
        Console.WriteLine($"\"Behold, my {ownedItem.GetItemName()}! It stands as still reliable and battle-ready.\"");
        Animation.Typing(3, _name);
        Console.WriteLine($"\"I believe ${sellingPrice} is a fair price! Do you accept?\"");
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