
using Formkontrollsystem;

List<Shape> shapes = new List<Shape>()
{
    new Circle(3.6, "blå"),
    new Circle(7.9, "gul"),
    new Rectangle(4.3, 8.2, "rød"),
    new Rectangle(6.6, 5, "hvit"),
    new Triangle(11.11, 5.7, "rosa"),
    new Triangle(13, 6.9, "grønn")
};
double TotalArea = 0;

foreach (Shape shape in shapes)
{
    double area = shape.CalculateArea();
    TotalArea += area;
    Console.WriteLine($"{shape.Name} i fargen {shape.Color} og med et areal på {Math.Round(area, 2)}cm");
}

Console.WriteLine($"\nTotalt areal: {Math.Round(TotalArea, 2)}cm");
Console.WriteLine();

shapes.Sort((x, y) => x.CalculateArea().CompareTo(y.CalculateArea()));


foreach (Shape shape in shapes)
{
    double area = shape.CalculateArea();
    Console.WriteLine($"{shape.Name} i fargen {shape.Color} og med et areal på {Math.Round(area, 2)}cm");
}

Console.WriteLine();

shapes.Sort((x, y) => String.Compare(x.Color, y.Color));


foreach (Shape shape in shapes)
{
    double area = shape.CalculateArea();
    Console.WriteLine($"{shape.Name} i fargen {shape.Color} og med et areal på {Math.Round(area, 2)}cm");
}
