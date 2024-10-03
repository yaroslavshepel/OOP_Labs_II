namespace Lab3;

public class AttributeLastName : Attribute
{
    public string LastName { get; set; }
    
    public AttributeLastName(string lastName)
    {
        LastName = lastName;
        //return lastName;
    }
}