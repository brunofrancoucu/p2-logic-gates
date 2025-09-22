namespace LogicGates;
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
