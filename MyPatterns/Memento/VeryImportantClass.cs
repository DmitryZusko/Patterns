namespace Memento
{
    public class VeryImportantClass : IVeryImportant
    {
        public int PublicField { get; set; }

        private int _privateField = 5;

        public IMemento MakeSnapshot()
        {
            return new Memento(PublicField, _privateField);
        }

        public void Restore(int field1, int field2)
        {
            PublicField = field1;
            _privateField = field2;

        }
    }
}