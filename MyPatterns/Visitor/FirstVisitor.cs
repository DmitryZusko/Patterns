namespace Visitor
{
    public class FirstVisitor : IVisitor
    {
        public void VisitGoodClass(ISomeClass someclass)
        {
            Console.WriteLine($"Visiting a good class with field {someclass.Field}");
        }

        public void VisitBadClass(ISomeClass someclass)
        {
            Console.WriteLine($"Visiting a bad class with field {someclass.Field}");
        }
    }
}