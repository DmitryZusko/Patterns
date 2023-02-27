using FactoryMethod.Weapons;

namespace FactoryMethod.WeaponFactories
{
    public class MaceFactory : IWeaponFactory
    {
        public IWeapon GetWeapon()
        {
            return new Mace { Damage = 15, WeaponType = nameof(Mace) };
        }
    }
}
