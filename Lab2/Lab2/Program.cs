namespace Lab2;
public class Program : FiguresArrClass
{
    public static void Main()
    {
        var isStopped = true;
        while (isStopped)
        {
            Console.WriteLine(ConsoleMenu.FirstMenu());
            var choice = ChoiceCheck();
            var figureChoice = "";
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
                            PrintFigure(figureChoice);
                            break;
                        case 2:
                            Console.Clear();
                            AreaPerimeter(figureChoice, "Area");
                            break;
                        case 3:
                            Console.Clear();
                            AreaPerimeter(figureChoice, "Perimeter");
                            break;
                        case 9:
                            Console.WriteLine(ConsoleMenu.PrintLongThing());
                            Console.Clear();
                            isStopped2 = false;
                            break;
                        case 4:
                            Console.Clear();
                            GetInfoOrDetails(figureChoice, "Info");
                            break;
                        case 5:
                            Console.Clear();
                            GetInfoOrDetails(figureChoice, "Details");
                            break;
                        case 0:
                            return isStopped = false;
                    }
                }
                return isStopped;
            }
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    figureChoice = "Trapezoid";
                    FiguresArrClass.UserChoice(figureChoice);
                    SecondMenu();
                    break;
                case 2:
                    Console.Clear();
                    figureChoice = "Circle";
                    FiguresArrClass.FiguresArrClassCreation(figureChoice);
                    SecondMenu();
                    break;
                case 3:
                    Console.Clear();
                    ConsoleMenu.ThrowExceptionForTask();
                    break;
                case 4:
                    Console.Clear();
                    TypeOfIsAs();
                    break;
                case 5:
                    //CustomException();
                    break;
                case 0:
                    return;
            }
        }
        
        void PrintFigure(string choice)
        {
            switch (choice)
            {
                case "Trapezoid":
                    Console.WriteLine(ConsoleMenu.PrintLongThing());
                    for (var i = 0; i < FiguresArrClass.NumberOfFigures; i++)
                    {
                        Console.WriteLine(ConsoleMenu.TrapezoidPrint(i, FiguresArr[0][i]));
                    }
                    Console.WriteLine(ConsoleMenu.PrintLongThing());
                    break;
                case "Circle":
                    Console.WriteLine(ConsoleMenu.PrintLongThing());
                    for (var i = 0; i < FiguresArrClass.NumberOfFigures; i++)
                    {
                        Console.WriteLine(ConsoleMenu.CirclePrint(i, FiguresArr[1][i]));
                    }
                    Console.WriteLine(ConsoleMenu.PrintLongThing());
                    break;
            }
            
        }
        
        void GetInfoOrDetails(string figure, string infoOrDetails)
        {
            switch (figure)
            {
                case "Trapezoid":
                    switch (infoOrDetails)
                    {
                        case "Info":
                            Console.WriteLine(ConsoleMenu.GetInfo(FiguresArr[0][0]));
                            break;
                        case "Details":
                            Console.WriteLine(FiguresArr[0][0].GetDetails());
                            break;
                    }
                    break;
                case "Circle":
                    switch (infoOrDetails)
                    {
                        case "Info":
                            Console.WriteLine(ConsoleMenu.GetInfo(FiguresArr[1][0]));
                            break;
                        case "Details":
                            Console.WriteLine(FiguresArr[1][0].GetDetails());
                            break;
                    }
                    break;
            }   
        }

        void TypeOfIsAs()
        {
            FigureClass figure = new CircleClass(5);
            Console.WriteLine($"Type of figure: {figure.GetType()}"); //typeof

            if (figure is CircleClass circle)
            {
                Console.WriteLine($"This is a circle with radius: {circle.GetDetails()}");
            }

            CircleClass circleAs;
            try
            {
                circleAs = figure as CircleClass;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            if (circleAs != null)
            {
                Console.WriteLine($"This is a circle with radius: {circleAs.GetDetails()}");
            }
        }
        
        void AreaPerimeter(string figure, string areaOrPerimeter)
        {
            switch (figure)
            {
                case "Trapezoid":
                    switch (areaOrPerimeter)
                    {
                        case "Area":
                            foreach (var trapezoid in FiguresArr[0]) { Console.WriteLine(trapezoid.GetArea()); }
                            break;
                        case "Perimeter":
                            foreach (var trapezoid in FiguresArr[0]) { Console.WriteLine(trapezoid.GetPerimeter()); }
                            break;
                    }
                    break;
                case "Circle":
                    switch (areaOrPerimeter)
                    {
                        case "Area":
                            foreach (var circle in FiguresArr[1]) { Console.WriteLine(circle.GetArea()); }
                            break;
                        case "Perimeter":
                            foreach (var circle in FiguresArr[1]) { Console.WriteLine(circle.GetPerimeter()); }
                            break;
                    }
                    break;
            }
        }
        
        int ChoiceCheck()
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
}