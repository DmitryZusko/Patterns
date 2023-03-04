namespace TemplateMethod
{
    public class HookedChild : ExampleClass
    {
        protected override void FirstChildMethod()
        {
            Console.WriteLine("First child method from HookedChild");
        }

        protected override void SecondChildMethod()
        {
            Console.WriteLine("Second child method from HookedChild");
        }

        protected override void ThirdChildMethod()
        {
            Console.WriteLine("Third child method from HookedChild");
        }

        protected override void FirstHook()
        {
            Console.WriteLine("Hooked method from HookedChild");
        }
    }
}