using Course1.Entities;
using System.Globalization;

List<Product> products = new List<Product>();

Console.Write("Enter the number of products: ");
var n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    var ch = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    var name = Console.ReadLine();
    Console.Write("Price: ");
    var price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if(ch == 'c')
    {
        Product p1 = new Product(name, price);
        products.Add(p1);
    }else if (ch == 'i')
    {
        Console.Write("Customs fee: ");
        var customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Product p2 = new ImportedProduct(name, price, customsFee);
        products.Add(p2);
    }else
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
        Product p3 = new UsedProduct(name, price, manufactureDate);
        products.Add(p3);

    }
    
}
Console.WriteLine();
Console.WriteLine("PRICE TAGS:");

foreach(Product p in products)
{
    Console.WriteLine(p.PriceTag());
}