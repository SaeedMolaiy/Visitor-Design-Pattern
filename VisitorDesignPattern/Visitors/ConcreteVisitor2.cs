using VisitorDesignPattern.Elements;

namespace VisitorDesignPattern.Visitors;

internal class ConcreteVisitor2 : IVisitor
{
    public void VisitConcreteElementA(ConcreteElementA element)
    {
        Console.WriteLine("ConcreteVisitor2 : VisitConcreteElementA");
    }

    public void VisitConcreteElementB(ConcreteElementB element)
    {
        Console.WriteLine("ConcreteVisitor2 : VisitConcreteElementB");
    }
}