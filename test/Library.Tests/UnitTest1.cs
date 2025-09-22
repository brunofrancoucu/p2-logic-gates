using Program;

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
        Program n = new Program();
        Input a("A");
        Input b("B");
        Input c("C");
        
        a.AND(b).AND(c);    // method chaining
        a.show();           // prints: A AND B AND C
        
        Assert.Pass();
    }
}
