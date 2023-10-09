using VisitorDesignPattern.Visitors;

namespace VisitorDesignPattern.Elements;
internal class ConcreteElementA : Element
{
    public override void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteElementA(this);
    }
}