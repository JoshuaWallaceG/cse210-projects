public class Relic : Item{

    public struct RelicType
    {
        public string _relicType;
        public int _baseValue; 

        public RelicType(string relicType, int baseValue){
            _relicType = relicType;
            _baseValue = baseValue;
        }
    };

    private static List<RelicType> RelicTypes = new List<RelicType>
    {
        new RelicType("Obsidian Crystal", 100),
        new RelicType("Glass Orb", 90),
        new RelicType("Gem Amulet", 80),
        new RelicType("Rune Stone", 70),
        new RelicType("Bone Tailsman", 60),
        new RelicType("Leather Charm", 50)
    };


    public static Relic GenerateRandomRelic()
    {
        RelicType randomType = RelicTypes[Game.Random.Next(RelicTypes.Count)];
        ItemAttribute randomAttribute = Attributes[Game.Random.Next(Attributes.Count)];
        return new Relic(randomAttribute, HeroType.Mage, randomType);
    }

    RelicType _relicType;

    public Relic(ItemAttribute attribute, HeroType preferredHero, RelicType relicType) : base(attribute, preferredHero)
    {
        _relicType = relicType;
    }


    public override string GetItemName()
    {
        return $"{_attribute._attributeName} {_relicType._relicType}";
    }
    
    public override string GetItemType()
    {
        return $"{_relicType._relicType}";
    }

    public override int GetItemTrueBaseValue()
    {
        return _relicType._baseValue;
    }

    public override int GetItemCalculatedBaseValue()
    {
        double baseValueCalc = _attribute._attributeMultiplier * _relicType._baseValue;
        return (int)Math.Floor(baseValueCalc);
    }
    
}