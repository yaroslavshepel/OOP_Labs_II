namespace Lab4;

public class Array
{
    static Product[] productsArray = new Product[3];
    private static int count = 0;
    
    public Array() { }
    
    public static void AddProduct(string name, int code, DateTime productionDate, DateTime expiryDate)
    {
        for (int i = 0; i < productsArray.Length; i++)
        {
            if (productsArray[i] == null)
            {
                productsArray[i] = new Product(name, code, productionDate, expiryDate);
                break;
            }
        }
    }
    
    public static void RemoveProduct(string name)
    {
        for (int i = 0; i < productsArray.Length; i++)
        {
            if (productsArray[i].GetName() == name)
            {
                productsArray[i] = null;
                break;
            }
        }
    }
    
    public static void UpdateProduct(string name, Product newProduct)
    {
        int index = FindProduct(name, 0);
        if (index >= 0)
        {
            productsArray[index] = newProduct;
        }
    }
    
    public static int FindProduct(string name, int operation)
    {
        for (int i = 0; i < count; i++)
        {
            if (productsArray[i].GetName() == name)
            {
                switch (operation)
                {
                    case 1:
                        return i;
                    case 2:
                        PrintProduct(i);
                        break;
                }
            }
        }
        return -1;
    }
    
    public static string PrintProduct(int index)
    {
        return productsArray[index].PrintInfo();
    }
    
    public static void PrintProducts()
    {
        foreach (Product product in productsArray)
        {
            Console.WriteLine(product.PrintInfo());
        }
    }
    
    public static void PrintFreshProducts(DateTime currentDate)
    {
        foreach (Product product in productsArray)
        {
            if (product.IsFresh(currentDate))
            {
                Console.WriteLine(product.PrintInfo());
            }
        }
    }
    
    public static void PrintFinalDateOfSelling()
    {
        foreach (Product product in productsArray)
        {
            Console.WriteLine(product.GetFinalDateOfSelling());
        }
    }
    
    public static void PrintProductsForSelling(DateTime currentDate)
    {
        foreach (Product product in productsArray)
        {
            if (product.GetFinalDateOfSelling() < currentDate)
            {
                Console.WriteLine(product.PrintInfo());
            }
        }
    }
}