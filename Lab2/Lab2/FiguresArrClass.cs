namespace Lab2;

public class FiguresArrClass
{
    
    private static readonly Random Random = new();
    protected static int NumberOfFigures = 5;
    protected static TrapezoidClass[] TrapezoidArr = new TrapezoidClass[NumberOfFigures];
    protected static CircleClass[] CircleArr = new CircleClass[NumberOfFigures];
    
    public static void UserChoice(string choice)
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
    
    public static void FiguresArrClassCreation(string choice)
    {
        for (int i = 0; i < NumberOfFigures; i++)
        {
            try
            {
                if (choice == "Trapezoid")
                {
                    TrapezoidArr[i] = RandomTrapezoidInput();
                }
                else
                {
                    CircleArr[i] = RandomCircleInput();
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