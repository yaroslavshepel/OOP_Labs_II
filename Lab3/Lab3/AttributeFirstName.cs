namespace Lab3;

public class AttributeFirstName : Attribute
{
    public string FirstName { get; set; }
    
    public string AttributeFirstName1(string firstName)
    {
        FirstName = firstName;
        return firstName;
    }
}