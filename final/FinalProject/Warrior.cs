public class Warrior : Hero
{
    public Warrior(string name, TradeType tradeType, Item ownedItem, double buySellMultiplier) 
        : base(name, tradeType, ownedItem, buySellMultiplier)
    {
        _heroType = HeroType.Warrior;
    }

    public override void BuyOffer()
    {
        
    }

    public override void SellOffer()
    {
    }

    public override void LeaveShop()
    {
    
    }

    public override void EnterShop()
    {
        Console.WriteLine($"{_name} the Warrior storms into the ");
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