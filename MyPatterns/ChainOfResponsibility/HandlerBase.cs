namespace ChainOfResponsibility
{
    public abstract class HandlerBase : IHandler
    {
        protected IHandler _nextHandler;
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return _nextHandler;
        }
        public abstract void Handle(string request);
    }
}