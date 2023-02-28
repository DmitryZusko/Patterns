namespace Proxy
{
    public class Targetsubject : ISubject
    {
        public void DoSomething()
        {
            Console.WriteLine("Target subject is doing something");
        }
    }
}