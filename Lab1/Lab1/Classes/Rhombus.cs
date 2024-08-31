namespace Lab1.Classes;

public class Rhombus
{
    private double _x1 ,_y1, _x2, _y2, _x3, _y3, _x4, _y4;
    
    public Rhombus(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        _x1 = x1;
        _y1 = y1;
        _x2 = x2;
        _y2 = y2;
        _x3 = x3;
        _y3 = y3;
        _x4 = x4;
        _y4 = y4;
    }
    
    public double GetArea()
    {
        double d1 = Math.Sqrt(Math.Pow(_x2 - _x1, 2) + Math.Pow(_y2 - _y1, 2));
        double d2 = Math.Sqrt(Math.Pow(_x3 - _x2, 2) + Math.Pow(_y3 - _y2, 2));
        return d1 * d2 / 2;
    }
    
    public double GetPerimeter()
    {
        double d1 = Math.Sqrt(Math.Pow(_x2 - _x1, 2) + Math.Pow(_y2 - _y1, 2));
        return 4 * d1;
    }
    
    public string Print()
    {
        return $"Coordinates of the Rhombus: ({_x1}, {_y1}), ({_x2}, {_y2}), ({_x3}, {_y3}), ({_x4}, {_y4})";
    }

    ~Rhombus()
    {
        Console.WriteLine("Rhombus object has been deleted.");
    }
}