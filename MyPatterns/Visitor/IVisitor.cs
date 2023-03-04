namespace Visitor
{
    public interface IVisitor
    {
        public void VisitGoodClass(ISomeClass someclass);
        public void VisitBadClass(ISomeClass someclass);
    }
}