using FactoryMethod.Weapons;

namespace FactoryMethod
{
    public class Player
    {
        public int Level { get; set; }
        public string Name { get; set; }
        public IWeapon Weapon { get; set; }

        public string GetWeapon()
        {
            return Weapon.WeaponType;
        }
    }
}