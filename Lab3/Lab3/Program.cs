namespace Lab3;

using System.Text.Json;
class Program : StudentArr
{
    public static async Task Main()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        await Functions.ReadData(0);
        while (true)
        {
            Console.WriteLine(ConsoleMenu.Menu());
            var choice = Convert.ToInt32(Functions.InputCheck("Menu"));

            Console.Clear();
            ConsoleMenu.PrintLongThing();
            
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    await Functions.AddNewStudentToFile();
                    Console.WriteLine(ConsoleMenu.PrintLongThing());
                    break;
                case 2:
                    Console.Clear();
                    await Functions.ReadData(1);
                    Console.WriteLine(ConsoleMenu.PrintLongThing());
                    break;
                case 3:
                    Console.Clear();
                    await Functions.DoTask();
                    Console.WriteLine(ConsoleMenu.PrintLongThing());
                    break;
                case 4:
                    Console.Clear();
                    await Functions.SaveStudentsToFile();
                    break;
                case 5:
                    Console.Clear();
                    await Functions.ReadData(0);
                    break;
                case 6:
                    Console.Clear();
                    await Functions.RemoveStudentFromFile();
                    break;
                case 7:
                    Console.Clear();
                    await Functions.DoSomethingWithEntities();
                    Console.WriteLine(ConsoleMenu.PrintLongThing());
                    break;
                case 0:
                    return;
            }
        }
    }
}
