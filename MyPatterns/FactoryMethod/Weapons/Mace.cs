using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Weapons
{
    public class Mace : IWeapon
    {
        public string WeaponType { get; set; }

        public int Damage { get; set; }

        public void Attack()
        {
            Console.WriteLine("Attack with a mace");
        }

        public void CrushSkull()
        {
            Console.WriteLine("Crush skull with a mace");
        }
    }
}
