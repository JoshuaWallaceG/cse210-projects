public class Mage : Hero
{
    public Mage(string name, TradeType tradeType, Item ownedItem, double buySellMultiplier) 
        : base(name, tradeType, ownedItem, buySellMultiplier)
    {
        _heroType = HeroType.Mage;
    }

    public override void EnterShop()
    {
        Console.WriteLine($"{_name} the Mage visits your shop!");
        switch(Game.Random.Next(0, 3))
        {
            case 0:
            Animation.Typing(2, _name);
            Console.WriteLine($"\"Good day. I hope that your day has given you tranquility thus far.\"");
            break;
            case 1:
            Animation.Typing(2, _name);
            Console.WriteLine($"\"Hello again. I hope your shelves have something… suitable.\"");
            break;
            case 2:
            Animation.Typing(2, _name);
            Console.WriteLine($"\"Shopkeeper, may I browse a moment? I promise not to disturb your order.\"");
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
                Console.WriteLine($"\"A fair exchange. You have my thanks. It's been a pleasure.\"");
                break;
                case 1:
                Animation.Typing(2, _name);
                Console.WriteLine($"\"Excellent. May this trade benefit us both. Goodbye.\"");
                break;
            }
        }
        else
        {
            switch(Game.Random.Next(0, 2)){
                case 0:
                Animation.Typing(2, _name);
                Console.WriteLine($"\"Very well. I will continue my search elsewhere. Farewell.\"");
                break;
                case 1:
                Animation.Typing(2, _name);
                Console.WriteLine($"\"It seems we could not reach an agreement today. No matter. Adieu.\"");
                break;
            }
        }

        Console.WriteLine($"{_name} the Mage leaves your shop.");
    }

    public override void PreferredItemOfferDialouge(Item wantedItem, int buyingPrice)
    {
        Animation.Typing(2, _name);
        Console.WriteLine("\"How delightful. You have relics that can fufill my magic needs.\"");
        Animation.Typing(2, _name);
        Console.WriteLine($"\"Your {wantedItem.GetItemName()} is truly one of a kind.\"");
        Animation.Typing(3, _name);
        Console.WriteLine($"\"Do you see ${buyingPrice} as a fair price?\"");
    }

    public override void NonPreferredItemOfferDialouge(Item wantedItem, int buyingPrice)
    {
        Animation.Typing(2, _name);
        Console.WriteLine("\"Sir, you don't seem to have any relics of magic here today. How unfortunate.\"");
        Animation.Typing(2, _name);
        Console.WriteLine($"\"But I must say, this {wantedItem.GetItemName()} is still rather useful.\"");
        Animation.Typing(3, _name);
        Console.WriteLine($"\"I will offer you ${buyingPrice} for it. Would that be sufficent for you?\"");
    }

    public override void EmptyInventoryDialogue()
    {
        switch(Game.Random.Next(0, 2))
        {
            case 0:
            Animation.Typing(2, _name);
            Console.WriteLine($"\"Oh, it appears there is nothing here for purchase at the moment. A pity, but understandable.\"");
            break;
            case 1:
            Animation.Typing(2, _name);
            Console.WriteLine($"\"Hm, an empty inventory. I wanted to buy, but preparation cannot be rushed, I suppose.\"");
            break;
        }
    }

    public override void ItemSellOfferDialouge(Item ownedItem, int sellingPrice)
    {
        Animation.Typing(2, _name);
        Console.WriteLine("\"I have an item from my collection I would like to sell, should it interest you.\"");
        Animation.Typing(2, _name);
        Console.WriteLine($"\"My {ownedItem.GetItemName()} has served its purpose, but no longer suits my needs.\"");
        Animation.Typing(3, _name);
        Console.WriteLine($"\"I am seeking ${sellingPrice} in exchange. Does that seem reasonable?\"");
    }


    public override void DebugPresentSelf()
    {
        if(_tradeType == TradeType.Buying)
        {
            Console.WriteLine($"Hello! My name is {_name} the Mage, and I want to buy anything using a multiplier of {_buySellMultiplier}\"");
        }
        else
        {
            Console.WriteLine($"Hello! My name is {_name} the Mage, and I want to sell my {_ownedItem.GetItemName()} using a multiplier of {_buySellMultiplier}");
        }

    }
}