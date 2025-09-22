namespace LogicGates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}

public class Input
{
    public bool Bit;

    public Input(bool bit)
    {
        Bit = bit;
    }
    public Input AND(Input input2)
    {
        return new Input(Bit && input2.Bit);
    }
    
    public Input OR(Input input2) // Debo devolver un objeto de tipo Input, lo dice en el método
    {
        return new Input(this.Bit || input2.Bit); // bit es true o false
    }
    public Input NOT()
    {
        return new Input(!Bit);
    }
}

public class GarageGate
{
    private Input A, B, C;
    public GarageGate(bool a, bool b, bool c)
    {
        A = new Input(a);
        B = new Input(b);
        C = new Input(c);
    }

    public bool Evaluate()
    {
        // method chaining
        return A.AND(B).OR(C.NOT().AND(B.NOT())).AND(C).Bit; 

    }
}
