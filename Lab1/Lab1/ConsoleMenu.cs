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
    /*public static void SecondMenu()
    {
        Console.WriteLine("Enter your choice: ");
        Console.WriteLine("1. Print the array of rhombuses.");
        Console.WriteLine("2. Add a rhombus to the array.");
        Console.WriteLine("3. Remove a rhombus from the array by perimeter.");
        Console.WriteLine("4. Find a rhombus by perimeter.");
        Console.WriteLine("9. Return to the previous menu.");
        Console.WriteLine("0. Exit.");
    }*/
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

    public static int InputChoice(int choice)
    {
        try
        {
            return choice;
        }
        catch (Exception e)
        {
            Console.WriteLine(ConsoleMenu.WrongInputError());
        }
        return -1;
    }
    //!try
    //!{ secondChoice = Convert.ToInt32(Console.ReadLine()); }
    //!catch (Exception e) { Console.WriteLine(ConsoleMenu.WrongInputError()); ConsoleMenu.PrintLongThing(); continue; }
    
    public static void AskCoordinates(int rhombusNumber) { Console.WriteLine($"Enter the coordinates of the rhombus {rhombusNumber}: "); }
    public static string ConsolePrintRhombus(int rhombusNumber, RhombusClass rhombus) { return $"Coordinates of the RhombusClass {rhombusNumber}: {rhombus.Print()}"; }
    
    public static string AskPerimeterToRemove() { return "Enter the perimeter of the rhombus: "; }
    
    /*public static string PerimeterToRemove(string choice)
    {
        switch (choice)
        {
            case "Ask":
                //Console.WriteLine("Enter the perimeter of the rhombus you want to remove: ");
                return "Enter the perimeter of the rhombus you want to remove: ";
                break;
            case "Call":
                //var perimeter = Console.ReadLine();
                //if (perimeter == null) { Console.WriteLine("You have not entered the perimeter."); break; }
                //if (perimeter == null) { return "You have not entered the perimeter."; }
                //RhombusArrClass.RemoveRhombusByPerimeter(ref RhombusArrClass.RhombusArr, ref RhombusArrClass.RhombusArrLength, perimeter);
                break;
            case "NoRhombusError":
                //Console.WriteLine("There is no rhombus with such perimeter.");
                return "There is no rhombus with such perimeter.";
                break;
        }
        return "";
    }*/
    
    public static string RemoveByPerimeter(string data)
    {
        
       /* if (data == "NOT FOUND") { return "Rhombus not found"; }
        if (data == null) { return "You have not entered the perimeter."; }
        if (data == "FOUND")
        {
            return "Done.";
        }*/
        return RhombusArrClass.RemoveRhombusByPerimeter(ref RhombusArrClass.RhombusArr, ref RhombusArrClass.RhombusArrLength, data);
        //return "";
        //RhombusArrClass.RemoveRhombusByPerimeter(ref RhombusArrClass.RhombusArr, ref RhombusArrClass.RhombusArrLength, perimeter);
        //return "Done.";
        /*switch (choice)
        {
            case "Ask":
                //Console.WriteLine("Enter the perimeter of the rhombus you want to remove: ");
                return "Enter the perimeter of the rhombus you want to remove: ";
                break;
            case "Call":
                //var perimeter = Console.ReadLine();
                //if (perimeter == null) { Console.WriteLine("You have not entered the perimeter."); break; }
                if (perimeter == null) { return "You have not entered the perimeter."; }
                RhombusArrClass.RemoveRhombusByPerimeter(ref RhombusArrClass.RhombusArr, ref RhombusArrClass.RhombusArrLength, perimeter);
                break;
            case "NoRhombusError":
                //Console.WriteLine("There is no rhombus with such perimeter.");
                return "There is no rhombus with such perimeter.";
                break;
        }*/
        //return "";
    }
    public static void PerimeterToFind() { Console.WriteLine("Enter the perimeter of the rhombus you want to find: "); }
    public static string PrintLongThing() { return "------------------------------------------------------------"; }
}