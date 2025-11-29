public abstract class Mage : Hero
{
    public Mage(string name,  HeroType heroType, TradeType tradeType, Item ownedItem, double buySellMultiplier) 
        : base(name, heroType, tradeType, ownedItem, buySellMultiplier){}
}