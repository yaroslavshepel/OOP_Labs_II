namespace Lab3;

using System.Text.Json;
class Program : StudentArr
{
    public static async Task Main()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        await IFunctions.ReadData(0);
        decimal amount = 0;
        var isStopped = true;
        while (isStopped)
        {
            Console.WriteLine(ConsoleMenu.Menu());
            var choice = Convert.ToInt32(IFunctions.InputCheck("Menu"));

            Console.Clear();
            ConsoleMenu.PrintLongThing();
            
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    await IFunctions.AddNewStudentToFile();
                    Console.WriteLine(ConsoleMenu.PrintLongThing());
                    break;
                case 2:
                    Console.Clear();
                    await IFunctions.ReadData(1);
                    Console.WriteLine(ConsoleMenu.PrintLongThing());
                    break;
                case 3:
                    Console.Clear();
                    await IFunctions.DoTask();
                    Console.WriteLine(ConsoleMenu.PrintLongThing());
                    break;
                case 4:
                    Console.Clear();
                    await IFunctions.SaveStudentsToFile();
                    break;
                case 5:
                    Console.Clear();
                    await IFunctions.ReadData(0);
                    break;
                case 6:
                    Console.Clear();
                    await IFunctions.RemoveStudentFromFile();
                    break;
                case 7:
                    Console.Clear();
                    await IFunctions.DoSomethingWithEntities();
                    Console.WriteLine(ConsoleMenu.PrintLongThing());
                    break;
                case 0:
                    return;
            }
        }
    }
}
