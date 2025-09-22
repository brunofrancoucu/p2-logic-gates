namespace Library.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
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
