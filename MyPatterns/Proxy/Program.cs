namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var targetSubject = new Targetsubject();
            targetSubject.DoSomething();

            var proxy = new Proxy(targetSubject);
            proxy.DoSomething();
        }
    }
}