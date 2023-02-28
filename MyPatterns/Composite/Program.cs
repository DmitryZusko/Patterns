using System.Runtime.CompilerServices;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var duckPack1 = new DuckPack( new List<IDuck> { new Duck(), new Duck(), new Duck(), new Duck() });
            var duckPack2 = new DuckPack( new List<IDuck> { new Duck(), new Duck(), duckPack1, new Duck() });
            var duckPack3 = new DuckPack(new List<IDuck> { duckPack2, new Duck() });

            var duck = new Duck();

            duck.SayQuack();
            Console.WriteLine();
            duckPack1.SayQuack();
            Console.WriteLine();
            duckPack2.SayQuack();
            Console.WriteLine();
            duckPack3.SayQuack();
            Console.WriteLine("\nDuck should scream 20 times!");
        }
    }
}