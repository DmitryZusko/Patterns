namespace Visitor
{
    /// <summary>
    /// Visitor pattern can be useful when for some reason we can't or don't want put certain behavioral
    /// into class or a tree of classes. So, all we need to do, is to add <c>Accept</c> method to all
    /// classes and create a brand new <c>Visitor</c> with desired method overriden for every class.
    /// The only problem is every new visitor requires as many methods as classes already exist end 
    /// every class should be modified with <c>Accept</c> method.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            var badClass = new BadClass { Field = -5 };
            var goodClass = new GoodClass { Field = 5 };

            var firstVisitor = new FirstVisitor();
            var secondVisitor = new SecondVisitor();

            badClass.Accept(firstVisitor);
            badClass.Accept(secondVisitor);

            goodClass.Accept(firstVisitor);
            goodClass.Accept(secondVisitor);
        }
    }
}