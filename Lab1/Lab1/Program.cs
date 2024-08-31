using System;
using Lab1.Classes;

void rhombusArrCr()
{
    Rhombus[] rhombusArr = new Rhombus[1];
    for (int i = 0; i < rhombusArr.Length; i++)
    {

        try
        {
            Console.WriteLine($"Enter the coordinates of the rhombus {i + 1}: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            double x4 = Convert.ToDouble(Console.ReadLine());
            double y4 = Convert.ToDouble(Console.ReadLine());

            rhombusArr[i] = new Rhombus(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            i--;
        }
    }
}
//Rhombus rhombusArr = new Rhombus[1];
//void 

void AddRhombus(ref Rhombus[] array, Rhombus newRhombus)
{
    Array.Resize(ref array, array.Length + 1);
    array[array.Length - 1] = newRhombus;
}

namespace Lab1
{

    public class Program
    {
        public static void Main()
        {
            /*try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }*/
            
            //Rhombus[] rhombusArr = new Rhombus[1];
            /*for (int i = 0; i < rhombusArr.Length; i++)
            {

                try
                {
                    Console.WriteLine($"Enter the coordinates of the rhombus {i + 1}: ");
                    double x1 = Convert.ToDouble(Console.ReadLine());
                    double y1 = Convert.ToDouble(Console.ReadLine());
                    double x2 = Convert.ToDouble(Console.ReadLine());
                    double y2 = Convert.ToDouble(Console.ReadLine());
                    double x3 = Convert.ToDouble(Console.ReadLine());
                    double y3 = Convert.ToDouble(Console.ReadLine());
                    double x4 = Convert.ToDouble(Console.ReadLine());
                    double y4 = Convert.ToDouble(Console.ReadLine());

                    rhombusArr[i] = new Rhombus(x1, y1, x2, y2, x3, y3, x4, y4);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    i--;
                }
                
                
            }*/
/*
            // Demonstrate adding a new Rhombus
            Console.WriteLine("Adding a new Rhombus:");
            AddRhombus(ref rhombusArr, new Rhombus(1, 1, 2, 2, 3, 3, 4, 4));
            PrintArray(rhombusArr);

            // Demonstrate removing a Rhombus
            Console.WriteLine("Removing a Rhombus:");
            RemoveRhombus(ref rhombusArr, 0);
            PrintArray(rhombusArr);

            // Demonstrate searching for a Rhombus
            Console.WriteLine("Searching for a Rhombus with perimeter > 10:");
            Rhombus found = SearchRhombus(rhombusArr, r => r.GetPerimeter() > 10);
            if (found != null)
            {
                Console.WriteLine(found.Print());
            }
            else
            {
                Console.WriteLine("No Rhombus found with the specified criteria.");
            }*/
        }

        /*public static void AddRhombus(ref Rhombus[] array, Rhombus newRhombus)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = newRhombus;
        }

        public static void RemoveRhombus(ref Rhombus[] array, int index)
        {
            if (index < 0 || index >= array.Length) return;
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
        }

        public static Rhombus SearchRhombus(Rhombus[] array, Func<Rhombus, bool> predicate)
        {
            foreach (var rhombus in array)
            {
                if (predicate(rhombus))
                {
                    return rhombus;
                }
            }
            return null;
        }

        public static void PrintArray(Rhombus[] array)
        {
            foreach (var rhombus in array)
            {
                Console.WriteLine(rhombus.Print());
            }
        }*/
    }
}

/*

using Lab1.Classes;

namespace Lab1;



public class Program
{
    public static void RhombusArr()
    {
        
    }
    
    public static void Main()
    {
        //Rhombus rhombus1 = new Rhombus(11, 2.2, 3.5, 4, 13, 5, 10, 6);
        //rhombus1.Print();
        //Console.WriteLine(rhombus1.Print());
        //Console.WriteLine($"Area: {rhombus1.GetArea()}");
        
        //Console.WriteLine(($"Distance: {rhombus1.Distance(11, 2.2, 3.5, 4)}"));
        //Console.WriteLine($"Perimeter: {rhombus1.GetPerimeter()}");
        
        /*Rhombus[] rhombusArr = new Rhombus[2];
        for (int i = 0; i < rhombusArr.Length; i++)
        {
            Console.WriteLine($"Enter the coordinates of the rhombus {i}: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            double x4 = Convert.ToDouble(Console.ReadLine());
            double y4 = Convert.ToDouble(Console.ReadLine());
            
            //double x1, x2, x3, x4, y1, y2, y3, y4 = Convert.ToDouble(Console.ReadLine());
            rhombusArr[i] = new Rhombus(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        rhombusArr[0].Print();
        Console.WriteLine(rhombusArr[0].Print());
        Console.WriteLine($"Area: {rhombusArr[0].GetArea()}");
        Console.WriteLine($"Perimeter: {rhombusArr[0].GetPerimeter()}");
        
        
    }
}*/