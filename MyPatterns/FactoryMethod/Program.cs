namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your name:");
            var name = Console.ReadLine();

            var player = new Player { Level = 1, Name = name, Weapon = null };
            var chest = new Chest();
            while (true)
            {
                chest.CreateChest();
                var answer = Console.ReadLine();
                if (answer == "y")
                {
                    player.Weapon = chest.Weapon;
                }
                Console.WriteLine($"Your current weapon is {player.GetWeapon()}");
            }
        }
    }
}