namespace Formkontrollsystem;

public class Triangle : Shape
{
    private double _base;
    private double _height;

    public Triangle(double @base, double height, string color) : base("Trekant", color)
    {
        _base = @base;
        _height = height;
    }

    public override double CalculateArea()
    {
        double area = _base * _height * 0.5;
        return area;
    }
}