using AbstractFactory.Items;

namespace AbstractFactory.AbstractFactory
{
    internal class EasyFactory : EquipmentFactoryBase
    {
        public override IArmor CreateArmor()
        {
            return new WoodenPlate();
        }

        public override IShield CreateShield()
        {
            return new WoodenShield();
        }

        public override IWeapon CreateWeapon()
        {
            return new WoodenDagger();
        }
    }
}
