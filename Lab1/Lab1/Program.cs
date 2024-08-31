using System;
using Lab1.Classes;
int rhombusArrLenght = 7;
Rhombus[] rhombusArr = new Rhombus[7];
Random Random = new Random();

Rhombus CreateRhombusObj()
{
    Rhombus rhombusTemp = new Rhombus();
    Console.WriteLine("Enter the coordinates of the rhombus: ");
    double x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0, x4 = 0, y4 = 0, x = 0, y = 0;
    for (int j = 0; j < 4; j++)
    {
        try
        {
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
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
    rhombusTemp = new Rhombus(x1, y1, x2, y2, x3, y3, x4, y4);
    return rhombusTemp;
}

Rhombus RandRhombusArrObj()
{
    Rhombus rhombusTemp = new Rhombus();
    double x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0, x4 = 0, y4 = 0, x = 0, y = 0;
    for (int j = 0; j < 4; j++)
    {
        x = Random.Next(1, 10);
        y = Random.Next(1, 10);
        switch (j)
        {
            case 0: x1 = x; y1 = y; break;
            case 1: x2 = x; y2 = y; break;
            case 2: x3 = x; y3 = y; break;
            case 3: x4 = x; y4 = y; break;
        }
    }
    rhombusTemp = new Rhombus(x1, y1, x2, y2, x3, y3, x4, y4);
    return rhombusTemp;
    //rhombusArr[i] = new Rhombus(x1, y1, x2, y2, x3, y3, x4, y4);
}

void RhombusArrCr()
{
    for (int i = 0; i < rhombusArr.Length; i++)
    {
        try
        {
            //!rhombusArr[i] = CreateRhombusObj();
            rhombusArr[i] = RandRhombusArrObj();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            i--;
        }
    }
}




/*void AddRhombus(ref Rhombus[] array, Rhombus newRhombus)
{
    
    Array.Resize(ref array, array.Length + 1);
    array[array.Length - 1] = newRhombus;
}*/

void PrintRhombusArr(Rhombus[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        //Console.WriteLine(array[i].Print());
        Console.WriteLine($"$Coordinates of the Rhombus {i + 1}: {array[i].Print()}");
    }
}

RhombusArrCr();

//AddRhombus(ref rhombusArr, new Rhombus(1, 1, 2, 2, 3, 3, 4, 4));

PrintRhombusArr(rhombusArr);
