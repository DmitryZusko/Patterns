namespace ChainOfResponsibility
{
    public class IntHandler : HandlerBase
    {
        public override void Handle(string request)
        {
            int number;
            if (!int.TryParse(request, out number))
            {
                _nextHandler?.Handle(request);
                return;
            }
            Console.WriteLine("You've entered an integer number!");
        }
    }
}