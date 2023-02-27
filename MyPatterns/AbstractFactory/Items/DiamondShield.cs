namespace AbstractFactory.Items
{
    internal class DiamondShield : IShield
    {
        public string Name => nameof(DiamondShield);

        public void Protect()
        {
            Console.WriteLine("Protect with DiamondShield");
        }
    }
}
