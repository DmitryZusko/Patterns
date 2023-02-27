using AbstractFactory.Items;

namespace AbstractFactory
{
    public class Player
    {
        public IWeapon Weapon{ get; set; }
        public IArmor Armor { get; set; }
        public IShield Shield { get; set; }
    }
}