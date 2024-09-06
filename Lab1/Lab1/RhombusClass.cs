namespace Lab1;

public class RhombusClass (double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, string perimeter, string square)
{
    private readonly double _x1 = x1, _y1 = y1, _x2 = x2, _y2 = y2, _x3 = x3, _y3 = y3, _x4 = x4, _y4 = y4;
    private readonly string _perimeter = perimeter, _square = square;
    
    public static void GetArea() { }
    
    public string GetPerimeter()
    {
        var rhombusPerimeter = 4*Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        string perimeter = rhombusPerimeter.ToString("0.00");
        perimeter = perimeter.Replace(",", ".");
        return perimeter;
    }
    
    public string GetSquare()
    {
        var rhombusSquare = 0.5* (Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)) *
                                  Math.Sqrt(Math.Pow(x4 - x2, 2) + Math.Pow(y4 - y2, 2)));
        string square = rhombusSquare.ToString("0.00");
        square = square.Replace(",", ".");
        return square;
    }
    
    public string Print()
    { return $"({_x1}, {_y1}), ({_x2}, {_y2}), ({_x3}, {_y3}), ({_x4}, {_y4}), Perimeter: {_perimeter}, Square: {_square}"; }

    ~RhombusClass() { Console.WriteLine("Destructor"); }
}