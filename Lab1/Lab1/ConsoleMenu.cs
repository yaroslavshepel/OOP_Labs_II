namespace Lab1;

public class ConsoleMenu : RhombusArrClass
{
    /*public static void FirstMenu()
    {
        Console.WriteLine("Enter your choice: ");
        Console.WriteLine("0. Exit.");
        Console.WriteLine("1. Create an array of rhombuses on your own.");
        Console.WriteLine("2. Create an array of rhombuses randomly.");
    }*/

    public static string FirstMenu()
    {
        return "Enter your choice: \n" +
               "0. Exit.\n" +
               "1. Create an array of rhombuses on your own.\n" +
               "2. Create an array of rhombuses randomly.";
    }
    
    public static string WrongInputError() { return "Wrong input."; }

    public static string SecondMenu()
    {
        return "Enter your choice: \n" +
               "1. Print the array of rhombuses.\n" +
               "2. Add a rhombus to the array.\n" +
               "3. Remove a rhombus from the array by perimeter.\n" +
               "4. Find a rhombus by perimeter.\n" +
               "9. Return to the previous menu.\n" +
               "0. Exit.";
    }

    public static string InputChoice(string choice)
    {
        if (choice == null) return WrongInputError();
        else
        {
            return choice;
        }
        /*try
        {
            return choice;
        }
        catch (Exception e)
        {
            //Console.WriteLine(ConsoleMenu.WrongInputError());
            return WrongInputError();
        }*/
        return "-1";
    }

    public static string PrintShit()
    {
        for (var i = 0; i < RhombusArrClass.RhombusArrLength; i++)
        {
            //return ConsoleMenu.ConsolePrintRhombus(i, RhombusArrClass.RhombusArr[i]);
        }
        return "";
    }
    
    /*public static string RhombusPrint(int rhombusNumber, RhombusClass rhombus)
    {
        return $"Rhombus {rhombusNumber}: {rhombus.Print()}";
    }*/
    
    public static string RhombusPrint(int i, RhombusClass rhombus)
    {
            return $"Rhombus {i}: {rhombus.Print()}";
        
        //return $"Rhombus {rhombusNumber}: {rhombus.Print()} Perimeter: {perimeter}";
        return "";
    }

    public static void AskCoordinates(int rhombusNumber) { Console.WriteLine($"Enter the coordinates of the rhombus {rhombusNumber}: "); }
    
    //public static string ConsolePrintRhombus(int rhombusNumber, RhombusClass rhombus) { return $"Coordinates of the RhombusClass {rhombusNumber}: {rhombus.Print()}"; }
    
    public static string AskPerimeterToRemove() { return "Enter the perimeter of the rhombus: "; }

    public static string RemoveByPerimeter(string data)
    {
        Console.Clear();
        return RhombusArrClass.RemoveRhombusByPerimeter(ref RhombusArrClass.RhombusArr, ref RhombusArrClass.RhombusArrLength, data);
    }
    public static string PerimeterToFind() { return "Enter the perimeter of the rhombus you want to find: "; }
    public static string PrintLongThing() { return "------------------------------------------------------------"; }
}