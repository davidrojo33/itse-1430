/*
 * Lab 1
 * David Rojo
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        private static string size;
        private static string meats;
        private static string veggies;
        private static string sauce;
        private static string cheese;
        private static string Delivery;

        static void Main( string[] args )
        {
            Console.WriteLine("Hello Pizza Creator");
            DisplayMenu();
            DisplayOrder();
        }

        private static void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("Please choose one of the following: ");
                Console.WriteLine("1. New order");
                Console.WriteLine("2. Modify order");
                Console.WriteLine("3. Display order");
                Console.WriteLine("4. Quit");

                string choice;
                choice = Console.ReadLine();

                if (choice == "1")
                    NewOrder();
                else if (choice == "2")
                    ModifyOrder();
                else if (choice == "3")
                    DisplayOrder();
                else if (choice == "4")
                    break;
                else
                {
                    Console.WriteLine("Please enter a valid option: ");
                    DisplayMenu();
                }

            }
        }

        private static void NewOrder()
        {
            double small = 5;
            double medium = 6.25;
            double large = 8.75;

            double bacon = .75;
            double ham = .75;
            double pepperoni = .75;
            double sausage = .75;

            double blackolives = .50;
            double mushrooms = .75;
            double onions = .75;
            double peppers = .75;

            double traditional = 0;
            double garlic = 1;
            double oregano = 1;

            double regular = 0;
            double extra = 1.25;

            double takeout = 0;
            double delivery = 2.5;

            Console.WriteLine("This is the New Order. ");
            Console.WriteLine("Please choose a size");
            Console.WriteLine("Small, Medium, or Large: ");
            size = Console.ReadLine();

            Console.WriteLine("Please choose a meat:");
            Console.WriteLine("Bacon, Ham, Pepperoni, or Sausage.");
            meats = Console.ReadLine();

            Console.WriteLine("Please choose a veggie:");
            Console.WriteLine("Black olives, mushrooms, onions, or peppers. ");
            veggies = Console.ReadLine();

            Console.WriteLine("Please choose a sause:");
            Console.WriteLine("Traditional, garlic, or oregano.");
            sauce = Console.ReadLine();

            Console.WriteLine("Regular or extra cheese? ");
            cheese = Console.ReadLine();

            Console.WriteLine("Delivery or takeout?");
            Delivery = Console.ReadLine();

        }
        private static void ModifyOrder()
        {
            Console.WriteLine("This is the Modified order. ");
        }
        private static void DisplayOrder()
        {
            double price = (meats + veggies + sauce + cheese + Delivery);

            Console.WriteLine("This is your order. ");

            Console.WriteLine("Size: " + "\t\t" + size);
            Console.WriteLine("Meats: " + "\t\t" + meats);
            Console.WriteLine("Veggies: " + "\t\t" + veggies);
            Console.WriteLine("Sauce: " + "\t\t" + sauce);
            Console.WriteLine("Cheese: " + "\t\t" + cheese);
            Console.WriteLine("Delivery: " + "\t\t" + Delivery);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Total: " + "          " + price);

        }
    }
}
