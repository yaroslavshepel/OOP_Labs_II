using System;

namespace Lab4;
public class GenericCollection
{
    public static Product[] productsArray = new Product[3];
    private static int count = 0;

    public static void AddProduct(string name, int code, DateTime productionDate, DateTime expiryDate)
    {
        if (count < productsArray.Length)
        {
            productsArray[count] = new Product(name, code, productionDate, expiryDate);
            count++;
        }
    }

    public static void RemoveProduct(string productName)
    {
        for (int i = 0; i < count; i++)
        {
            if (productsArray[i].GetName() == productName)
            {
                productsArray[count - 1] = null;
                count--;
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
        for (int i = 0; i < count; i++)
        {
            if (productsArray[i].GetName() == name)
            {
                return i;
            }
        }
        return -1;
    }

    public static void PrintProducts()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(productsArray[i].PrintInfo());
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