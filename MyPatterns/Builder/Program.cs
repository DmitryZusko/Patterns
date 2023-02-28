using Builder.Builders;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var director = new Director(new SimpleHouseBuilder());

            var primitiveHouse = director.BuildMainHouse();
            var myHouse = director.BuildHouseWithGarden();
            Console.WriteLine(primitiveHouse);
            Console.WriteLine(myHouse);

            director = new Director(new LuxuryHousBuilder());

            var normalHouse = director.BuildHouseWithGarage();
            var richHouse = director.BuildFullPackageHouse();
            Console.WriteLine(normalHouse);
            Console.WriteLine(richHouse);
        }
    }
}