namespace AbstractFactory.Items
{
    internal class MetalShield : IShield
    {
        public string Name => nameof(MetalShield);

        public void Protect()
        {
            Console.WriteLine("Protect with MetalShield");
        }
    }
}
