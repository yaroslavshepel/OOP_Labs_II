namespace Lab3;

public static class ConsoleMenu
{
    public static string PrintLongThing()
    {
        return "------------------------------------------------------------";
    }
    
    public static string Menu()
    {
       return "1. Add Student\n" +
              "2. Display all students\n" +
              "3. Calculate the number of honors students of the 5th year\n" +
              "4. Save students to file\n" +
              "5. Read students from file\n" +
              "6. Remove student\n" +
              "7. Do something with entities\n" +
              "0. Exit\n" +
              "Enter your choice: ";
    }

    public static int ChoiceCheck()
    {
        var choice = -1;
        try { choice = Convert.ToInt32(Console.ReadLine()); }
        catch (FormatException)
        {
            throw new CustomException("Invalid input format. Please enter a number.");
        }
        catch (Exception ex)
        {
            throw new CustomException("An unexpected error occurred.", ex);
        }
        Console.WriteLine(ConsoleMenu.PrintLongThing());
        return choice;
    }
}