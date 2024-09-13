namespace Lab2;

public class ConsoleMenu : FigureClass
{
    public static string PrintLongThing() { return "------------------------------------------------------------"; }
    
    public static string FirstMenu() { 
        return "Choose a figure:\n" +
               "1. Trapezoid\n" +
               "2. Circle\n" +
               "3. Throw example of exception\n" +
               "4. TypeOfIsAs\n" +
               "0. Exit"; 
    }

    public static string SecondMenu()
    {
        return "Choose an action:\n" +
               "1. Print\n" +
               "2. Get Area\n" +
               "3. Get Perimeter\n" +
               "4. Get Info\n" +
               "5. Get Details\n" +
               "9. Previous menu\n" +
               "0. Exit";
    }
    
    public static string TrapezoidPrint(int i, FigureClass trapezoid) { return $"Trapezoid {i}: {trapezoid.Print()}"; }
    
    public static string CirclePrint(int i, FigureClass circle) { return $"Circle {i}: {circle.Print()}"; }
    
    public static string GetInfo(FigureClass figure) { return figure.GetInfo(); }
    
    public static string WrongInputError() { return "Wrong input."; }
    
    public static void ThrowExceptionForTask()
    {
        try
        {
            throw new InvalidOperationException("Example of exception");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Handled exception: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally block executed");
        }
    }
}