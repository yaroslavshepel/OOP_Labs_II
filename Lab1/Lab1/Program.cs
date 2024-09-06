namespace Lab1;

public class Program : RhombusArrClass
{
    public static void Main()
    {
        var isStopped = true;
        while (isStopped)
        {
            Console.WriteLine(ConsoleMenu.FirstMenu());
            var choice = ChoiceCheck();
            Console.Clear();
            ConsoleMenu.PrintLongThing();
            bool SecondMenu()
            {
                var isStopped2 = true;
                while (isStopped2)
                {
                    Console.WriteLine(ConsoleMenu.SecondMenu());
                    var secondChoice = ChoiceCheck();
                    Console.Clear();
                    switch (secondChoice)
                    {
                        case 1:
                            Console.Clear();
                            PrintRhombus();
                            break;
                        case 2:
                            Console.Clear();
                            RhombusArrClass.AddRhombus(ref RhombusArrClass.RhombusArr, ref RhombusArrClass.RhombusArrLength);
                            PrintRhombus();
                            break;
                        case 3:
                            Console.WriteLine(ConsoleMenu.AskPerimeterToRemove());
                            Console.WriteLine(ConsoleMenu.RemoveByPerimeter(Console.ReadLine()));
                            PrintRhombus();
                            break;
                        case 4:
                            Console.Clear();
                            PrintRhombus();
                            Console.WriteLine(ConsoleMenu.PerimeterToFind());
                            Console.WriteLine(ConsoleMenu.PerimeterFind(ref RhombusArrClass.RhombusArr, ref RhombusArrClass.RhombusArrLength, Console.ReadLine()));
                            Console.WriteLine(ConsoleMenu.PrintLongThing());
                            break;
                        case 0:
                            return isStopped = false;
                        case 9:
                            Console.WriteLine(ConsoleMenu.PrintLongThing());
                            Console.Clear();
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
                    Console.Clear();
                    SecondMenu();
                    ConsoleMenu.PrintLongThing();
                    break;
                case 2:
                    RhombusArrClass.RhombusArrCr(choice);
                    Console.Clear();
                    SecondMenu();
                    ConsoleMenu.PrintLongThing();
                    break;
                case 0:
                    return;
            }
        }
        void PrintRhombus()
        {
            Console.WriteLine(ConsoleMenu.PrintLongThing());
            for (var i = 0; i < RhombusArrClass.RhombusArrLength; i++)
            {
                Console.WriteLine(ConsoleMenu.RhombusPrint(i, RhombusArr[i]));
            }
            Console.WriteLine(ConsoleMenu.PrintLongThing());
        }
        
        int ChoiceCheck()
        {
            var choice = -1;
            try { choice = Convert.ToInt32(Console.ReadLine()); }
            catch { Console.Clear(); Console.WriteLine(ConsoleMenu.WrongInputError()); }
            Console.WriteLine(ConsoleMenu.PrintLongThing());
            return choice;
        }
    }
}

