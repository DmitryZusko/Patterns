namespace ChainOfResponsibility
{
    public interface IHandler
    {
        public IHandler SetNext(IHandler handler);

        public void Handle(string request);
    }
}