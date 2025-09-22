using LogicGates;

namespace Library.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void Flow1()
    {
        Input a = new Input(true);
        Input b = new Input(false);
        Input c = new Input(false);
        
        a.AND(b).AND(c);    // method chaining
        
        Assert.That(a.Bit, Is.EqualTo(true)); // prints: A AND B AND C
    }
}
