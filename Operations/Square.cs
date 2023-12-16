namespace Operations;
public class Square(decimal width) : IShape
{
    public decimal Width { get; } = width;
    public decimal Height { get; }

    public string PrintName() => "Square";

    public decimal GetArea()
    {
        return Width * Width;
    }
}