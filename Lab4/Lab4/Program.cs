namespace Lab4;

    class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(ConsoleMenu.Menu());
                var choice = Convert.ToInt32(Functions.InputCheck("Menu"));

                Console.Clear();
                ConsoleMenu.PrintLongThing();
            
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Functions.WorkWithGenericCollection();
                        break;
                    case 2:
                        Console.Clear();
                        Functions.WorkWithNonGenericCollection();
                        break;
                    case 3:
                        Console.Clear();
                        Functions.WorkWithArray();
                        break;
                    case 4:
                        Console.Clear();
                        var tree = new BinaryTree<Product>();
                        
                        var product1 = new Product("Product1", 1, DateTime.Now, DateTime.Now.AddDays(10));
                        var product2 = new Product("Product2", 2, DateTime.Now, DateTime.Now.AddDays(20));
                        var product3 = new Product("Product3", 3, DateTime.Now, DateTime.Now.AddDays(30));

                        tree.Insert(product1);
                        tree.Insert(product2);
                        tree.Insert(product3);

                        tree.InOrderTraversal(product => Console.WriteLine(product.PrintInfo()));

                        int comparison = product1.CompareTo(product2);
                        
                        if (comparison == -1)
                        {
                            Console.WriteLine("product1 is less than product2");
                        }
                        else if (comparison == 1)
                        {
                            Console.WriteLine("product1 is greater than product2");
                        }
                        else
                        {
                            Console.WriteLine("product1 is equal to product2");
                        }
                        break;
                    case 0:
                        return;
                }
            }
        }
    }