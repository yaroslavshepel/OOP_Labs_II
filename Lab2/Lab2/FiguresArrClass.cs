namespace Lab2;

public class FiguresArrClass
{
    
    private static readonly Random Random = new();
    protected static readonly int NumberOfFigures = 5;
    protected static readonly FigureClass[][] FiguresArr = new FigureClass[2][];
    
    protected static void UserChoice(string choice)
    {
        switch (choice)
        {
            case "Trapezoid":
                FiguresArrClassCreation("Trapezoid");
                break;
            default:
                FiguresArrClassCreation("Circle");
                break;
        }
    }
    
    protected static void FiguresArrClassCreation(string choice)
    {
        try
        {
            FiguresArr[0] = new TrapezoidClass[NumberOfFigures]; 
            FiguresArr[1] = new CircleClass[NumberOfFigures];
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        for (var i = 0; i < NumberOfFigures; i++)
        {
            try
            {
                if (choice == "Trapezoid")
                {
                    //TrapezoidArr[i] = RandomTrapezoidInput();
                    FiguresArr[0][i] = RandomTrapezoidInput();
                }
                else
                {
                    // CircleArr[i] = RandomCircleInput();
                    FiguresArr[1][i] = RandomCircleInput();
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                i--;
            }
        }
    }
    
    private static TrapezoidClass RandomTrapezoidInput()
    {
       
        double[][] coordinates = new double[2][];
        coordinates[0] = new double[4];
        coordinates[1] = new double[4];
        for (var i = 0; i < 4; i++)
        {
            coordinates[0][i] = Random.Next(-100, 100);
            coordinates[1][i] = Random.Next(-100, 100);
        }
        
        var trapezoidClassTemp = new TrapezoidClass(coordinates);
        return trapezoidClassTemp;
    }
    
    private static CircleClass RandomCircleInput()
    {
        double radius = Random.Next(1, 100);
        var circleClassTemp = new CircleClass(radius);
        return circleClassTemp;
    }
}