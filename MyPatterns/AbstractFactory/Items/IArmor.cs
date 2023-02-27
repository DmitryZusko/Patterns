namespace AbstractFactory.Items
{
    public interface IArmor
    {
        public string Name { get; }
        public void RestoreHealth();
    }
}
