namespace Builder.Builders
{
    /// <summary>
    /// Maybe this example can be more consisten with inheritance and some other patterns but not with Builder pattern.
    /// However, this one is very useful in situations like creating complex and hard to manage by yourself classes,
    /// creating one fields before another (or only a couple of them) and when client code shouldn't care 
    /// about the real type of creating instance (low coupling). 
    /// So, the main idea of Biulder pattern is to move all creating logic into builder and split it into 
    /// few methods that can be accesed through the client or helping director class. Director class 
    /// could be something like an adapter and work with builder through interface, so it can recieve 
    /// different builder types.
    /// </summary>
    public interface IBuilder
    {
        public IBuilder BuildFloor();

        public IBuilder BuildWalls();

        public IBuilder BuildRoof();

        public IBuilder BuildGarden();

        public IBuilder BuildGarage();

        public House RetrieveHouse();
    }
}