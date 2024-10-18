namespace Lab4;

public class Product : IComparable<Product>
{
    private string _name {get; set;}
    private int _code {get; set;}
    private DateTime _productionDate {get; set;}
    private DateTime _expiryDate {get; set;}
    
    Product() { }
    
    public Product(string name, int code, DateTime productionDate, DateTime expiryDate)
    {
        _name = name;
        _code = code;
        _productionDate = productionDate;
        _expiryDate = expiryDate;
    }
    
    public string GetName() { return _name; }
    public int GetCode() { return _code; }
    public DateTime GetProductionDate() { return _productionDate; }
    public DateTime GetExpiryDate() { return _expiryDate; }
    
    public string PrintInfo()
    {
        return $"Name: {_name}, Code: {_code}, Production Date: {_productionDate}, Expiry Date: {_expiryDate}";
    }
    
    public bool IsFresh(DateTime currentDate)
    {
        return currentDate < _expiryDate;
    }
    
    public DateTime GetFinalDateOfSelling()
    {
        return _expiryDate.AddDays(-3);
    }
    
    public int CompareTo(Product other)
    {
        if (other == null)
        {
            return 1;
        }
        return _code.CompareTo(other._code);
    }
}