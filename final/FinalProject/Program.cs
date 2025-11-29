using System;

class Program
{
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
