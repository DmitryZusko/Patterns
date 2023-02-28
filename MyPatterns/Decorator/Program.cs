namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var target = new TargetSublect { FirstNumber = 1, SecondNumber = 2 };
            Console.WriteLine(target.ReturnSum());

            var multiDecor = new MultiplicationDecorator(target);
            Console.WriteLine(multiDecor.ReturnSum());
            Console.WriteLine(multiDecor.ReturnMultiplication());

            var substrDecor = new SubstractionDecorator(multiDecor);
            Console.WriteLine(substrDecor.ReturnSum());
            Console.WriteLine(substrDecor.ReturnSubstraction());
        }
    }
}