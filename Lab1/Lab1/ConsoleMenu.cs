namespace Lab1;

public class ConsoleMenu : RhombusArrClass
{
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

    public static string RhombusPrint(int i, RhombusClass rhombus) { return $"Rhombus {i}: {rhombus.Print()}"; }

    public static void AskCoordinates(int rhombusNumber) { Console.WriteLine($"Enter the coordinates (x \\n y) of the rhombus {rhombusNumber}: "); }
    
    public static string AskPerimeterToRemove() { return "Enter the perimeter of the rhombus: "; }

    public static string RemoveByPerimeter(string data)
    {
        Console.Clear();
        return RhombusArrClass.RemoveRhombusByPerimeter(ref RhombusArrClass.RhombusArr, ref RhombusArrClass.RhombusArrLength, data);
    }
    public static string PerimeterToFind() { return "Enter the perimeter of the rhombus you want to find: "; }
    public static string PrintLongThing() { return "------------------------------------------------------------"; }
}