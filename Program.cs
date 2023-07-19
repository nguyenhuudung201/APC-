// See https://aka.ms/new-console-template for more information
using APC_.Controller;
using APC_.Data;
using APC_.Model;

DataContext context = new DataContext();
ProductController productController = new ProductController(context);

do
{
    Console.WriteLine("1.Add Product  ");
    Console.WriteLine("2.Get All Product ");
    Console.WriteLine("3.Delete Product ");
    Console.WriteLine("4.Exit");

    Console.WriteLine("Choose menu: ");


    int choose = Convert.ToInt32(Console.ReadLine());
    switch (choose)
    {
        case 1:
            Console.Write("Enter product's name: ");
            string name = Console.ReadLine();
            Console.Write("Enter product's price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Product product = new Product { Name = name, Price = price };
            productController.Add(product);
            break;
        case 2:
            productController.GetAllProducts();
            break;
        case 3:
            Console.Write("Enter id to find Products : ");
            int id = Convert.ToInt32(Console.ReadLine());
            productController.DeleteProduct(id);
            break;
     
        case 4:
            return;
    }
} while (true);