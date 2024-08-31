using Lab1.Classes;
var rhombusArrLength = 7;
Rhombus[] rhombusArr = new Rhombus[rhombusArrLength];
Random random = new Random();

Rhombus RhombusToArr(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
{
    var rhombusPerimeter = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    //String.Format("{0:0.00}", rhombusPerimeter);
    string displayString = rhombusPerimeter.ToString("0.00");
    displayString = displayString.Replace(",", ".");
    var rhombusTemp = new Rhombus(x1, y1, x2, y2, x3, y3, x4, y4, displayString);
    return rhombusTemp;
}

Rhombus RhombusInput()
{
    Console.WriteLine("Enter the coordinates of the rhombus: ");
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
        //!double x = Convert.ToDouble(Console.ReadLine());
        //!double y = Convert.ToDouble(Console.ReadLine());
        switch (j)
        {
            case 0: x1 = x; y1 = y; break;
            case 1: x2 = x; y2 = y; break;
            case 2: x3 = x; y3 = y; break;
            case 3: x4 = x; y4 = y; break;
        }
    }
    Rhombus rhombusTemp = RhombusToArr( x1, y1, x2, y2, x3, y3, x4, y4);
    return rhombusTemp;
}

Rhombus RandomRhombusInput()
{
    double x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0, x4 = 0, y4 = 0;
    for (var j = 0; j < 4; j++)
    {
       double x = random.Next(-100, 100);
       double y = random.Next(-100, 100);
        switch (j)
        {
            case 0: x1 = x; y1 = y; break;
            case 1: x2 = x; y2 = y; break;
            case 2: x3 = x; y3 = y; break;
            case 3: x4 = x; y4 = y; break;
        }
    }
    Rhombus rhombusTemp = RhombusToArr( x1, y1, x2, y2, x3, y3, x4, y4);
    return rhombusTemp;
}

void RhombusArrCr()
{
    for (int i = 0; i < rhombusArrLength; i++)
    {
        try
        {
            //!rhombusArr[i] = RhombusInput();
            rhombusArr[i] = RandomRhombusInput();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            i--;
        }
    }
}

void AddRhombus(ref Rhombus[] rhombus, ref int oldRhombusArrLength)
{
    oldRhombusArrLength++;
    Array.Resize(ref rhombus, oldRhombusArrLength);
    rhombus[oldRhombusArrLength - 1] = RandomRhombusInput();
}

void PrintRhombusArr(Rhombus[] array, ref int printRhombusArrLength)
{
    for (int i = 0; i < printRhombusArrLength; i++)
    {
        try
        {
            Console.WriteLine($"Coordinates of the Rhombus {i + 1}: {array[i].Print()}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    Console.WriteLine();
}

RhombusArrCr();

PrintRhombusArr(rhombusArr, ref rhombusArrLength);

Console.WriteLine(rhombusArrLength);

AddRhombus(ref rhombusArr, ref rhombusArrLength);

Console.WriteLine(rhombusArrLength);

Console.WriteLine();

PrintRhombusArr(rhombusArr, ref rhombusArrLength);
