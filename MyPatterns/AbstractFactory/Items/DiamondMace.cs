namespace AbstractFactory.Items
{
    internal class DiamondMace : IWeapon
    {
        public string Name => nameof(DiamondMace);

        public void Attack()
        {
            Console.WriteLine("Attack with diamond mace");
        }
    }
}
