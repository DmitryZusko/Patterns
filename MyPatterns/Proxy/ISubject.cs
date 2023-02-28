namespace Proxy
{
    /// <summary>
    /// Proxy pattern is very powerful way to set new functionality in interaction between two classes.
    /// This is the technique to implement a logging, autentification, autorization, validation and other same stuff.
    /// All we need is to implement same <c>ISubject</c>> interface in our proxy, set <c>Subject</c> instance into <c>Proxy</c>
    /// and work with the last one as with the subject.
    /// A very similar implementation have pattern called Adapter. The only difference is in methods: in Proxy we do something
    /// AND delegate same method to origin class, when in Adapter we overrite/customise/expand origin logic.
    /// Proxy is a good decision when we need to inline some logic into interaction, when Adapter is a good way to adapt 
    /// exsisting logic to our logic. 
    /// There is one more pattern with a bit similar logic - Decorator. If Proxy uses same interface but create absolutely 
    /// independent class with oun logic and Adapter uses new interface that depends on already existed one, Decorator uses
    /// existed interface and represents class that expand logic of original one.
    /// </summary>
    public interface ISubject
    {
        public void DoSomething();
    }
}