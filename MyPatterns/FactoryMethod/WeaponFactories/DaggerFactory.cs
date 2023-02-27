using FactoryMethod.Weapons;

namespace FactoryMethod.WeaponFactories
{
    public class DaggerFactory : IWeaponFactory
    {
        public IWeapon GetWeapon()
        {
            return new Dagger { Damage = 5, WeaponType = nameof(Dagger) };
        }
    }
}
