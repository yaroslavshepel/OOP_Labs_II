namespace Lab2;

public class CircleClass : FigureClass
{
    private double _radius;
    
    public CircleClass(double radius)
    {
        _radius = radius;
        // Console.WriteLine("Circle constructor called");
        ConsoleMenu.PrintSomething("Circle constructor called");
    }

    public override string Print()
    {
        return $"Radius: {_radius}, Area: {GetArea()}, Perimeter: {GetPerimeter()}";
    }

    public override string GetArea()
    {
        var circleArea = Math.PI * Math.Pow(_radius, 2);
        string area = circleArea.ToString("0.00");
        area = area.Replace(",", ".");
        return area;
    }

    public override string GetPerimeter()
    {
        var circlePerimeter = 2 * Math.PI * _radius;
        string perimeter = circlePerimeter.ToString("0.00");
        perimeter = perimeter.Replace(",", ".");
        return perimeter;
    }
    
    /*public override string Display()
    {
        return "Circle: Area and Perimeter are calculated.";
    }*/

    ~CircleClass()
    {
        Console.WriteLine("Circle destructor called");
    }
}