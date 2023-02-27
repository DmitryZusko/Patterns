using AbstractFactory.Items;

namespace AbstractFactory.AbstractFactory
{
    internal class HardFactory : EquipmentFactoryBase
    {
        public override IArmor CreateArmor()
        {
            return new DiamondPlate();
        }

        public override IShield CreateShield()
        {
            return new DiamondShield();
        }

        public override IWeapon CreateWeapon()
        {
            return new DiamondMace();
        }
    }
}
