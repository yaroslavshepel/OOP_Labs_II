using System.Collections;

namespace Lab4;

public class NonGenericCollection
{
    static ArrayList productsArray = new ArrayList();
    public static void AddProduct(string name, int code, DateTime productionDate, DateTime expiryDate)
    {
        productsArray.Add(new Product(name, code, productionDate, expiryDate));
    }
    
    public static void RemoveProduct(string productName)
    {
        for (int i = 0; i < productsArray.Count; i++)
        {
            if (((Product)productsArray[i]).GetName() == productName)
            {
                productsArray.RemoveAt(i);
                break;
            }
        }
    }
    
    public static void UpdateProduct(string name, Product newProduct)
    {
        int index = FindProduct(name);
        if (index >= 0)
        {
            productsArray[index] = newProduct;
        }
    }
    
    public static int FindProduct(string name)
    {
        for (int i = 0; i < productsArray.Count; i++)
        {
            if (((Product)productsArray[i]).GetName() == name)
            {
                return i;
            }
        }
        return -1;
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