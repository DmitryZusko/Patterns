namespace Proxy
{
    public class Proxy : ISubject
    {
        private ISubject _targetSubject;

        public Proxy(ISubject targetSubject)
        {
            _targetSubject = targetSubject;
        }

        public void DoSomething()
        {
            Console.WriteLine("Proxy is doing it's stuff");
            _targetSubject.DoSomething();
        }
    }
}