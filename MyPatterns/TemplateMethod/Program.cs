namespace TemplateMethod
{
    /// <summary>
    /// Template Method is a powerful tool to minimize copypaste code. If we have a bunch of classes
    /// with a similar method but few different lines, we could separate a method into a buch of 
    /// submethods and raise them up to a parrent abstract class. So child classes should overrite 
    /// only submethods, that differ from parrent logic.
    /// Also we can add some Hook methods, if we want to expand method even further. 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstChild = new SimpleChild();
            firstChild.TemplateMethod();

            Console.WriteLine();

            var secondChild = new HookedChild();
            secondChild.TemplateMethod();
        }
    }
}