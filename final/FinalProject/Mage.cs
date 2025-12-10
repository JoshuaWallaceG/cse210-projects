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

    public override void BuyOffer(List<Item> playerInventory)
    {
        int preferredItems = 0;
        List<Item> preferredItemsList = new List<Item>();
        Item wantedItem;
        int buyingPrice;

        foreach(Item i in playerInventory) //Finding total amount of items that the warrior likes
        {
            if(i.GetPreferredHero() == HeroType.Mage)
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
            Console.WriteLine("\"Sir, you don't seem to have any relics of magic here today. How unfortunate.\"");
            Animation.Typing(2, _name);
            Console.WriteLine($"\"But I must say, this {wantedItem.GetItemName()} is still rather useful.\"");
            Animation.Typing(3, _name);
            Console.WriteLine($"\"I will offer you ${buyingPrice} for it. Would that be sufficent for you?\"");
            Game.DisplayOfferMenu();
            Console.ReadLine();
        }
        else
        {
            wantedItem = preferredItemsList[Game.Random.Next(0, preferredItemsList.Count())];
            buyingPrice = (int)(wantedItem.GetItemCalculatedBaseValue() * _buySellMultiplier * _itemMatchMultiplier);
            Animation.Typing(2, _name);
            Console.WriteLine("\"How delightful. You have relics that can fufill my magic needs.\"");
            Animation.Typing(2, _name);
            Console.WriteLine($"\"Your {wantedItem.GetItemName()} is truly one of a kind.\"");
            Animation.Typing(3, _name);
            Console.WriteLine($"\"Do you see ${buyingPrice} as a fair price?\"");
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
            Console.WriteLine($"Hello! My name is {_name} the Mage, and I want to buy anything using a multiplier of {_buySellMultiplier}\"");
        }
        else
        {
            Console.WriteLine($"Hello! My name is {_name} the Mage, and I want to sell my {_ownedItem.GetItemName()} using a multiplier of {_buySellMultiplier}");
        }

    }
}