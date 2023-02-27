using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Weapons
{
    public class Dagger : IWeapon
    {
        public string WeaponType { get; set; }
        public int Damage { get; set; }

        public void Attack()
        {
            Console.WriteLine("Attack with a dagger");
        }

        public void Backstab()
        {
            Console.WriteLine("Backstab with a dagger");
        }
    }
}
