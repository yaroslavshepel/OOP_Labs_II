namespace Lab1.Classes;

/*public class Rhombus
{*/
public class Rhombus (double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, string perimeter)
{
    private readonly double _x1 = x1, _y1 = y1, _x2 = x2, _y2 = y2, _x3 = x3, _y3 = y3, _x4 = x4, _y4 = y4;
    private readonly string _perimeter = perimeter;
    
    
    
    /*private double _x1 ,_y1, _x2, _y2, _x3, _y3, _x4, _y4;
    private string _perimeter;*/
    
   /* public Rhombus(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, string perimeter)
    {
        _x1 = x1; _x2 = x2; _x3 = x3; _x4 = x4;
        _y1 = y1; _y2 = y2; _y3 = y3; _y4 = y4;
        _perimeter = perimeter;
    }*/
    
    /*public Rhombus(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, string perimeter) =>
    (_x1, _y1, _x2, _y2, _x3, _y3, _x4, _y4, _perimeter) = (x1, y1, x2, y2, x3, y3, x4, y4, perimeter);*/
    
    
    public double GetArea()
    {
        var d1 = Math.Sqrt(Math.Pow(_x2 - _x1, 2) + Math.Pow(_y2 - _y1, 2));
        var d2 = Math.Sqrt(Math.Pow(_x3 - _x2, 2) + Math.Pow(_y3 - _y2, 2));
        return d1 * d2 / 2;
    }
    
    public double GetPerimeter()
    {
        var d1 = Math.Sqrt(Math.Pow(_x2 - _x1, 2) + Math.Pow(_y2 - _y1, 2));
        return 4 * d1;
    }
    
    public string Print()
    {
        return $"({_x1}, {_y1}), ({_x2}, {_y2}), ({_x3}, {_y3}), ({_x4}, {_y4}), Perimeter: {_perimeter}";
    }

    ~Rhombus()
    {
        Console.WriteLine("Rhombus object has been deleted.");
    }
}