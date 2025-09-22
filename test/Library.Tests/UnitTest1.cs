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
        Point a("A");
        Point b("B");
        Point c("C");
        
        a.AND(b).AND(c); // method chaining
        a.show(); // prints: A AND B AND C
    }
        Assert.Pass();
    }
}
