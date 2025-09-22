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
    
    [Test]
    public void Flow2()
    {
        Input input1 = new Input(true);
        Input input2 = new Input(false);
        Input input3 = new Input(true);
        Input resultado = input1.OR(input2); 
        Console.WriteLine(resultado.bit);
    }
}
