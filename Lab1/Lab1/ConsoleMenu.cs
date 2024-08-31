namespace Lab1;

public class ConsoleMenu : RhombusArrClass
{
    public static void FirstMenu()
    {
        Console.WriteLine("Enter your choice: ");
        Console.WriteLine("0. Exit.");
        Console.WriteLine("1. Create an array of rhombuses on your own.");
        Console.WriteLine("2. Create an array of rhombuses randomly.");
    }
    
    public static void SecondMenuInterface()
    {
        Console.WriteLine("Enter your choice: ");
        Console.WriteLine("1. Print the array of rhombuses.");
        Console.WriteLine("2. Add a rhombus to the array.");
        Console.WriteLine("3. Remove a rhombus from the array by perimeter.");
        Console.WriteLine("4. Find a rhombus by perimeter.");
        Console.WriteLine("9. Return to the previous menu.");
        Console.WriteLine("0. Exit.");
    }

    public static void AskCoordinates(int rhombusNumber) { Console.WriteLine($"Enter the coordinates of the rhombus {rhombusNumber}: "); }
    public static void ConsolePrintRhombus(int rhombusNumber, RhombusClass rhombus) { Console.WriteLine($"Coordinates of the RhombusClass {rhombusNumber}: {rhombus.Print()}"); }
    public static void PerimeterToRemove(string choice)
    {
        switch (choice)
        {
            case "Ask":
                Console.WriteLine("Enter the perimeter of the rhombus you want to remove: ");
                break;
            case "Call":
                var perimeter = Console.ReadLine();
                if (perimeter == null) { Console.WriteLine("You have not entered the perimeter."); break; }
                RhombusArrClass.RemoveRhombusByPerimeter(ref RhombusArrClass.RhombusArr, ref RhombusArrClass.RhombusArrLength, perimeter);
                break;
            case "NoRhombusError":
                Console.WriteLine("There is no rhombus with such perimeter.");
                break;
        }
    }
    public static void PerimeterToFind() { Console.WriteLine("Enter the perimeter of the rhombus you want to find: "); }
    public static void PrintLongThing() { Console.WriteLine("------------------------------------------------------------"); }
}