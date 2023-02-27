using AbstractFactory.Items;

namespace AbstractFactory.AbstractFactory
{
    internal class MediumFactory : EquipmentFactoryBase
    {
        public override IArmor CreateArmor()
        {
            return new MetalPlate();
        }

        public override IShield CreateShield()
        {
            return new MetalShield();
        }

        public override IWeapon CreateWeapon()
        {
            return new MetalSword();
        }
    }
}
