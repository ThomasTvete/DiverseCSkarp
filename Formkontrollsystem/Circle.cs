namespace Formkontrollsystem;

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius, string color) : base("Sirkel", color)
    {
        _radius = radius;
    }
    public override double CalculateArea()
    {
        double area = _radius * _radius * Double.Pi;
        return area;
    }

}