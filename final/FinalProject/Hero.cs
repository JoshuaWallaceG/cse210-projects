public abstract class Hero{

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

        //Determining if our hero will have the TradeType of Buying or Selling. 
        // -> If selling, we generate a random item. If buying, there is no need for a held item
        Item randomItem;
        TradeType randomTradeType;
        if(Game.Random.Next(0, 2) == 0)
        {
            //Selling
            randomItem = Item.GenerateRandomItem();
            randomTradeType = TradeType.Selling;
        }
        else
        {
            //Buying
            randomItem = null;
            randomTradeType = TradeType.Buying;
        }

        //Rolls to see what type of hero to make, and then uses the previously generated random variables to create it
        switch(Game.Random.Next(0, 3))
        {
            case 0:
            return new Warrior(randomName, randomTradeType, randomItem, randomBuySellMultiplier);

            case 1:
            return new Rouge(randomName, randomTradeType, randomItem, randomBuySellMultiplier);

            case 2:
            return new Mage(randomName, randomTradeType, randomItem, randomBuySellMultiplier);

            default:
            return new Warrior("Glitched Bob", TradeType.Buying, null, 1.0);
        }
    }

    protected string _name;
    protected HeroType _heroType;
    protected Item _ownedItem;
    protected double _buySellMultiplier;
    protected TradeType _tradeType;
    protected double _itemMatchMultiplier = 1.25;

    protected Hero(string name, TradeType tradeType, Item ownedItem, double buySellMultiplier)
    {
        _name = name;
        _tradeType = tradeType;
        _ownedItem = ownedItem;
        _buySellMultiplier = buySellMultiplier;
    }

    public abstract void EnterShop();
    public abstract void LeaveShop();
    public virtual void BuyOffer(List<Item> playerInventory){}
    public abstract void SellOffer();
    public TradeType GetTradeType()
    {
        return _tradeType;
    }
    public abstract void DebugPresentSelf();
}