namespace Decorator
{
    public class TargetSublect : ISubject
    {
        private int _firstNumber;
        private int _secondNumber;
        public int FirstNumber { set => _firstNumber = value; }
        public int SecondNumber { set => _secondNumber = value; }

        public int GetFirstNumber()
        {
            return _firstNumber;
        }

        public int GetSecondNumber()
        {
            return _secondNumber;
        }

        public int ReturnSum()
        {
            return _firstNumber + _secondNumber;
        }
    }
}