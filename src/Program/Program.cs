namespace Program;

class Input
{
    public string Value;
    public bool Bit;

    public Input(String value, bool bit)
    {
        Value = value;
        Bit = bit;
    }
    public Input AND(Input input2)
    {
    }
    public Input OR(Input input2)
    {
    }
    public Input NOT()
    {
        return new Input(Value, !Bit);
    }
}
