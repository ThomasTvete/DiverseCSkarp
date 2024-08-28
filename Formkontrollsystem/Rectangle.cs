namespace Formkontrollsystem;

public class Rectangle : Shape
{

    private double _length;
    private double _width;

    public Rectangle(double length, double width, string color) : base("Rektangel", color)
    {
        _length = length;
        _width = width;
    }

    public override double CalculateArea()
    {
        double area = _length * _width;
        return area;
    }
}