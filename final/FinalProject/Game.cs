public class Game
{
    public static Random Random = new Random();
    int playersMoney = 0;
    int currentDay = 1;

    public void Run(){

        Animation.Typing(1);

        while(currentDay < 15){
            Item testItem = Armor.GenerateRandomArmor();
            Console.WriteLine($"{testItem.GetItemName()} | ${testItem.GetItemTrueBaseValue()} -> ${testItem.GetItemCalculatedBaseValue()}");
            Hero testHero = Hero.GenerateRandomHero();
            testHero.DebugPresentSelf();

            ++currentDay;
        }
    }
}