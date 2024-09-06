namespace Lab1;
//using Lab1;

public class RhombusArrClass
{
    protected static int RhombusArrLength = 7;
    protected static RhombusClass[] RhombusArr = new RhombusClass[RhombusArrLength];
    private static readonly Random Random = new Random();
    private static RhombusClass RhombusToArr(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        var rhombusPerimeter = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        string displayString = rhombusPerimeter.ToString("0.00");
        displayString = displayString.Replace(",", ".");
        var rhombusTemp = new RhombusClass(x1, y1, x2, y2, x3, y3, x4, y4, displayString);
        return rhombusTemp;
    }

    private static RhombusClass RhombusInput(int rhombusNumber)
    {
        ConsoleMenu.AskCoordinates(rhombusNumber);
        double x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0, x4 = 0, y4 = 0;
        for (int j = 0; j < 4; j++)
        {
            double x = 0, y = 0;
            try
            {
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            switch (j)
            {
                case 0: x1 = x; y1 = y; break;
                case 1: x2 = x; y2 = y; break;
                case 2: x3 = x; y3 = y; break;
                case 3: x4 = x; y4 = y; break;
            }
        }
        RhombusClass rhombusClassTemp = RhombusToArr( x1, y1, x2, y2, x3, y3, x4, y4);
        return rhombusClassTemp;
    }

    private static RhombusClass RandomRhombusInput()
    {
        double x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0, x4 = 0, y4 = 0;
        for (var j = 0; j < 4; j++)
        {
           double x = Random.Next(-100, 100);
           double y = Random.Next(-100, 100);
            switch (j)
            {
                case 0: x1 = x; y1 = y; break;
                case 1: x2 = x; y2 = y; break;
                case 2: x3 = x; y3 = y; break;
                case 3: x4 = x; y4 = y; break;
            }
        }
        RhombusClass rhombusClassTemp = RhombusToArr( x1, y1, x2, y2, x3, y3, x4, y4);
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
            //if (rhombus[i].GetPerimeter().ToString() == perimeter)
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
    
    public static string PerimeterFind(ref RhombusClass[] rhombus, ref int oldRhombusArrLength, string perimeter)
    {
        for (int i = 0; i < oldRhombusArrLength; i++)
        {
            //if (rhombus[i].GetPerimeter().ToString() == perimeter)
            if (rhombus[i].GetPerimeter() == perimeter)
            {
                //Console.WriteLine(ConsoleMenu.ConsolePrintRhombus(i + 1, rhombus[i]));
                return ConsoleMenu.RhombusPrint(i + 1, rhombus[i]);
            }
        }
        return "Rhombus not found" + "\n" + "Try again.";
    }

    /*public static string PrintRhombusArr(RhombusClass[] rhombus, ref int printRhombusArrLength)
    {
        for (int i = 0; i < printRhombusArrLength; i++)
        {
            try
            {
               return ConsoleMenu.ConsolePrintRhombus(i + 1, rhombus[i]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        Console.WriteLine();
        return "";
    }*/
}