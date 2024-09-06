namespace Lab1;

public class RhombusArrClass
{
    protected static int RhombusArrLength = 7;
    protected static RhombusClass[] RhombusArr = new RhombusClass[RhombusArrLength];
    private static readonly Random Random = new Random();
    
    private static RhombusClass RhombusToArr(double[] cords)
    {
        var rhombusPerimeter = 4*Math.Sqrt(Math.Pow(cords[2] - cords[0], 2) + Math.Pow(cords[3] - cords[1], 2));
        var rhombusSquare = 0.5* (Math.Sqrt(Math.Pow(cords[4] - cords[0], 2) + Math.Pow(cords[5] - cords[1], 2)) *
                                  Math.Sqrt(Math.Pow(cords[6] - cords[2], 2) + Math.Pow(cords[7] - cords[3], 2)));
        string perimeter = rhombusPerimeter.ToString("0.00");
        string square = rhombusSquare.ToString("0.00");
        perimeter = perimeter.Replace(",", ".");
        square = square.Replace(",", ".");
        var rhombusTemp = new RhombusClass(cords[0], cords[1], cords[2], cords[3], cords[4], cords[5], cords[6], cords[7], perimeter, square);
        return rhombusTemp;
    }

    private static RhombusClass RhombusInput(int rhombusNumber)
    {
        ConsoleMenu.AskCoordinates(rhombusNumber);

        double[] cords = new double[8];
        
        for (var j = 0; j < 7; j++)
        {
            double x = 0, y = 0;
            try
            {
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e) { j -= 2; }
            cords[j] = x;
            cords[j + 1] = y;
            j++;
        }
        RhombusClass rhombusClassTemp = RhombusToArr(cords);
        return rhombusClassTemp;
    }

    private static RhombusClass RandomRhombusInput()
    {
        double[] cords = new double[8];
        for (var j = 0; j < 7; j++)
        {
            double x = Random.Next(-100, 100);
            double y = Random.Next(-100, 100);
            cords[j] = x;
            cords[j + 1] = y;
            j++;
        }
        RhombusClass rhombusClassTemp = RhombusToArr(cords);
        return rhombusClassTemp;
    }

    protected static void RhombusArrCr(int choice)
    {
        for (int i = 0; i < RhombusArrLength; i++)
        {
            try
            {
                if (choice == 1)
                {
                    RhombusArr[i] = RhombusInput(i);
                }
                else
                {
                    RhombusArr[i] = RandomRhombusInput();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                i--;
            }
        }
    }

    protected static void AddRhombus(ref RhombusClass[] rhombus, ref int oldRhombusArrLength)
    {
        oldRhombusArrLength++;
        Array.Resize(ref rhombus, oldRhombusArrLength);
        rhombus[oldRhombusArrLength - 1] = RandomRhombusInput();
    }

    protected static string RemoveRhombusByPerimeter(ref RhombusClass[] rhombus, ref int oldRhombusArrLength, string perimeter)
    {
        var ifRhombusExists = false;
        for (var i = 0; i < oldRhombusArrLength; i++)
        {
            if (rhombus[i].GetPerimeter() == perimeter)
            {
                ifRhombusExists = true;
                for (var j = i; j < oldRhombusArrLength - 1; j++)
                {
                    rhombus[j] = rhombus[j + 1];
                }
                oldRhombusArrLength--;
                Array.Resize(ref rhombus, oldRhombusArrLength);
            }
        }
        if (ifRhombusExists) { return "Done."; }
        else { return "Rhombus not found" + "\n" + "Choose perimeters of the these rhombuses:"; }
    }
    
    protected static string PerimeterFind(ref RhombusClass[] rhombus, ref int oldRhombusArrLength, string perimeter)
    {
        for (var i = 0; i < oldRhombusArrLength; i++)
        {
            if (rhombus[i].GetPerimeter() == perimeter)
            {
                return ConsoleMenu.RhombusPrint(i + 1, rhombus[i]);
            }
        }
        return "Rhombus not found" + "\n" + "Try again.";
    }
}