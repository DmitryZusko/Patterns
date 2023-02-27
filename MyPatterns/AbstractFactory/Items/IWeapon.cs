namespace AbstractFactory.Items
{
    public interface IWeapon
    {
        public string Name { get; }
        public void Attack();
    }
}
