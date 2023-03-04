namespace Memento
{
    public class Memento : IMemento
    {
        private int _publicField;
        private int _privateField;

        public Memento(int field1, int field2)
        {
            _publicField = field1;
            _privateField = field2;
        }

        public string GetFields()
        {
            return $"{_publicField}, {_privateField}";
        }

        public void Restore(IVeryImportant origin)
        {
            origin.Restore(_publicField, _privateField);
        }
    }
}