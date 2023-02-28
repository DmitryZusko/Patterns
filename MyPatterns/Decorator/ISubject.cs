namespace Decorator
{
    /// <summary>
    /// Actually I've said all I wanted about this pattern in the Proxy section. The only new thing will be 
    /// another way to implement it. In my code I've used Decorator to add a new method to the complete 
    /// <c>TargetSubject</c> class.
    /// Щther situation emerges when we need to add new functional to already excisting method. In this way
    /// we need to override method in every child Decorator, adding new code, and also delegate it to 
    /// previouse subject.
    /// </summary>
    public interface ISubject
    {
        public int GetFirstNumber();
        public int GetSecondNumber();
        public int ReturnSum();
    }
}