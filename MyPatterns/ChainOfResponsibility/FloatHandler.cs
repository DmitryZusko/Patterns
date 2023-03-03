namespace ChainOfResponsibility
{
    public class FloatHandler : HandlerBase
    {
        public override void Handle(string request)
        {
            float number;
            if (!float.TryParse(request, out number))
            {
                _nextHandler?.Handle(request);
                return;
            }
            Console.WriteLine("You've entered a float number!");
        }
    }
}