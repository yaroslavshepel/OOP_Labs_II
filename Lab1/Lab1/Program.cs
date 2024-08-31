using Lab1.Classes;
var rhombusArrLength = 7;
RhombusClass[] rhombusArr = new RhombusClass[rhombusArrLength];
Random random = new Random();

RhombusClass RhombusToArr(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
{
    var rhombusPerimeter = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    string displayString = rhombusPerimeter.ToString("0.00");
    displayString = displayString.Replace(",", ".");
    var rhombusTemp = new RhombusClass(x1, y1, x2, y2, x3, y3, x4, y4, displayString);
    return rhombusTemp;
}

RhombusClass RhombusInput(int i)
{
    Console.WriteLine($"Enter the coordinates of the rhombus {i}: ");
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

RhombusClass RandomRhombusInput()
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
    RhombusClass rhombusClassTemp = RhombusToArr( x1, y1, x2, y2, x3, y3, x4, y4);
    return rhombusClassTemp;
}

void RhombusArrCr(int choice)
{
    for (int i = 0; i < rhombusArrLength; i++)
    {
        try
        {
            if (choice == 1)
            {
                rhombusArr[i] = RhombusInput(i);
            }
            else
            {
                rhombusArr[i] = RandomRhombusInput();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            i--;
        }
    }
}

void AddRhombus(ref RhombusClass[] rhombus, ref int oldRhombusArrLength)
{
    oldRhombusArrLength++;
    Array.Resize(ref rhombus, oldRhombusArrLength);
    rhombus[oldRhombusArrLength - 1] = RandomRhombusInput();
}

void RemoveRhombusByPerimeter(ref RhombusClass[] rhombus, ref int oldRhombusArrLength, string perimeter)
{
    for (int i = 0; i < oldRhombusArrLength; i++)
    {
        if (rhombus[i].GetPerimeter().ToString() == perimeter)
        {
            for (int j = i; j < oldRhombusArrLength - 1; j++)
            {
                rhombus[j] = rhombus[j + 1];
            }
            oldRhombusArrLength--;
            Array.Resize(ref rhombus, oldRhombusArrLength);
        }
    }
}

void PrintRhombusArr(RhombusClass[] array, ref int printRhombusArrLength)
{
    for (int i = 0; i < printRhombusArrLength; i++)
    {
        try
        {
            Console.WriteLine($"Coordinates of the RhombusClass {i + 1}: {array[i].Print()}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    Console.WriteLine();
}

void Main()
{
    
    bool isStopped = true;
    while (isStopped)
    {
        Console.WriteLine("Enter your choice: ");
        Console.WriteLine("0. Exit.");
        Console.WriteLine("1. Create an array of rhombuses on your own.");
        Console.WriteLine("2. Create an array of rhombuses randomly.");
        
        var choice = Convert.ToInt32(Console.ReadLine());

        bool SecondMenu()
        {
            var isStopped2 = true;
            while (isStopped2)
            {
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine("1. Print the array of rhombuses.");
                Console.WriteLine("2. Add a rhombus to the array.");
                Console.WriteLine("3. Remove a rhombus from the array by perimeter.");
                Console.WriteLine("9. Return to the previous menu.");
                Console.WriteLine("0. Exit.");
        
                var secondChoice = Convert.ToInt32(Console.ReadLine());
        
                switch (secondChoice)
                {
                    case 1:
                        PrintRhombusArr(rhombusArr, ref rhombusArrLength);
                        break;
                    case 2:
                        AddRhombus(ref rhombusArr, ref rhombusArrLength);
                        break;
                    case 3:
                        Console.WriteLine("Enter the perimeter of the rhombus you want to remove: ");
                        var perimeterToRemove = Console.ReadLine();
                        if (perimeterToRemove == "")
                        {
                            Console.WriteLine("You have to enter the perimeter.");
                            break;
                        }
                        RemoveRhombusByPerimeter(ref rhombusArr, ref rhombusArrLength, perimeterToRemove);
                        break;
                    case 0:
                        return isStopped = false;
                    case 9:
                        isStopped2 = false;
                        break;
                }
            }
            return isStopped;
        }
        
        switch (choice)
        {
            case 1:
                RhombusArrCr(choice);
                SecondMenu();
                break;
            case 2:
                RhombusArrCr(choice);
                SecondMenu();
                break;
            case 0:
                return;
        }
    }
}

Main();