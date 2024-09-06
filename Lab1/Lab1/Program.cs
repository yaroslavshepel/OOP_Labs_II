namespace Lab1;

public class Program : RhombusArrClass
{
    public static void Main()
    {
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
            int choice = -1;
            try { choice = Convert.ToInt32(ConsoleMenu.InputChoice(Console.ReadLine())); }
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
                            Console.Clear();
                            //Console.WriteLine(ConsoleMenu.PrintLongThing());
                            //for (var i = 0; i < RhombusArrClass.RhombusArrLength; i++) { Console.WriteLine(ConsoleMenu.PrintRhombus(i, RhombusArrClass.RhombusArr[i])); }
                            PrintRhombus();
                            //Console.WriteLine(ConsoleMenu.PrintLongThing());
                            break;
                        case 2:
                            Console.Clear();
                            RhombusArrClass.AddRhombus(ref RhombusArrClass.RhombusArr, ref RhombusArrClass.RhombusArrLength);
                            PrintRhombus();
                            //Console.WriteLine(ConsoleMenu.PrintLongThing());
                            break;
                        case 3:
                            Console.WriteLine(ConsoleMenu.AskPerimeterToRemove());
                            Console.WriteLine(ConsoleMenu.RemoveByPerimeter(Console.ReadLine()));
                            //Console.Clear();
                            //ConsoleMenu.PrintLongThing();
                            PrintRhombus();
                            //Console.WriteLine(ConsoleMenu.PrintLongThing());
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
    }
}

