namespace Lab2;

public class ConsoleMenu : FigureClass
{
    public static string PrintSomething(string message) { return message; }
    
    public static string PrintLongThing() { return "------------------------------------------------------------"; }
    
    public static string FirstMenu() { return "Choose a figure:\n1. Trapezoid\n2. Circle\n3. Exit"; }

    public static string SecondMenu()
    {
        //FiguresArrClass.FiguresArrClassCreation(choice);
        return "Choose an action:\n1. Print\n2. Get Area\n3. Get Perimeter\n4. Previous menu\n0. Exit";
    }
    
    public static string TrapezoidPrint(int i, TrapezoidClass trapezoid) { return $"Trapezoid {i}: {trapezoid.Print()}"; }
    
    public static string CirclePrint(int i, CircleClass circle) { return $"Circle {i}: {circle.Print()}"; }
    
    public static string WrongInputError() { return "Wrong input."; }
}