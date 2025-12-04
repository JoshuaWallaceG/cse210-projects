public class Game
{
    public static Random Random = new Random();
    int playersMoney = 0;
    int currentDay = 1;

    public void Run(){

        Animation.Typing(1);

        while(currentDay < 2){
            Console.WriteLine("RANDOM HERO 1:");
            Hero randomHero = Hero.GenerateRandomHero();
            randomHero.DebugPresentSelf();
            Console.WriteLine();
            
            Console.WriteLine("RANDOM HERO 2:");
            Hero randomHero2 = Hero.GenerateRandomHero();
            randomHero2.DebugPresentSelf();
            Console.WriteLine();

            Console.WriteLine("RANDOM HERO 3:");
            Hero randomHero3 = Hero.GenerateRandomHero();
            randomHero3.DebugPresentSelf();
            Console.WriteLine();

            Console.WriteLine("BUILT BUYING HERO STEVE:");
            Hero testBuying= new Warrior("Steve", Hero.TradeType.Buying, null, 1.1);
            testBuying.DebugPresentSelf();
            Console.WriteLine();

            Console.WriteLine("BUILT SELLING HERO BILL:");
            Item testItem = Item.GenerateRandomItem();
            Hero testSelling= new Warrior("Bill", Hero.TradeType.Selling, testItem, .9);
            testSelling.DebugPresentSelf();
            Console.WriteLine();

            Console.WriteLine("RANDOM ITEM 1:");
            Item randomItem1 = Item.GenerateRandomItem();
            Console.WriteLine($"{randomItem1.GetItemName()} | ${randomItem1.GetItemTrueBaseValue()} -> ${randomItem1.GetItemCalculatedBaseValue()}");


            Console.WriteLine("RANDOM ITEM 2:");
            Item randomItem2 = Item.GenerateRandomItem();
            Console.WriteLine($"{randomItem2.GetItemName()} | ${randomItem2.GetItemTrueBaseValue()} -> ${randomItem2.GetItemCalculatedBaseValue()}");


            Console.WriteLine("RANDOM ITEM 3:");
            Item randomItem3 = Item.GenerateRandomItem();
            Console.WriteLine($"{randomItem3.GetItemName()} | ${randomItem3.GetItemTrueBaseValue()} -> ${randomItem3.GetItemCalculatedBaseValue()}");


            Console.WriteLine("RANDOM ITEM 4:");
            Item randomItem4 = Item.GenerateRandomItem();
            Console.WriteLine($"{randomItem4.GetItemName()} | ${randomItem4.GetItemTrueBaseValue()} -> ${randomItem4.GetItemCalculatedBaseValue()}");


            ++currentDay;
        }
    }
}