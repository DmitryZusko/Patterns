namespace TemplateMethod
{
    public abstract class ExampleClass : IExampleClass
    {
        public void TemplateMethod()
        {
            FirstBaseMethod();
            FirstChildMethod();
            FirstHook();
            SecondChildMethod();
            SecondBaseMethod();
            ThirdChildMethod();
        }
        private void FirstBaseMethod()
        {
            Console.WriteLine("First base method");
        }


        private void SecondBaseMethod()
        {
            Console.WriteLine("Second base method");
        }


        protected virtual void FirstHook() { }

        protected abstract void FirstChildMethod();
        protected abstract void SecondChildMethod();
        protected abstract void ThirdChildMethod();

    }
}