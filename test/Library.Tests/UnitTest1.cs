using LogicGates;

namespace Library.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AND()
    {
        Input a = new Input(true);
        Input b = new Input(false);
        Input c = new Input(false);

        Input result = a.AND(b).AND(c).NOT(); // method chaining

        Assert.That(result.Bit, Is.EqualTo(true)); // prints: A AND B AND C
    }

    [Test]
    public void OR()
    {
        Input input1 = new Input(true);
        Input input2 = new Input(false);
        Input input3 = new Input(true);
        
        Input resultado = input1.OR(input2);
        Console.WriteLine(resultado.Bit);
    }

    public void GarageTests()
    {
        GarageGate opened1 = new GarageGate(false, false, true);
        GarageGate opened2 = new GarageGate(true, true, true);
        GarageGate closed = new GarageGate(false, true, true);
        
        Assert.That(opened1.Evaluate(), Is.EqualTo(true)); // prints: A AND B AND C
        Assert.That(opened2.Evaluate(), Is.EqualTo(true));
        Assert.That(closed.Evaluate(), Is.EqualTo(false));
    }

}
