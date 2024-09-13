namespace Lab2;

public class CircleClass : FigureClass
{
    private readonly double _radius;
    
    public CircleClass(double radius)
    {
        _radius = radius;
        Console.WriteLine("Circle constructor called");
    }

    public override string Print()
    {
        return $"Radius: {_radius}, Area: {GetArea()}, Perimeter: {GetPerimeter()}";
    }

    public override string GetArea()
    {
        try
        {
            var circleArea = Math.PI * Math.Pow(_radius, 2);
            string area = circleArea.ToString("0.00");
            area = area.Replace(",", ".");
            return area;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public override string GetPerimeter()
    {
        try
        {
            var circlePerimeter = 2 * Math.PI * _radius;
            string perimeter = circlePerimeter.ToString("0.00");
            perimeter = perimeter.Replace(",", ".");
            return perimeter;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    public override string GetInfo()
    {
        return base.GetInfo() + $" It is a circle";
    }
    
    public new string GetDetails()
    {
        return "Circle details.";
    }

    ~CircleClass()
    {
        Console.WriteLine("Circle destructor called");
    }
}