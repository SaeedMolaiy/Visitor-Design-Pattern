using VisitorDesignPattern.Visitors;

namespace VisitorDesignPattern.Elements;

internal abstract class Element
{
    public abstract void Accept(IVisitor visitor);
}