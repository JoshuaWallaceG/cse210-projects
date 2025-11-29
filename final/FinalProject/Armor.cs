public class Armor : Item{

    public struct ArmorType
    {
        public string _armorName;
        public int _baseValue; 

        public ArmorType(string armorName, int baseValue){
            _armorName = armorName;
            _baseValue = baseValue;
        }
    };

    private static List<ArmorType> ArmorTypes = new List<ArmorType>
    {
        new ArmorType("Breastplate", 100),
        new ArmorType("Helmet", 90),
        new ArmorType("Vest", 80),
        new ArmorType("Shield", 70),
        new ArmorType("Cloak", 60),
        new ArmorType("Hood", 50)
    };


    public static Armor GenerateRandomArmor()
    {
        ArmorType randomType = ArmorTypes[Game.Random.Next(ArmorTypes.Count)];
        ItemAttribute randomAttribute = Attributes[Game.Random.Next(Attributes.Count)];
        return new Armor(randomAttribute, HeroType.Warrior, randomType);
    }

    ArmorType _armorType;

    public Armor(ItemAttribute attribute, HeroType preferredHero, ArmorType armorType) : base(attribute, preferredHero)
    {
        _armorType = armorType;
    }


    public override string GetItemName()
    {
        return $"{_attribute._attributeName} {_armorType._armorName}";
    }
    
    public override int GetItemTrueBaseValue()
    {
        return _armorType._baseValue;
    }

    public override int GetItemCalculatedBaseValue()
    {
        double baseValueCalc = _attribute._attributeMultiplier * _armorType._baseValue;
        return (int)Math.Floor(baseValueCalc);
    }
    
}