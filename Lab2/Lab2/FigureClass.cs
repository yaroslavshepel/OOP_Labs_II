namespace Lab2;

public class FigureClass
{
    /*public FigureClass()
    {
        ConsoleMenu.PrintSomething("Figure constructor called");
    }*/
    
    /*public virtual string Display()
    {
        //Console.WriteLine("Figure: area and perimeter are calculated.");
        return "Figure: area and perimeter are calculated.";
    }*/
    public virtual string GetArea()
    {
        return "0";
    }
    
    public virtual string Print()
    {
        return "Figure: area and perimeter are calculated.";
    }
    
    public virtual string GetPerimeter()
    {
        return "0";
    }
    ~FigureClass()
    {
        Console.WriteLine("Figure destructor called");
    }
}