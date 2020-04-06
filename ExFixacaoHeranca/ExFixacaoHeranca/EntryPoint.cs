using System;
using System.Collections.Generic;
using ExFixacaoHeranca.Entities;
using System.Globalization;

namespace ExFixacaoHeranca
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported: ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (ch)
                {
                    case 'i':
                        Console.Write("Customs fee: ");
                        double fee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        list.Add(new ImportedProduct(name, price, fee));
                        break;

                    case 'u':
                        Console.Write("Manufacture date: (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        list.Add(new UsedProduct(name, price,manufactureDate));
                        break;

                    case 'c':
                        list.Add(new Product(name, price));
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }

        }
    }
}
