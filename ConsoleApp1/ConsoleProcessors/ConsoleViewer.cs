using Storage.Models;
using System.Collections.Generic;
using System;
using Shop;
using System.Linq;

namespace Application
{
    public static class ConsoleViewer
    {
        public static void ShowProducts(List<Product> products, string label)
        {
            Console.WriteLine($"{label}: ");
            for (int i = 0; i < products.Count; i++)
            {
                var items = products[i].ToString().Split('\n');
                Console.WriteLine($"\t{i + 1}- {items[0]}");
                for(int j = 1; j < items.Length; j++)
                    Console.WriteLine($"\t   {items[j]}");
                Console.WriteLine();                
            }
        }

        public static void ShowOrder(List<OrderItem> order)
        {
            Console.WriteLine("\n\tYour order:\n");
            foreach (var item in order)
            {
                Console.WriteLine($"{item}");
                Console.WriteLine($"\tPrice: {Decimal.Round(item.CalculatePrice(),2)}\n");
            }
            var totalPrice = order.Sum(x => x.CalculatePrice());
            Console.WriteLine($"\nTotal price: {Decimal.Round(totalPrice, 2)}");
        }
    }
}
