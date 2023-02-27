using AbstractFactory.Items;

namespace AbstractFactory.AbstractFactory
{
    internal abstract class EquipmentFactoryBase : IEquipmentFactory
    {
        public void GetEquipment(Player player)
        {
            player.Weapon = CreateWeapon();
            player.Armor = CreateArmor();
            player.Shield = CreateShield();
        }

        public abstract IArmor CreateArmor();

        public abstract IShield CreateShield();

        public abstract IWeapon CreateWeapon();
    }
}
