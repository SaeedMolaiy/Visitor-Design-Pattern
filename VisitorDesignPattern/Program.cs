using VisitorDesignPattern.Elements;
using VisitorDesignPattern.Visitors;

var elementA = new ConcreteElementA();
var elementB = new ConcreteElementB();

var visitor1 = new ConcreteVisitor1();
var visitor2 = new ConcreteVisitor2();

elementA.Accept(visitor1);
elementB.Accept(visitor1);

elementA.Accept(visitor2);
elementB.Accept(visitor2);

Console.ReadKey();