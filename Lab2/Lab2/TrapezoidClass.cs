namespace Lab2;

public class TrapezoidClass : FigureClass
{
    private readonly double[][] _coordinates;
    
    public TrapezoidClass() {}
    
    public TrapezoidClass(double[][] coordinates)
    {
        _coordinates = coordinates;
        Console.WriteLine("Trapezoid constructor called");
    }
    
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
        try
        {
            var AD = Math.Sqrt(Math.Abs(Math.Pow(_coordinates[0][3] - _coordinates[0][0], 2) + Math.Pow(_coordinates[1][3] - _coordinates[1][0], 2)));
            var BC = Math.Sqrt(Math.Abs(Math.Pow(_coordinates[0][2] - _coordinates[0][1], 2) + Math.Pow(_coordinates[1][2] - _coordinates[1][1], 2)));
            var BA = Math.Sqrt(Math.Abs(Math.Pow(_coordinates[0][1] - _coordinates[0][0], 2) + Math.Pow(_coordinates[1][1] - _coordinates[1][0], 2)));
            var CD = Math.Sqrt(Math.Abs(Math.Pow(_coordinates[0][3] - _coordinates[0][2], 2) + Math.Pow(_coordinates[1][3] - _coordinates[1][2], 2)));
            double area = (0.5 * (BC + AD) * Math.Sqrt(Math.Abs(Math.Pow(BA, 2) - 
                                                         Math.Pow((Math.Pow((AD - BC), 2) + Math.Pow(BA, 2) - 
                                                                   Math.Pow(CD, 2)) / (2 * (AD - BC)), 2))));

            if (area < 1) { throw new CustomException("Area is less than 1"); }
            
            var areaString = area.ToString("0.00").Replace(",", ".");
            return areaString;
        }
        catch (CustomException e)
        {
            Console.WriteLine(e);
        }
        
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return "0";
    }

    public override string GetPerimeter()
    {
        try
        {
            var AB = Math.Sqrt(Math.Abs(Math.Pow(_coordinates[0][1] - _coordinates[0][0], 2) + Math.Pow(_coordinates[1][1] - _coordinates[1][0], 2)));
            var BC = Math.Sqrt(Math.Abs(Math.Pow(_coordinates[0][2] - _coordinates[0][1], 2) + Math.Pow(_coordinates[1][2] - _coordinates[1][1], 2)));
            var CD = Math.Sqrt(Math.Abs(Math.Pow(_coordinates[0][3] - _coordinates[0][2], 2) + Math.Pow(_coordinates[1][3] - _coordinates[1][2], 2)));
            var DA = Math.Sqrt(Math.Abs(Math.Pow(_coordinates[0][0] - _coordinates[0][3], 2) + Math.Pow(_coordinates[1][0] - _coordinates[1][3], 2)));
            return (AB + BC + CD + DA).ToString("0.00").Replace(",", ".");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}