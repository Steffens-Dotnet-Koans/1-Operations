// See https://aka.ms/new-console-template for more information

using Operations;

Console.WriteLine("Hello, World!");

foreach (var shape in GetShapes())
{
    Console.WriteLine($"== Shape: {shape.PrintName()}");
    Console.WriteLine($"Width: {shape.Width}");
    Console.WriteLine($"Height: {shape.Height}");
    Console.WriteLine($"Area: {shape.GetArea()}");
}

return;


static List<IShape> GetShapes()
{
    return
    [
        new Square(5.0m)
    ];
}
