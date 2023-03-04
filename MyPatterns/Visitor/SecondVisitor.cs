namespace Visitor
{
    public class SecondVisitor : IVisitor
    {
        public void VisitBadClass(ISomeClass someclass)
        {
            Console.WriteLine("Visiting a bad class and calling a method");
            someclass.DoSmth();
        }

        public void VisitGoodClass(ISomeClass someclass)
        {
            Console.WriteLine("Visiting a good class and calling a method");
            someclass.DoSmth();
        }
    }
}