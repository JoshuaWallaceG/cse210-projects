using System;

class Program
{
    //Because of how many variables that were running, I decided to put it in a seperate Game class
    static void Main(string[] args)
    {
        Game g = new Game();
        g.Run();
    }
}

public enum HeroType
{
    Warrior, Rouge, Mage
}

public enum TradeType
{
    Buying, Selling
}