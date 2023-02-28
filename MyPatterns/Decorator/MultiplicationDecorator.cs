namespace Decorator
{
    public class MultiplicationDecorator : SubjectDecoratorBase
    {
        public MultiplicationDecorator(ISubject target) : base(target) { }

        public int ReturnMultiplication()
        {
            return GetFirstNumber() * GetSecondNumber();
        }
    }
}