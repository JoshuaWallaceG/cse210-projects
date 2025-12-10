public abstract class Item{

    public struct ItemAttribute
    {
        public string _attributeName;
        public double _attributeMultiplier;

        public ItemAttribute(string attributeName, double attributeMultiplier){
            _attributeName = attributeName;
            _attributeMultiplier = attributeMultiplier;
        }

    };
    
    protected static List<ItemAttribute> Attributes = new List<ItemAttribute>
    {
        new ItemAttribute("Royal", 1.3),
        new ItemAttribute("Perfect", 1.2),
        new ItemAttribute("Sturdy", 1.1),

        new ItemAttribute("Mint", 1.05),
        new ItemAttribute("Used", 1.0),
        new ItemAttribute("Dusty", 0.95),

        new ItemAttribute("Rusty", 0.9),
        new ItemAttribute("Cursed", 0.8),
        new ItemAttribute("Broken", 0.7)
    };

    public static Item GenerateRandomItem()
    {
        switch(Game.Random.Next(0, 3))
        {
            case 0:
            return Armor.GenerateRandomArmor();
            case 1:
            return Weapon.GenerateRandomWeapon();
            case 2:
            return Relic.GenerateRandomRelic();
            default:
            return new Weapon(new ItemAttribute("Glitched", 1), HeroType.Rouge, new Weapon.WeaponType("Bug Swatter", 10));
        }
    }


    protected HeroType _preferredHero;
    protected ItemAttribute _attribute;

    protected Item(ItemAttribute attribute, HeroType preferredHero)
    {
        _attribute = attribute;
        _preferredHero = preferredHero;
    }

    public HeroType GetPreferredHero()
    {
        return _preferredHero;
    }

    public abstract string GetItemName();
    public abstract int GetItemTrueBaseValue();
    public abstract int GetItemCalculatedBaseValue();
}