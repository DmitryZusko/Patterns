using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Weapons
{
    public class Crossbow : IWeapon
    {
        public string WeaponType { get; set; }

        public int Damage { get; set; }

        public void Attack()
        {
            Console.WriteLine("Strike with a crossbow");
        }

        public void MeleeAttack()
        {
            Console.WriteLine("Attack with a crossbow in a melee");
        }
    }
}
