namespace Decorator
{
    public class SubjectDecoratorBase : ISubject
    {
        private ISubject _target;
        public SubjectDecoratorBase(ISubject target)
        {
            _target = target;
        }

        public int ReturnSum()
        {
            return _target.ReturnSum();
        }

        public int GetFirstNumber()
        {
            return _target.GetFirstNumber();
        }

        public int GetSecondNumber()
        {
            return _target.GetSecondNumber();
        }
    }
}