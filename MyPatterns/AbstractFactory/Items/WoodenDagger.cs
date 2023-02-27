namespace AbstractFactory.Items
{
    internal class WoodenDagger : IWeapon
    {
        public string Name => nameof(WoodenDagger);

        public void Attack()
        {
            Console.WriteLine("attack with wooden dagger");
        }
    }
}
