namespace Operations;

public class Circle(decimal width) : IShape
{
    public decimal Height { get; }

    public decimal Width { get; }

    public string PrintName()
    {
        throw new NotImplementedException();
    }

    public decimal GetArea()
    {
        throw new NotImplementedException();
    }
}