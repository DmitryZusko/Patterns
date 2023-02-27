namespace FactoryMethod.Weapons
{
    public interface IWeapon
    {
        public string WeaponType { get; set; }

        public int Damage { get; set; }

        public void Attack();
    }
}