namespace AbstractFactory.Items
{
    internal class WoodenShield : IShield
    {
        public string Name => nameof(WoodenShield);

        public void Protect()
        {
            Console.WriteLine("Protect with wooden shield");
        }
    }
}
