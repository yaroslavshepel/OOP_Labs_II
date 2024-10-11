namespace Lab3;

public class CustomException : Exception
{
    public CustomException()
    {
        throw new Exception("Custom exception");
    }
    
    public CustomException(string message) : base(message) { }
    
    public CustomException(string message, Exception inner) : base(message, inner) { }
}