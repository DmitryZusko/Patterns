namespace AbstractFactory.Items
{
    internal class MetalSword : IWeapon
    {
        public string Name => nameof(MetalSword);

        public void Attack()
        {
            Console.WriteLine("Attack with metal sword");
        }
    }
}
