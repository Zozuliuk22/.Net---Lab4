using Application;
using Application.Properties;
using Shop;
using Shop.Decorators;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static List<OrderItem> Order { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine(ConsoleTexts.Label);
            Console.WriteLine();

            Order = new List<OrderItem>();
            OrderItem item;

            var answer = ConsoleReader.ReadAnswer("Service", ConsoleTexts.ServicesDefault);

            do
            {
                item = new OrderItemDefault();
                switch (answer)
                {
                    case 1:
                        item = Menu.ChooseOrderItemDefault(item);
                        Order.Add(item);
                        break;
                    case 2:
                        item = Menu.ChooseAssemblingItem(item);
                        Order.Add(item);
                        break;
                    case 3:
                        item = Menu.ChooseFullSetItem(item);
                        Order.Add(item);
                        break;
                    case 4:
                        item = new PackagingDecorator(item);
                        item = Menu.ChoosePackagingItem(item);
                        Order.Add(item);
                        break;
                }

                answer = ConsoleReader.ReadAnswer("Service", ConsoleTexts.ServicesDefault);
            } while (answer != 0);

            ConsoleViewer.ShowOrder(Order);
        }
    }
}
