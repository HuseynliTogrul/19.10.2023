using Shoop.Core.Models;
using System.Diagnostics;

Product[] products = { };

Console.WriteLine("1-create product");
Console.WriteLine("2-show product");
Console.WriteLine("0-close");
string request = Console.ReadLine();

while (request != "0")
{
    switch (request)
    {
        case "1":
            CreateProduct();
            break;
        case "2":
            ShowProducts();
            break;
        default:
            Console.WriteLine("verilen deyerlerden daxil edin!");
            break;
    }
    Console.WriteLine("1-create product");
    Console.WriteLine("2-show product");
    Console.WriteLine("0-close");
    request = Console.ReadLine();
}


//string tipinde olan deyisene reqem girende goturur!!!!!!!!!!!!
void CreateProduct()
{
    Console.WriteLine("add name:");
    string Name = GetProduct(Console.ReadLine());

    Console.WriteLine("add price:");
    int Price = int.Parse(GetProduct(Console.ReadLine()));

    Console.WriteLine("add category:");
    string Category = GetProduct(Console.ReadLine());

    Console.WriteLine("add stockCount:");
    int StockCount = int.Parse(GetProduct(Console.ReadLine()));

    Product product = new Product(Name, Price, Category, StockCount);
    Array.Resize(ref products, products.Length + 1);
    products[products.Length - 1] = product;
}

void ShowProducts()
{
    for (int i = 0; i < products.Length; i++)
    {
        Console.WriteLine(products[i].GetFullInfo());
    }
}

string GetProduct(string value)
{
    while (string.IsNullOrWhiteSpace(value))
    {
        Console.WriteLine("bos deyer daxil etme!");
        value = Console.ReadLine();
    }
    return value;
}

