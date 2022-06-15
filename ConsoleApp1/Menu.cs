using Application.Properties;
using Shop;
using Shop.Decorators;
using Storage.Models;
using Storage.Repositories;
using System;
using System.Collections.Generic;

namespace Application
{
    public static class Menu
    {
        public static OrderItem ChooseOrderItemDefault(OrderItem item)
        {            
            var result = ChooseCategoryDefault(item);
            return result;
        }

        public static OrderItem ChooseAssemblingItem(OrderItem item)
        {
            var result = ChooseCategoryAssembling(new AssemblingDecorator(item));
            return result;
        }

        public static OrderItem ChooseFullSetItem(OrderItem item)
        {
            Console.WriteLine("Firstly, assemble a system block. (+15%)");

            var systemBlock = ChooseCategoryAssembling(new AssemblingDecorator(item));

            Console.WriteLine("Secondly, choose a monitor. (+5%)");

            var result = ChooseMonitor(new FullSetDecorator(systemBlock));

            return result;
        }

        public static OrderItem ChoosePackagingItem(OrderItem item)
        {
            var answer = ConsoleReader.ReadAnswer("Service", ConsoleTexts.ServicesPackaging);
            OrderItem result = null;

            switch (answer)
            {
                case 1:
                    item = Menu.ChooseOrderItemDefault(item);
                    result = item;
                    break;
                case 2:
                    item = Menu.ChooseAssemblingItem(item);
                    result = item;
                    break;
                case 3:
                    item = Menu.ChooseFullSetItem(item);
                    result = item;
                    break;
            }

            return result;
        }

        private static OrderItem ChooseCategoryDefault(OrderItem item)
        {
            int answer = 0;
            var storage = new StorageRepository();

            List<Product> category;
            Product product;

            do
            {
                answer = ConsoleReader.ReadAnswer("Category", ConsoleTexts.CategoriesDefault);
                switch (answer)
                {
                    case 1:
                        category = storage.GetMonitors();
                        ConsoleViewer.ShowProducts(category, "Monitors");
                        product = ConsoleReader.ReadProduct(category);
                        if (product is not null) item.AddProduct(product);
                        break;
                    case 2:
                        category = storage.GetMotherboards();
                        ConsoleViewer.ShowProducts(category, "Motherboards");
                        product = ConsoleReader.ReadProduct(category);
                        if (product is not null) item.AddProduct(product);
                        break;
                    case 3:
                        category = storage.GetPowerUnits();
                        ConsoleViewer.ShowProducts(category, "Power Units");
                        product = ConsoleReader.ReadProduct(category);
                        if (product is not null) item.AddProduct(product);
                        break;
                    case 4:
                        category = storage.GetProcessors();
                        ConsoleViewer.ShowProducts(category, "Processors");
                        product = ConsoleReader.ReadProduct(category);
                        if (product is not null) item.AddProduct(product);
                        break;
                    case 5:
                        category = storage.GetVideoCards();
                        ConsoleViewer.ShowProducts(category, "Video Cards");
                        product = ConsoleReader.ReadProduct(category);
                        if (product is not null) item.AddProduct(product);
                        break;
                }

            } while (answer != 0);

            return item;
        }

        private static OrderItem ChooseCategoryAssembling(OrderItem item)
        {
            int answer = 0;
            var storage = new StorageRepository();

            List<Product> category = null;
            Product product;

            do
            {
                answer = ConsoleReader.ReadAnswer("Category", ConsoleTexts.CategoriesAssembling);
                switch (answer)
                {
                    case 1:
                        category = storage.GetMotherboards();
                        ConsoleViewer.ShowProducts(category, "Motherboards");
                        product = ConsoleReader.ReadProduct(category);
                        if (product is not null) item.AddProduct(product);
                        break;
                    case 2:
                        category = storage.GetPowerUnits();
                        ConsoleViewer.ShowProducts(category, "Power Units");
                        product = ConsoleReader.ReadProduct(category);
                        if (product is not null) item.AddProduct(product);
                        break;
                    case 3:
                        category = storage.GetProcessors();
                        ConsoleViewer.ShowProducts(category, "Processors");
                        product = ConsoleReader.ReadProduct(category);
                        if (product is not null) item.AddProduct(product);
                        break;
                    case 4:
                        category = storage.GetVideoCards();
                        ConsoleViewer.ShowProducts(category, "Video Cards");
                        product = ConsoleReader.ReadProduct(category);
                        if (product is not null) item.AddProduct(product);
                        break;
                }

            } while (answer != 0);

            return item;
        }

        private static OrderItem ChooseMonitor(OrderItem item)
        {
            var storage = new StorageRepository();
            var category = storage.GetMonitors();
            ConsoleViewer.ShowProducts(category, "Monitors");
            var product = ConsoleReader.ReadProduct(category);
            if (product is not null) item.AddProduct(product);
            return item;
        }
    }
}
