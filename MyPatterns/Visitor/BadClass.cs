namespace Visitor
{
    public class BadClass : ISomeClass
    {
        public int Field { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitBadClass(this);
        }

        public void DoSmth()
        {
            Console.WriteLine("I'm a baaaaaad class :<");
        }
    }
}