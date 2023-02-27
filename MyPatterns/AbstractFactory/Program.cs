using AbstractFactory.AbstractFactory;

namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();

            while (true)
            {
                Console.WriteLine("\nPlease, select difficulty (e - easy, m - medium, h - harm)");
                var difficulty = Console.ReadKey();
                switch (difficulty.Key)
                {
                    case ConsoleKey.E:
                        new EasyFactory().GetEquipment(player);
                        break;
                    case ConsoleKey.M:
                        new MediumFactory().GetEquipment(player);
                        break;
                    case ConsoleKey.H:
                        new HardFactory().GetEquipment(player);
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"\nNow your equipment is: \n{player.Weapon.Name},\n{player.Armor.Name},\n{player.Shield.Name}");
            }
        }
    }
}