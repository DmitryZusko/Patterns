namespace Visitor
{
    public class GoodClass : ISomeClass
    {
        public int Field { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitGoodClass(this);
        }

        public void DoSmth()
        {
            Console.WriteLine("Hi, I'm a good class!");
        }
    }
}