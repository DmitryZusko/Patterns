namespace ChainOfResponsibility
{
    /// <summary>
    /// At first look seems like Chain of Responsibility pattern solves the same problem as polymorphism do - changes behavioral depends
    /// on type of object. But not always we can join several classes into one inheritance tree, sometimes clien can recieve 
    /// very different objects in one place. So, here comes CoR - we create multiple classes, that work with one and only one type.
    /// Link this «handlers» into a chain and gives object to each handler one by one. Handler should check if given object
    /// matches type that handler handle - if false, object go further; if true - the chain ends. Of cause we should implement 
    /// pattern through interfaces. 
    /// Main problem occures when we recieve an object of type, that don't handle by any handle. For this case we should also 
    /// create default handler and track that it will be called if no other handler does it job (or just use overrite method 
    /// in base class).
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            var intHandler = new IntHandler();
            var floatHandler = new FloatHandler();
            var stringHandler = new StringHandler();

            intHandler
                .SetNext(floatHandler)
                .SetNext(stringHandler);


            while (true)
            {
                Console.WriteLine("Please, enter any information:");
                intHandler.Handle(Console.ReadLine());
            }
        }
    }
}