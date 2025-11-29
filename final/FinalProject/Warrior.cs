public class Warrior : Hero
{
    public Warrior(string name,  HeroType heroType, TradeType tradeType, Item ownedItem, double buySellMultiplier) 
        : base(name, heroType, tradeType, ownedItem, buySellMultiplier){}

    public override void BuyOffer()
    {
        
    }

    public override void SellOffer()
    {
    }

    public override void LeaveShop()
    {
        
        Console.WriteLine($"{_name} the Warrior storms into the ");
    }

    public override void EnterShop()
    {
        
    }

    public override void DebugPresentSelf()
    {
        if(_tradeType == TradeType.Buying)
        {
            Console.WriteLine($"Hello! My name is {_name} the Warrior, and I want ot buy anything w/ a multiplier of {_buySellMultiplier}");
        }
        else
        {
            Console.WriteLine($"Hello! My name is {_name} the Warrior, and I want to sell my {_ownedItem.GetItemName()} w/ a multiplier of {_buySellMultiplier}");
        }

    }
}