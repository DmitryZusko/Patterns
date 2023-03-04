namespace Visitor
{
    public interface ISomeClass
    {
        public int Field { get; set; }
        public void Accept(IVisitor visitor);
        public void DoSmth();
    }
}