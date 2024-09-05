namespace Lab1;

public class Program : RhombusArrClass
{
    public static void Main()
    {
        int ChoiceCheck()
        {
            int choice = -1;
            try { choice = ConsoleMenu.InputChoice(Convert.ToInt32(Console.ReadLine())); }
            catch (Exception e) { Console.WriteLine(ConsoleMenu.WrongInputError() + "\n" + ConsoleMenu.PrintLongThing()); }
            Console.WriteLine(ConsoleMenu.PrintLongThing());
            return choice;
        }
        
        bool isStopped = true;
        while (isStopped)
        {
            Console.WriteLine(ConsoleMenu.FirstMenu());
            int choice = ChoiceCheck();
            ConsoleMenu.PrintLongThing();
            bool SecondMenu()
            {
                var isStopped2 = true;
                while (isStopped2)
                {
                    Console.WriteLine(ConsoleMenu.SecondMenu());
                    var secondChoice = ChoiceCheck();
                    switch (secondChoice)
                    {
                        case 1:
                            for (var i = 0; i < RhombusArrClass.RhombusArrLength; i++) { Console.WriteLine(ConsoleMenu.ConsolePrintRhombus(i, RhombusArrClass.RhombusArr[i])); }
                            Console.WriteLine(ConsoleMenu.PrintLongThing());
                            break;
                        case 2:
                            RhombusArrClass.AddRhombus(ref RhombusArrClass.RhombusArr, ref RhombusArrClass.RhombusArrLength);
                            Console.WriteLine(ConsoleMenu.PrintLongThing());
                            break;
                        case 3:
                            Console.WriteLine(ConsoleMenu.AskPerimeterToRemove());
                            Console.WriteLine(ConsoleMenu.RemoveByPerimeter(Console.ReadLine()));
                            ConsoleMenu.PrintLongThing();
                            break;
                        case 4:
                            ConsoleMenu.PerimeterToFind();
                            break;
                        case 0:
                            return isStopped = false;
                            //isStopped = false;
                            //break;
                        case 9:
                            Console.WriteLine(ConsoleMenu.PrintLongThing());
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

