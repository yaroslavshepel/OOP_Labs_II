namespace Lab2;

public abstract class FigureClass
{
    public virtual string GetArea()
    {
        return "0";
    }
    
    public virtual string Print()
    {
        return "Figure: area and perimeter are calculated.";
    }

    public abstract string GetPerimeter();
    
    public virtual string GetInfo()
    {
        return "This is a figure.";
    }
    
    public string GetDetails()
    {
        return "Figure details.";
    }
    ~FigureClass()
    {
        Console.WriteLine("Figure destructor called");
    }
}