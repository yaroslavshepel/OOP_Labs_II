namespace Lab4;

public static class Functions
{
    public static string InputCheck(string typeOfInput)
    {
        switch (typeOfInput)
        {
            case "Menu":
                var choice = -1;
                try { choice = Convert.ToInt32(Console.ReadLine()); }
                catch (FormatException)
                {
                    throw new CustomException("Invalid input format. Please enter a number.");
                }
                catch (Exception ex)
                {
                    throw new CustomException("An unexpected error occurred.", ex);
                }
                Console.WriteLine(ConsoleMenu.PrintLongThing());
                return Convert.ToString(choice); 
                break;
            case "InputString":
                string input;
                while (true)
                {
                    input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input))
                    {
                        return input;
                    }
                    Console.WriteLine("Wrong input. Please enter a valid data.");
                }
            case "InputInt":
                int intInput;
                while (true)
                {
                    try
                    {
                        intInput = Convert.ToInt32(Console.ReadLine());
                        return intInput.ToString();
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input format. Please enter a number.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                    }
                }
        }
        return "";
    }

    public static void WorkWithGenericCollection()
    {
        while (true)
        {
            Console.WriteLine(ConsoleMenu.MenuOfGenetic());
            var choice = Convert.ToInt32(Functions.InputCheck("Menu"));

            Console.Clear();
            ConsoleMenu.PrintLongThing();
            
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Enter the name of the product:");
                    var name = InputCheck("InputString");
                    Console.WriteLine("Enter the code of the product:");
                    var code = Convert.ToInt32(InputCheck("InputInt"));
                    Console.WriteLine("Enter the production month of the product:");
                    int pM = 0;
                    while (true)
                    {
                        pM = Convert.ToInt32(Console.ReadLine());
                        if (pM < 1 || pM > 12)
                        { Console.WriteLine("Mouth must be from 1 to 12. Please enter the valid mouth"); }
                        else { break; }
                    }
                    Console.WriteLine("Enter the production day of the product:");
                    int pD;
                    while (true)
                    {
                        pD = Convert.ToInt32(Console.ReadLine());
                        if (pD < 1 || pD > 31)
                        {
                            Console.WriteLine("Day must be from 1 to 31. Please enter a valid day.");
                        }
                        else if ((pM == 4 || pM == 6 || pM == 9 || pM == 11) && pD > 30)
                        {
                            Console.WriteLine("Day must be from 1 to 30 for the selected month. Please enter a valid day.");
                        }
                        else if (pM == 2 && pD > 28)
                        {
                            Console.WriteLine("Day must be from 1 to 28 for February. Please enter a valid day.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.WriteLine("Enter the expiration mouth of the product:");
                    int eM;
                    while (true)
                    {
                        eM = Convert.ToInt32(Console.ReadLine());
                        if (eM < 1 || eM > 12)
                        { Console.WriteLine("Mouth must be from 1 to 12. Please enter the valid mouth"); }
                        else { break; }
                    }
                    Console.WriteLine("Enter the expiration day of the product:");
                    int eD;
                    while (true)
                    {
                        eD = Convert.ToInt32(Console.ReadLine());
                        if (eD < 1 || eD > 31)
                        {
                            Console.WriteLine("Day must be from 1 to 31. Please enter a valid day.");
                        }
                        else if ((eD == 4 || eD == 6 || eD == 9 || eD == 11) && eM > 30)
                        {
                            Console.WriteLine("Day must be from 1 to 30 for the selected month. Please enter a valid day.");
                        }
                        else if (eM == 2 && eM > 28)
                        {
                            Console.WriteLine("Day must be from 1 to 28 for February. Please enter a valid day.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    GenericCollection.AddProduct(name, code, new DateTime(2024, pM, pD), new DateTime(2024, eM, eD));
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("All products:");
                    GenericCollection.PrintProducts();
                    Console.WriteLine("Enter the name of the product you want to remove:");
                    var productName = InputCheck("InputString");
                    GenericCollection.RemoveProduct(productName);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("All products:");
                    GenericCollection.PrintProducts();
                    Console.WriteLine("Enter the name of the product you want to update:");
                    var productNameForUpdate = InputCheck("InputString");
                    Console.WriteLine("Enter the new code of the product:");
                    var newCode = Convert.ToInt32(InputCheck("InputInt"));
                    Console.WriteLine("Enter the new production month of the product:");
                    int newPm;
                    while (true)
                    {
                        newPm = Convert.ToInt32(Console.ReadLine());
                        if ((newPm < 1 || newPm > 12))
                        { Console.WriteLine("Mouth must be from 1 to 12. Please enter the valid mouth"); }
                        else { break; }
                    }
                    Console.WriteLine("Enter the new production day of the product:");
                    int newPd;
                    while (true)
                    {
                        newPd = Convert.ToInt32(Console.ReadLine());
                        if ((newPd < 1 || newPd > 31))
                        { Console.WriteLine("Day must be from 1 to 31. Please enter the valid day"); }
                        else if (newPm == 1 || newPm == 3 || newPm == 5 || newPm == 7 || newPm == 8 || newPm == 10 || newPm == 12)
                        { if (newPd > 31) { Console.WriteLine("Day must be from 1 to 31. Please enter the valid day"); } }
                        else if (newPm == 4 || newPm == 6 || newPm == 9 || newPm == 11)
                        { if (newPd > 30) { Console.WriteLine("Day must be from 1 to 30. Please enter the valid day"); } }
                        else if (newPm == 2)
                        { if (newPd > 28) { Console.WriteLine("Day must be from 1 to 28. Please enter the valid day"); } } 
                        else { break; }
                    }
                    Console.WriteLine("Enter the new expiration mouth of the product:");
                    int newEm;
                    while (true)
                    {
                        newEm = Convert.ToInt32(Console.ReadLine());
                        if (!(newEm < 1 || newEm > 12))
                        { Console.WriteLine("Mouth must be from 1 to 12. Please enter the valid mouth"); }
                        else { break; }
                    }
                    Console.WriteLine("Enter the new expiration day of the product:");
                    int newEd;
                    while (true)
                    {
                        newEd = Convert.ToInt32(Console.ReadLine());
                        if ((newEd < 1 || newEd > 31))
                        { Console.WriteLine("Day must be from 1 to 31. Please enter the valid day"); }
                        else if (newEm == 1 || newEm == 3 || newEm == 5 || newEm == 7 || newEm == 8 || newEm == 10 || newEm == 12)
                        { if (newEd > 31) { Console.WriteLine("Day must be from 1 to 31. Please enter the valid day"); } }
                        else if (newEm == 4 || newEm == 6 || newEm == 9 || newEm == 11)
                        { if (newEd > 30) { Console.WriteLine("Day must be from 1 to 30. Please enter the valid day"); } }
                        else if (newEm == 2)
                        { if (newEd > 28) { Console.WriteLine("Day must be from 1 to 28. Please enter the valid day"); } } 
                        else { break; }
                    }
                    GenericCollection.UpdateProduct(productNameForUpdate, new Product(productNameForUpdate, newCode, new DateTime(2024, newPm, newPd), new DateTime(2024, newEm, newEd)));
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Enter the name of the product you want to find:");
                    var productNameForFind = InputCheck("InputString");
                    Console.WriteLine(GenericCollection.FindProduct(productNameForFind, 1));
                    break;
                case 5:
                    Console.Clear();
                    GenericCollection.PrintProducts();
                    Console.WriteLine(ConsoleMenu.PrintLongThing());
                    break;
                case 6:
                    Console.Clear();
                    GenericCollection.PrintFreshProducts(DateTime.Today);
                    break;
                case 7:
                    Console.Clear();
                    GenericCollection.PrintProductsForSelling(DateTime.Today);
                    break;
                case 8:
                    Console.Clear();
                    break;
            }
        }
    }

    public static void WorkWithNonGenericCollection()
    {
        while (true)
        {
            Console.WriteLine(ConsoleMenu.MenuOfGenetic());
            var choice = Convert.ToInt32(Functions.InputCheck("Menu"));

            Console.Clear();
            ConsoleMenu.PrintLongThing();
            
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Enter the name of the product:");
                    var name = InputCheck("InputString");
                    Console.WriteLine("Enter the code of the product:");
                    var code = Convert.ToInt32(InputCheck("InputInt"));
                    Console.WriteLine("Enter the production month of the product:");
                    int pM = 0;
                    while (true)
                    {
                        pM = Convert.ToInt32(Console.ReadLine());
                        if (pM < 1 || pM > 12)
                        { Console.WriteLine("Mouth must be from 1 to 12. Please enter the valid mouth"); }
                        else { break; }
                    }
                    Console.WriteLine("Enter the production day of the product:");
                    int pD;
                    while (true)
                    {
                        pD = Convert.ToInt32(Console.ReadLine());
                        if (pD < 1 || pD > 31)
                        {
                            Console.WriteLine("Day must be from 1 to 31. Please enter a valid day.");
                        }
                        else if ((pM == 4 || pM == 6 || pM == 9 || pM == 11) && pD > 30)
                        {
                            Console.WriteLine("Day must be from 1 to 30 for the selected month. Please enter a valid day.");
                        }
                        else if (pM == 2 && pD > 28)
                        {
                            Console.WriteLine("Day must be from 1 to 28 for February. Please enter a valid day.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.WriteLine("Enter the expiration mouth of the product:");
                    int eM;
                    while (true)
                    {
                        eM = Convert.ToInt32(Console.ReadLine());
                        if (eM < 1 || eM > 12)
                        { Console.WriteLine("Mouth must be from 1 to 12. Please enter the valid mouth"); }
                        else { break; }
                    }
                    Console.WriteLine("Enter the expiration day of the product:");
                    int eD;
                    while (true)
                    {
                        eD = Convert.ToInt32(Console.ReadLine());
                        if (eD < 1 || eD > 31)
                        {
                            Console.WriteLine("Day must be from 1 to 31. Please enter a valid day.");
                        }
                        else if ((eD == 4 || eD == 6 || eD == 9 || eD == 11) && eM > 30)
                        {
                            Console.WriteLine("Day must be from 1 to 30 for the selected month. Please enter a valid day.");
                        }
                        else if (eM == 2 && eM > 28)
                        {
                            Console.WriteLine("Day must be from 1 to 28 for February. Please enter a valid day.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    NonGenericCollection.AddProduct(name, code, new DateTime(2024, pM, pD), new DateTime(2024, eM, eD));
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("All products:");
                    NonGenericCollection.PrintProducts();
                    Console.WriteLine("Enter the name of the product you want to remove:");
                    var productName = InputCheck("InputString");
                    NonGenericCollection.RemoveProduct(productName);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("All products:");
                    NonGenericCollection.PrintProducts();
                    Console.WriteLine("Enter the name of the product you want to update:");
                    var productNameForUpdate = InputCheck("InputString");
                    Console.WriteLine("Enter the new code of the product:");
                    var newCode = Convert.ToInt32(InputCheck("InputInt"));
                    Console.WriteLine("Enter the new production month of the product:");
                    int newPm;
                    while (true)
                    {
                        newPm = Convert.ToInt32(Console.ReadLine());
                        if ((newPm < 1 || newPm > 12))
                        { Console.WriteLine("Mouth must be from 1 to 12. Please enter the valid mouth"); }
                        else { break; }
                    }
                    Console.WriteLine("Enter the new production day of the product:");
                    int newPd;
                    while (true)
                    {
                        newPd = Convert.ToInt32(Console.ReadLine());
                        if ((newPd < 1 || newPd > 31))
                        { Console.WriteLine("Day must be from 1 to 31. Please enter the valid day"); }
                        else if (newPm == 1 || newPm == 3 || newPm == 5 || newPm == 7 || newPm == 8 || newPm == 10 || newPm == 12)
                        { if (newPd > 31) { Console.WriteLine("Day must be from 1 to 31. Please enter the valid day"); } }
                        else if (newPm == 4 || newPm == 6 || newPm == 9 || newPm == 11)
                        { if (newPd > 30) { Console.WriteLine("Day must be from 1 to 30. Please enter the valid day"); } }
                        else if (newPm == 2)
                        { if (newPd > 28) { Console.WriteLine("Day must be from 1 to 28. Please enter the valid day"); } } 
                        else { break; }
                    }
                    Console.WriteLine("Enter the new expiration mouth of the product:");
                    int newEm;
                    while (true)
                    {
                        newEm = Convert.ToInt32(Console.ReadLine());
                        if (!(newEm < 1 || newEm > 12))
                        { Console.WriteLine("Mouth must be from 1 to 12. Please enter the valid mouth"); }
                        else { break; }
                    }
                    Console.WriteLine("Enter the new expiration day of the product:");
                    int newEd;
                    while (true)
                    {
                        newEd = Convert.ToInt32(Console.ReadLine());
                        if ((newEd < 1 || newEd > 31))
                        { Console.WriteLine("Day must be from 1 to 31. Please enter the valid day"); }
                        else if (newEm == 1 || newEm == 3 || newEm == 5 || newEm == 7 || newEm == 8 || newEm == 10 || newEm == 12)
                        { if (newEd > 31) { Console.WriteLine("Day must be from 1 to 31. Please enter the valid day"); } }
                        else if (newEm == 4 || newEm == 6 || newEm == 9 || newEm == 11)
                        { if (newEd > 30) { Console.WriteLine("Day must be from 1 to 30. Please enter the valid day"); } }
                        else if (newEm == 2)
                        { if (newEd > 28) { Console.WriteLine("Day must be from 1 to 28. Please enter the valid day"); } } 
                        else { break; }
                    }
                    NonGenericCollection.UpdateProduct(productNameForUpdate, new Product(productNameForUpdate, newCode, new DateTime(2024, newPm, newPd), new DateTime(2024, newEm, newEd)));
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Enter the name of the product you want to find:");
                    var productNameForFind = InputCheck("InputString");
                    Console.WriteLine(NonGenericCollection.FindProduct(productNameForFind));
                    break;
                case 5:
                    Console.Clear();
                    NonGenericCollection.PrintProducts();
                    Console.WriteLine(ConsoleMenu.PrintLongThing());
                    break;
                case 6:
                    Console.Clear();
                    NonGenericCollection.PrintFreshProducts(DateTime.Today);
                    break;
                case 7:
                    Console.Clear();
                    NonGenericCollection.PrintProductsForSelling(DateTime.Today);
                    break;
                case 8:
                    Console.Clear();
                    break;
            }
        }
    }
    
    public static void WorkWithArray()
    {
        while (true)
        {
            Console.WriteLine(ConsoleMenu.MenuOfGenetic());
            var choice = Convert.ToInt32(Functions.InputCheck("Menu"));

            Console.Clear();
            ConsoleMenu.PrintLongThing();
            
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Enter the name of the product:");
                    var name = InputCheck("InputString");
                    Console.WriteLine("Enter the code of the product:");
                    var code = Convert.ToInt32(InputCheck("InputInt"));
                    Console.WriteLine("Enter the production month of the product:");
                    int pM = 0;
                    while (true)
                    {
                        pM = Convert.ToInt32(Console.ReadLine());
                        if (pM < 1 || pM > 12)
                        { Console.WriteLine("Mouth must be from 1 to 12. Please enter the valid mouth"); }
                        else { break; }
                    }
                    Console.WriteLine("Enter the production day of the product:");
                    int pD;
                    while (true)
                    {
                        pD = Convert.ToInt32(Console.ReadLine());
                        if (pD < 1 || pD > 31)
                        {
                            Console.WriteLine("Day must be from 1 to 31. Please enter a valid day.");
                        }
                        else if ((pM == 4 || pM == 6 || pM == 9 || pM == 11) && pD > 30)
                        {
                            Console.WriteLine("Day must be from 1 to 30 for the selected month. Please enter a valid day.");
                        }
                        else if (pM == 2 && pD > 28)
                        {
                            Console.WriteLine("Day must be from 1 to 28 for February. Please enter a valid day.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.WriteLine("Enter the expiration mouth of the product:");
                    int eM;
                    while (true)
                    {
                        eM = Convert.ToInt32(Console.ReadLine());
                        if (eM < 1 || eM > 12)
                        { Console.WriteLine("Mouth must be from 1 to 12. Please enter the valid mouth"); }
                        else { break; }
                    }
                    Console.WriteLine("Enter the expiration day of the product:");
                    int eD;
                    while (true)
                    {
                        eD = Convert.ToInt32(Console.ReadLine());
                        if (eD < 1 || eD > 31)
                        {
                            Console.WriteLine("Day must be from 1 to 31. Please enter a valid day.");
                        }
                        else if ((eD == 4 || eD == 6 || eD == 9 || eD == 11) && eM > 30)
                        {
                            Console.WriteLine("Day must be from 1 to 30 for the selected month. Please enter a valid day.");
                        }
                        else if (eM == 2 && eM > 28)
                        {
                            Console.WriteLine("Day must be from 1 to 28 for February. Please enter a valid day.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    Array.AddProduct(name, code, new DateTime(2024, pM, pD), new DateTime(2024, eM, eD));
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("All products:");
                    Array.PrintProducts();
                    Console.WriteLine("Enter the name of the product you want to remove:");
                    var productName = InputCheck("InputString");
                    Array.RemoveProduct(productName);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("All products:");
                    Array.PrintProducts();
                    Console.WriteLine("Enter the name of the product you want to update:");
                    var productNameForUpdate = InputCheck("InputString");
                    Console.WriteLine("Enter the new code of the product:");
                    var newCode = Convert.ToInt32(InputCheck("InputInt"));
                    Console.WriteLine("Enter the new production month of the product:");
                    int newPm;
                    while (true)
                    {
                        newPm = Convert.ToInt32(Console.ReadLine());
                        if ((newPm < 1 || newPm > 12))
                        { Console.WriteLine("Mouth must be from 1 to 12. Please enter the valid mouth"); }
                        else { break; }
                    }
                    Console.WriteLine("Enter the new production day of the product:");
                    int newPd;
                    while (true)
                    {
                        newPd = Convert.ToInt32(Console.ReadLine());
                        if ((newPd < 1 || newPd > 31))
                        { Console.WriteLine("Day must be from 1 to 31. Please enter the valid day"); }
                        else if (newPm == 1 || newPm == 3 || newPm == 5 || newPm == 7 || newPm == 8 || newPm == 10 || newPm == 12)
                        { if (newPd > 31) { Console.WriteLine("Day must be from 1 to 31. Please enter the valid day"); } }
                        else if (newPm == 4 || newPm == 6 || newPm == 9 || newPm == 11)
                        { if (newPd > 30) { Console.WriteLine("Day must be from 1 to 30. Please enter the valid day"); } }
                        else if (newPm == 2)
                        { if (newPd > 28) { Console.WriteLine("Day must be from 1 to 28. Please enter the valid day"); } } 
                        else { break; }
                    }
                    Console.WriteLine("Enter the new expiration mouth of the product:");
                    int newEm;
                    while (true)
                    {
                        newEm = Convert.ToInt32(Console.ReadLine());
                        if (!(newEm < 1 || newEm > 12))
                        { Console.WriteLine("Mouth must be from 1 to 12. Please enter the valid mouth"); }
                        else { break; }
                    }
                    Console.WriteLine("Enter the new expiration day of the product:");
                    int newEd;
                    while (true)
                    {
                        newEd = Convert.ToInt32(Console.ReadLine());
                        if ((newEd < 1 || newEd > 31))
                        { Console.WriteLine("Day must be from 1 to 31. Please enter the valid day"); }
                        else if (newEm == 1 || newEm == 3 || newEm == 5 || newEm == 7 || newEm == 8 || newEm == 10 || newEm == 12)
                        { if (newEd > 31) { Console.WriteLine("Day must be from 1 to 31. Please enter the valid day"); } }
                        else if (newEm == 4 || newEm == 6 || newEm == 9 || newEm == 11)
                        { if (newEd > 30) { Console.WriteLine("Day must be from 1 to 30. Please enter the valid day"); } }
                        else if (newEm == 2)
                        { if (newEd > 28) { Console.WriteLine("Day must be from 1 to 28. Please enter the valid day"); } } 
                        else { break; }
                    }
                    Array.UpdateProduct(productNameForUpdate, new Product(productNameForUpdate, newCode, new DateTime(2024, newPm, newPd), new DateTime(2024, newEm, newEd)));
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Enter the name of the product you want to find:");
                    var productNameForFind = InputCheck("InputString");
                    Console.WriteLine(Array.FindProduct(productNameForFind, 1));
                    break;
                case 5:
                    Console.Clear();
                    Array.PrintProducts();
                    Console.WriteLine(ConsoleMenu.PrintLongThing());
                    break;
                case 6:
                    Console.Clear();
                    Array.PrintFreshProducts(DateTime.Today);
                    break;
                case 7:
                    Console.Clear();
                    Array.PrintProductsForSelling(DateTime.Today);
                    break;
                case 8:
                    Console.Clear();
                    break;
            }
        }
    }
}