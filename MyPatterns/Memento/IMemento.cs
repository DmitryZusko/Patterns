namespace Memento
{
    public interface IMemento
    {
        public void Restore(IVeryImportant origin);

        public string GetFields();
    }
}