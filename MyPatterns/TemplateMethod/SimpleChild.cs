namespace TemplateMethod
{
    public class SimpleChild : ExampleClass
    {
        protected override void FirstChildMethod()
        {
            Console.WriteLine("First child method from SimpleChild");
        }

        protected override void SecondChildMethod()
        {
            Console.WriteLine("Second child method from SimpleChild");
        }

        protected override void ThirdChildMethod()
        {
            Console.WriteLine("Third child method from SimpleChild");
        }
    }
}