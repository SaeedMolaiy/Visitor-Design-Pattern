using VisitorDesignPattern.Elements;

namespace VisitorDesignPattern.Visitors;

internal interface IVisitor
{
    void VisitConcreteElementA(ConcreteElementA element);

    void VisitConcreteElementB(ConcreteElementB element);
}