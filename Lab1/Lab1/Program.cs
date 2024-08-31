namespace Lab1;

public class Program : RhombusArrClass
{
    public static void Main()
    {
        bool isStopped = true;
        while (isStopped)
        {
            ConsoleMenu.FirstMenu();

            var choice = 0;//Convert.ToInt32(Console.ReadLine());
            try
            { choice = Convert.ToInt32(Console.ReadLine()); }
            catch (Exception e) { Console.WriteLine("This is not a number."); ConsoleMenu.PrintLongThing(); continue; }
            ConsoleMenu.PrintLongThing();
            bool SecondMenu()
            {
                var isStopped2 = true;
                while (isStopped2)
                {
                    ConsoleMenu.SecondMenuInterface();
                    ConsoleMenu.PrintLongThing();
                    var secondChoice = 0;
                    try
                    { secondChoice = Convert.ToInt32(Console.ReadLine()); }
                    catch (Exception e) { Console.WriteLine("This is not a number."); ConsoleMenu.PrintLongThing(); continue; }
                    
                    switch (secondChoice)
                    {
                        case 1:
                            RhombusArrClass.PrintRhombusArr (RhombusArrClass.RhombusArr, ref RhombusArrClass.RhombusArrLength);
                            ConsoleMenu.PrintLongThing();
                            break;
                        case 2:
                            RhombusArrClass.AddRhombus(ref RhombusArrClass.RhombusArr, ref RhombusArrClass.RhombusArrLength);
                            ConsoleMenu.PrintLongThing();
                            break;
                        case 3:
                            ConsoleMenu.PerimeterToRemove("Ask");
                            //ConsoleMenu.PrintLongThing();
                            ConsoleMenu.PerimeterToRemove("Call");
                            ConsoleMenu.PrintLongThing();
                            break;
                        case 4:
                            ConsoleMenu.PerimeterToFind();
                            break;
                        case 0:
                            return isStopped = false;
                        case 9:
                            isStopped2 = false;
                            break;
                    }
                }
                return isStopped;
            }
            switch (choice)
            {
                case 1:
                    RhombusArrClass.RhombusArrCr(choice);
                    SecondMenu();
                    ConsoleMenu.PrintLongThing();
                    break;
                case 2:
                    RhombusArrClass.RhombusArrCr(choice);
                    SecondMenu();
                    ConsoleMenu.PrintLongThing();
                    break;
                case 0:
                    return;
            }
        }
    }
}

