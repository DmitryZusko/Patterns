namespace Memento
{
    public interface IVeryImportant
    {
        public IMemento MakeSnapshot();
        void Restore(int field1, int field2);
    }
}