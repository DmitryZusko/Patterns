namespace Prototype
{
    /// <summary>
    /// Prototype pattern become very useful when we have to work with complicated class constructors. 
    /// <c>IPrototype</c> interface should define <c>Clone</c>> method, that will run through all class fields and copy 
    /// them to the new instance. So, it will free programmer from doing this itself.
    /// Pattern very useful when it comes to create complicated classes in several different places,
    /// so implementing Prototype localize all code in one place. 
    /// Also <c>Clone</c>> metod can be used to define some static deferences in states between origin and clone
    /// (for example clone class should have all same fields except datetime should be earlier by to days).
    /// In C# we can use defauld interface <c>ICloneable</c>.
    /// </summary>
    public interface IPrototype
    {
        public IPrototype Clone();
    }
}