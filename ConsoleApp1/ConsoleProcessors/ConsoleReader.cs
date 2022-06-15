using Storage.Models;
using System;
using System.Collections.Generic;

namespace Application
{
    public static class ConsoleReader
    {
        public static int ReadAnswer(string mainWord, string list)
        {
            Console.WriteLine($"{mainWord}:");

            var items = list.Split('\n');
            foreach (var item in items)
                Console.WriteLine($"\t{item}");
            Console.WriteLine();

            Console.Write($"Please, choose a {mainWord} (or enter 0 to exit): ");            
            int key = 0;
            while(!Int32.TryParse(Console.ReadLine(), out key))
            {
                Console.Write($"Please, choose a {mainWord} (or enter 0 to exit): ");
            }            
            Console.WriteLine();

            return key;
        }

        public static Product ReadProduct(List<Product> products)
        {
            int key = -1;

            Console.Write($"Please, choose a product (or enter 0 to exit): ");
            while (!Int32.TryParse(Console.ReadLine(), out key))
            {
                Console.Write($"Please, choose a product: ");
            }
            Console.WriteLine();

            if (key < 1 || key > products.Count)
                return null;
            return products[key-1];
        }
    }
}
