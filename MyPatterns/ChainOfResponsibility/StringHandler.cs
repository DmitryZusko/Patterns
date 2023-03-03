namespace ChainOfResponsibility
{
    public class StringHandler : HandlerBase
    {
        public override void Handle(string request)
        {
            if (request.Length < 1)
            {
                _nextHandler?.Handle(request);
                return;
            }
            Console.WriteLine("You've entered a string!");
        }
    }
}