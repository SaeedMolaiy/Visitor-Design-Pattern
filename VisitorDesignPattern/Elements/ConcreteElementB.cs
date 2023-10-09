using VisitorDesignPattern.Visitors;

namespace VisitorDesignPattern.Elements;

internal class ConcreteElementB : Element
{
    public override void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteElementB(this);
    }
}