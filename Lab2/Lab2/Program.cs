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
                    //Console.Clear();
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
                            break;
                        case 3:
                            break;
                        case 4:
                            Console.WriteLine(ConsoleMenu.PrintLongThing());
                            Console.Clear();
                            isStopped2 = false;
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
                    //Console.WriteLine(ConsoleMenu.SecondMenu());
                    SecondMenu();
                    break;
                case 2:
                    Console.Clear();
                    figureChoice = "Circle";
                    FiguresArrClass.FiguresArrClassCreation(figureChoice);
                    //Console.WriteLine(ConsoleMenu.SecondMenu());
                    SecondMenu();
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
                        Console.WriteLine(ConsoleMenu.TrapezoidPrint(i, TrapezoidArr[i]));
                    }
                    Console.WriteLine(ConsoleMenu.PrintLongThing());
                    break;
                case "Circle":
                    Console.WriteLine(ConsoleMenu.PrintLongThing());
                    for (var i = 0; i < FiguresArrClass.NumberOfFigures; i++)
                    {
                        Console.WriteLine(ConsoleMenu.CirclePrint(i, CircleArr[i]));
                    }
                    Console.WriteLine(ConsoleMenu.PrintLongThing());
                    break;
            }
            
        }
        
        int ChoiceCheck()
        {
            var choice = -1;
            try { choice = Convert.ToInt32(Console.ReadLine()); }
            catch { Console.Clear(); Console.WriteLine(ConsoleMenu.WrongInputError()); }
            Console.WriteLine(ConsoleMenu.PrintLongThing());
            return choice;
        }
        // Random random = new();
        // double[][] coordinates = new double[2][];
        // coordinates[0] = new double[4];
        // coordinates[1] = new double[4];
        // for (var j = 0; j < 5; j++)
        // {
        //     for (var i = 0; i < 4; i++)
        //     {
        //         coordinates[0][i] = random.Next(-100, 100);
        //         coordinates[1][i] = random.Next(-100, 100);
        //     }
        //     TrapezoidClass trapezoid = new TrapezoidClass(coordinates);
        //     Console.WriteLine("Area: " + trapezoid.GetArea());
        //     //Console.WriteLine("\n");
        //     Console.WriteLine("Perimeter: " + trapezoid.GetPerimeter());
        // }
    }
}

/*using System;

abstract class Figure
{
    public abstract double GetArea();
    public abstract double GetPerimeter();

    // Віртуальний метод, який можна перевизначити
    public virtual void Display()
    {
        Console.WriteLine("Figure: area and perimeter are calculated.");
    }

    // Конструктор
    public Figure()
    {
        Console.WriteLine("Figure constructor called");
    }

    // Деструктор
    ~Figure()
    {
        Console.WriteLine("Figure destructor called");
    }
}

class Trapezoid : Figure
{
    private double[] vertices; // Масив для координат вершин

    public Trapezoid(double[] vertices)
    {
        this.vertices = vertices;
        Console.WriteLine("Trapezoid constructor called");
    }

    public override double GetArea()
    {
        // Площа трапеції, припустимо, що це довільна формула
        return 0.5 * (vertices[2] - vertices[0]) * (vertices[1] - vertices[3]);
    }

    public override double GetPerimeter()
    {
        // Приклад обчислення периметра трапеції
        return Math.Sqrt(Math.Pow(vertices[2] - vertices[0], 2) + Math.Pow(vertices[1] - vertices[3], 2));
    }

    public override void Display()
    {
        Console.WriteLine("Trapezoid: Area and Perimeter are calculated.");
    }

    ~Trapezoid()
    {
        Console.WriteLine("Trapezoid destructor called");
    }
}

class Circle : Figure
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
        Console.WriteLine("Circle constructor called");
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public override void Display()
    {
        Console.WriteLine("Circle: Area and Perimeter are calculated.");
    }

    ~Circle()
    {
        Console.WriteLine("Circle destructor called");
    }
}

class ConsoleMenu
{
    public void DisplayMenu()
    {
        try
        {
            // Примусове викликання винятку для демонстрації
            throw new InvalidOperationException("Example of exception");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Handled exception: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally block executed");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Figure trapezoid = new Trapezoid(new double[] { 0, 0, 5, 3 });
        Console.WriteLine($"Trapezoid Area: {trapezoid.GetArea()}");
        Console.WriteLine($"Trapezoid Perimeter: {trapezoid.GetPerimeter()}");
        trapezoid.Display();

        Figure circle = new Circle(5);
        Console.WriteLine($"Circle Area: {circle.GetArea()}");
        Console.WriteLine($"Circle Perimeter: {circle.GetPerimeter()}");
        circle.Display();

        ConsoleMenu menu = new ConsoleMenu();
        menu.DisplayMenu();
    }
}
*/