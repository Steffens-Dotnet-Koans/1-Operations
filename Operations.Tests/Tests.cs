namespace Operations.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(0.5)]
    [TestCase(5.0)]
    [TestCase(25.0)]
    [TestCase(100.0)]
    public void Test_Square(decimal width)
    {
        var square = new Square(width);
        Assert.That(square.Width, Is.EqualTo(width));
        Assert.That(square.Height, Is.EqualTo(width));
        Assert.That(square.GetArea(), Is.EqualTo(width * width).Within(0.01));
        Assert.That(square.PrintName(), Is.EqualTo("Square"));
    }

    [Test]
    [TestCase(0.5)]
    [TestCase(5.0)]
    [TestCase(25.0)]
    [TestCase(100.0)]
    public void Test_Triangle(decimal width)
    {
        var triangle = new EquilateralTriangle(width);
        Assert.That(triangle.Width, Is.EqualTo(width));
        Assert.That(triangle.Height, Is.EqualTo(width));
        Assert.That(triangle.GetArea(), Is.EqualTo(width * width / 2).Within(0.01));
        Assert.That(triangle.PrintName(), Is.EqualTo("triangle").IgnoreCase);
    }

    [Test]
    [TestCase(0.5)]
    [TestCase(5.0)]
    [TestCase(25.0)]
    [TestCase(100.0)]
    public void Test_Circle(decimal width)
    {
        var circle = new Circle(width);
        Assert.That(circle.Width, Is.EqualTo(width));
        Assert.That(circle.Height, Is.EqualTo(width));
        Assert.That(circle.GetArea(), Is.EqualTo(Math.PI * Math.Pow((double)(width / 2), 2)).Within(0.01));
        Assert.That(circle.PrintName(), Is.EqualTo("circle").IgnoreCase);
    }
}