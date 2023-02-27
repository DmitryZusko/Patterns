using FactoryMethod.WeaponFactories;
using FactoryMethod.Weapons;

namespace FactoryMethod
{
    public class Chest
    {
        public IWeapon Weapon { get; protected set; }

        public void CreateChest()
        {
            var rnd = new Random().Next(1, 4);
            switch (rnd)
            {
                case 1:
                    Weapon = new DaggerFactory().GetWeapon();
                    break;
                case 2:
                    Weapon = new MaceFactory().GetWeapon();
                    break;
                case 3:
                    Weapon = new CrossbowFactory().GetWeapon();
                    break;
                default:
                    break;
            }
            Console.WriteLine($"When you've opened a chest, there was a {Weapon.WeaponType}.");
            Console.WriteLine("Do you want to equip it?");
        }
    }
}