using VisitorDesignPattern.Elements;

namespace VisitorDesignPattern.Visitors;

internal class ConcreteVisitor1 : IVisitor
{
    public void VisitConcreteElementA(ConcreteElementA element)
    {
        Console.WriteLine("ConcreteVisitor1 : VisitConcreteElementA");
    }

    public void VisitConcreteElementB(ConcreteElementB element)
    {
        Console.WriteLine("ConcreteVisitor1 : VisitConcreteElementB");
    }
}