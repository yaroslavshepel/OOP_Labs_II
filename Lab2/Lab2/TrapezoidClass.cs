namespace Lab2;

public class TrapezoidClass : FigureClass
{
    //double _x1, double _y1, double _x2, double _y2, double _x3, double _y3, double _x4, double _y4
    //private readonly double x1 = _x1, y1 = _y1, x2 = _x2, y2 = _y2, x3 = _x3, y3 = _y3, x4 = _x4, y4 = _y4;
    
    private double[][] _coordinates;
    
    public TrapezoidClass(double[][] coordinates)
    {
        _coordinates = coordinates;
        ConsoleMenu.PrintSomething("Trapezoid constructor called");
    }
    
    /*public override string Display()
    {
        //Console.WriteLine("Trapezoid: Area and Perimeter are calculated.");
        return "Trapezoid: Area and Perimeter are calculated.";
    }*/

    public override string Print()
    {
        return $"({_coordinates[0][0]}, {_coordinates[1][0]}), ({_coordinates[0][1]}, {_coordinates[1][1]}), " +
               $"({_coordinates[0][2]}, {_coordinates[1][2]}), ({_coordinates[0][3]}, {_coordinates[1][3]}), " +
               $"Area: {GetArea()}, Perimeter: {GetPerimeter()}";
    }

    ~TrapezoidClass()
    {
        Console.WriteLine("Trapezoid destructor called");
    }
    
    public override string GetArea()
    {
        var AD = Math.Sqrt(Math.Abs(Math.Pow(_coordinates[0][3] - _coordinates[0][0], 2) + Math.Pow(_coordinates[1][3] - _coordinates[1][0], 2)));
        var BC = Math.Sqrt(Math.Abs(Math.Pow(_coordinates[0][2] - _coordinates[0][1], 2) + Math.Pow(_coordinates[1][2] - _coordinates[1][1], 2)));
        var BA = Math.Sqrt(Math.Abs(Math.Pow(_coordinates[0][1] - _coordinates[0][0], 2) + Math.Pow(_coordinates[1][1] - _coordinates[1][0], 2)));
        var CD = Math.Sqrt(Math.Abs(Math.Pow(_coordinates[0][3] - _coordinates[0][2], 2) + Math.Pow(_coordinates[1][3] - _coordinates[1][2], 2)));
        return (0.5 * (BC + AD) * Math.Sqrt(Math.Abs(Math.Pow(BA, 2) - 
                                                     Math.Pow((Math.Pow((AD - BC), 2) + Math.Pow(BA, 2) - 
                                                               Math.Pow(CD, 2)) / (2 * (AD - BC)), 2)))).ToString("0.00").Replace(",", ".");
    }

    public override string GetPerimeter()
    {
        var AB = Math.Sqrt(Math.Abs(Math.Pow(_coordinates[0][1] - _coordinates[0][0], 2) + Math.Pow(_coordinates[1][1] - _coordinates[1][0], 2)));
        var BC = Math.Sqrt(Math.Abs(Math.Pow(_coordinates[0][2] - _coordinates[0][1], 2) + Math.Pow(_coordinates[1][2] - _coordinates[1][1], 2)));
        var CD = Math.Sqrt(Math.Abs(Math.Pow(_coordinates[0][3] - _coordinates[0][2], 2) + Math.Pow(_coordinates[1][3] - _coordinates[1][2], 2)));
        var DA = Math.Sqrt(Math.Abs(Math.Pow(_coordinates[0][0] - _coordinates[0][3], 2) + Math.Pow(_coordinates[1][0] - _coordinates[1][3], 2)));
        return (AB + BC + CD + DA).ToString("0.00").Replace(",", ".");
    }
}