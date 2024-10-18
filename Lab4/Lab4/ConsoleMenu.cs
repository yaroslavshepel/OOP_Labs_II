namespace Lab4;

public class ConsoleMenu
{
    public static string PrintLongThing()
    {
        return "------------------------------------------------------------";
    }
    
    public static string Menu()
    {
        return "1. Generic collection\n" +
               "2. Non-Genetic collection\n" +
               "3. Array\n" +
               "4. Binary tree\n" +
               "0. Exit\n" +
               "Enter your choice: ";
    }
    
    public static string MenuOfGenetic()
    {
        return "1. Add product\n" +
               "2. Remove product\n" +
               "3. Update product\n" +
               "4. Find product by name\n" +
               "5. Print all products\n" +
               "6. Print fresh products\n" +
               "7. Print expiring products\n" +
               "8. Return to main menu\n" +
               "Enter your choice: ";
    }
    
    public static string MenuOfNonGenetic()
    {
        return "1. Add product\n" +
               "2. Remove product\n" +
               "3. Update product\n" +
               "4. Find product by name\n" +
               "5. Print all products\n" +
               "6. Print fresh products\n" +
               "7. Print expiring products\n" +
               "8. Return to main menu\n" +
               "Enter your choice: ";
    }
}