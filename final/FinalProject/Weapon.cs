public class Weapon : Item{

    WeaponType _weaponType;

    public struct WeaponType
    {
        public string _weaponType;
        public int _baseValue; 

        public WeaponType(string weaponType, int baseValue){
            _weaponType = weaponType;
            _baseValue = baseValue;
        }
    };

    private static List<WeaponType> WeaponTypes = new List<WeaponType>
    {
        new WeaponType("Greatsword", 100),
        new WeaponType("Warhammer", 90),
        new WeaponType("Spear", 80),
        new WeaponType("Mace", 70),
        new WeaponType("Dagger", 60),
        new WeaponType("Club", 50)
    };

    public static Weapon GenerateRandomWeapon()
    {
        WeaponType randomType = WeaponTypes[Game.Random.Next(WeaponTypes.Count)];
        ItemAttribute randomAttribute = Attributes[Game.Random.Next(Attributes.Count)];
        return new Weapon(randomAttribute, HeroType.Rouge, randomType);
    }

    public Weapon(ItemAttribute attribute, HeroType preferredHero, WeaponType weaponType) : base(attribute, preferredHero)
    {
        _weaponType = weaponType;
    }

    public override string GetItemName()
    {
        return $"{_attribute._attributeName} {_weaponType._weaponType}";
    }
    
    public override string GetItemType()
    {
        return $"{_weaponType._weaponType}";
    }

    public override int GetItemTrueBaseValue()
    {
        return _weaponType._baseValue;
    }

    public override int GetItemCalculatedBaseValue()
    {
        double baseValueCalc = _attribute._attributeMultiplier * _weaponType._baseValue;
        return (int)Math.Floor(baseValueCalc);
    }
    
}