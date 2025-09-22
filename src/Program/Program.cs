namespace Program;
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
    public Input OR(Input input2)
    {
    }
    public Input NOT()
    {
        return new Input(!Bit);
    }
}
