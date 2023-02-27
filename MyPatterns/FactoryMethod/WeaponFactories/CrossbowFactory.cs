using FactoryMethod.Weapons;

namespace FactoryMethod.WeaponFactories
{
    public class CrossbowFactory : IWeaponFactory
    {
        public IWeapon GetWeapon()
        {
            return new Crossbow { Damage = 12, WeaponType = nameof(Crossbow) };
        }
    }
}
