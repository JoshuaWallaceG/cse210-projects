public abstract class Hero{

    public enum TradeType
    {
        Buying, Selling
    }

    protected static List<string> Names = new List<string>
    {
        "Alden", "Bran", "Cedric", "Dorian", "Elias", "Faris", "Garrick", "Hale", "Jorin", "Kael",
        "Lennon", "Marek", "Nyles", "Oren", "Roderick", "Silas", "Tarin", "Vance", "Wes", "Alaric",
        "Bennett", "Corin", "Damon", "Eamon", "Finn", "Gavin", "Heath", "Ivor", "Jarek", "Kellan",
        "Luther", "Milo", "Nolan", "Orin", "Rowan", "Soren", "Theron", "Ulric", "Victor", "Warden",
        "Yorik", "Zane", "Aria", "Bryn", "Celia", "Danna", "Elora", "Fiona", "Gwen", "Hazel", "Idra",
        "Jessa", "Kira", "Lira", "Marin", "Nessa", "Olwen", "Perrin", "Quinn", "Rhea", "Selene",
        "Talia", "Una", "Vera", "Willa", "Yara", "Zara"
    };

    public static Hero GenerateRandomHero()
    {
        //Random name
        string randomName = Names[Game.Random.Next(0, Names.Count)];
    
        //Making a random double between .75 and 1.25 by getting 75-125 and dividing it by 100
        double randomBuySellMultiplier = (double)Game.Random.Next(75, 126) / 100;

        //Determining if our hero will have the TradeType of Buying or Selling. If Buying, there is no need for a held item. If selling, we generate a new one
        Item randomItem;
        TradeType randomTradeType;
                               //FIX THIS
        if(Game.Random.Next(2) == 0)
        {
            //Selling
            randomItem = Item.GenerateRandomItem();
            randomTradeType = TradeType.Selling;
        }
        else
        {
            randomItem = null;
            randomTradeType = TradeType.Buying;
        }

        //Determining our hero type. Once we have, we will have already generated all the other needed variables, and can generate the hero here
        HeroType randomHeroType;
        //switch(random.Next(3))
        switch(Game.Random.Next(0))
        {
            case 0:
            randomHeroType = HeroType.Warrior;
            return new Warrior(randomName, randomHeroType, randomTradeType, randomItem, randomBuySellMultiplier);

            case 1:
            randomHeroType = HeroType.Mage;
            return new Warrior(randomName, randomHeroType, randomTradeType, randomItem, randomBuySellMultiplier); //FIX THIS

            case 2:
            randomHeroType = HeroType.Rouge;
            return new Warrior(randomName, randomHeroType, randomTradeType, randomItem, randomBuySellMultiplier); // FIX THIS

            default:
            randomHeroType = HeroType.Warrior; ///DELETE THIS ENTIRE BRANCH
            return new Warrior(randomName, randomHeroType, randomTradeType, randomItem, randomBuySellMultiplier);
        }
    }

    protected string _name;
    protected HeroType _heroType;
    protected Item _ownedItem;
    protected double _buySellMultiplier;
    protected TradeType _tradeType;

    protected Hero(string name,  HeroType heroType, TradeType tradeType, Item ownedItem, double buySellMultiplier)
    {
        _name = name;
        _heroType = heroType;
        _tradeType = tradeType;
        _ownedItem = ownedItem;
        _buySellMultiplier = buySellMultiplier;
    }

    public abstract void EnterShop();
    public abstract void LeaveShop();
    public abstract void BuyOffer();
    public abstract void SellOffer();
    public abstract void DebugPresentSelf();
}