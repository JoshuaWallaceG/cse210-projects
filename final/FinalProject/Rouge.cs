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

    public override void LeaveShop(bool performedTrade)
    {
        if (performedTrade)
        {
            switch(Game.Random.Next(0, 2))
            {
                case 0:
                Animation.Typing(2, _name);
                Console.WriteLine($"\"Pleasure doing business with someone who knows a good deal. Peace!\"");
                break;
                case 1:
                Animation.Typing(2, _name);
                Console.WriteLine($"\"See? Easy money. For both of us. Catch you later!\"");
                break;
            }
        }
        else
        {
            switch(Game.Random.Next(0, 2)){
                case 0:
                Animation.Typing(2, _name);
                Console.WriteLine($"\"Guess we're both walking away empty-handed. Bummer. See ya'.\"");
                break;
                case 1:
                Animation.Typing(2, _name);
                Console.WriteLine($"\"Eh, it was worth a shot. I'll live. Sayonara, shopkeep'!\"");
                break;
            }
        }
        Console.WriteLine($"{_name} the Rouge sneaks out of your shop.");
    }

    public override void PreferredItemOfferDialouge(Item wantedItem, int buyingPrice)
    {
        Animation.Typing(2, _name);
        Console.WriteLine("\"Oh hey, you got some good stuff for slicing in here!\"");
        Animation.Typing(2, _name);
        Console.WriteLine($"\"This {wantedItem.GetItemName()} here is really speaking my language.\"");
        Animation.Typing(3, _name);
        Console.WriteLine($"\"Tell me keep', would you take ${buyingPrice} for this guy?\"");
    }

    public override void NonPreferredItemOfferDialouge(Item wantedItem, int buyingPrice)
    {
        Animation.Typing(2, _name);
        Console.WriteLine("\"Aw man, you don't got anything that can stab in here. Huge bummer.\"");
        Animation.Typing(2, _name);
        Console.WriteLine($"\"But honestly, this {wantedItem.GetItemName()} isn't half bad...\"");
        Animation.Typing(3, _name);
        Console.WriteLine($"\"I'll take it off your hands for ${buyingPrice}. What do you say?\"");
    }

    public override void EmptyInventoryDialogue()
    {
        switch(Game.Random.Next(0, 2))
        {
            case 0:
            Animation.Typing(2, _name);
            Console.WriteLine($"\"Huh. Empty shelves. I was looking to buy, but I guess I showed up on inventory day.\"");
            break;
            case 1:
            Animation.Typing(2, _name);
            Console.WriteLine($"\"Wow, this place is baren. Not even one dusty trinket to buy? That's impressive.\"");
            break;
        }
    }

    public override void ItemSellOfferDialouge(Item ownedItem, int sellingPrice)
    {
        Animation.Typing(2, _name);
        Console.WriteLine("\"Alright don't ask me how I got it, but I got something I'd like to sell.\"");
        Animation.Typing(2, _name);
        Console.WriteLine($"\"I think that my {ownedItem.GetItemName()} would fit your shelves nicely.\"");
        Animation.Typing(3, _name);
        Console.WriteLine($"\"I'm thinking ${sellingPrice}. What do you say?\"");
    }

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