namespace AbstractFactory.Items
{
    internal class WoodenPlate : IArmor
    {
        public string Name => nameof(WoodenPlate);

        public void RestoreHealth()
        {
            Console.WriteLine("Restore health with wooden plate");
        }
    }

    internal class MetalPlate : IArmor
    {
        public string Name => nameof(MetalPlate);

        public void RestoreHealth()
        {
            Console.WriteLine("Restore health with MetalPlate");
        }
    }

    internal class DiamondPlate : IArmor
    {
        public string Name => nameof(DiamondPlate);

        public void RestoreHealth()
        {
            Console.WriteLine("Restore health with DiamondPlate");
        }
    }
}
