public interface IShape
{
    decimal Height { get; }
    decimal Width { get; }

    string PrintName();
    decimal GetArea();
}