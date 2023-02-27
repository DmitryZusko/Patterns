namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = Singleton.GetInstance("First");
            var singleton2 = Singleton.GetInstance("Second");

            Console.WriteLine($"{singleton1.GetName()}");
            Console.WriteLine($"{singleton2.GetName()}");
            Console.WriteLine($"{singleton1 == singleton2}");

            Console.ReadLine();
        }
    }
}