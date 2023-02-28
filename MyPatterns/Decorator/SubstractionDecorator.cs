namespace Decorator
{
    public class SubstractionDecorator : SubjectDecoratorBase
    {

        public SubstractionDecorator(ISubject target) : base(target) { }

        public int ReturnSubstraction()
        {
            return GetFirstNumber() - GetSecondNumber();
        }
    }
}