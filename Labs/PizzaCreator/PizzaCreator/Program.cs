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
            ModifyOrder();
        }

        private static void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("Please choose one of the following: ");
                Console.WriteLine("1. New order");
                Console.WriteLine("2. Display order");
                Console.WriteLine("3. Modify order");
                Console.WriteLine("4. Quit");

                string choice;
                choice = Console.ReadLine();

                switch (choice)
                {

                    case "1":
                        NewOrder();
                        break;
                    case "2":
                        DisplayOrder();
                        break;
                    case "3":
                        ModifyOrder();
                        break;
                    case "4":
                        Close();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option: ");
                        DisplayMenu();
                        break;
                }
                //if (choice == "1")
                //    NewOrder();
                //else if (choice == "2")
                //    ModifyOrder();
                //else if (choice == "3")
                //    DisplayOrder();
                //else if (choice == "4")
                //    break;
                //else
                //{
                //    Console.WriteLine("Please enter a valid option: ");
                //    DisplayMenu();
                //}

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
            Console.WriteLine("1.Small, 2.Medium, or 3.Large: ");
            size = Console.ReadLine();

            while (size == "1" || size == "2" || size == "3")
            { 
                switch (size)
                {
                    case "1":
                    size = "Small";
                    break;
                    case "2":
                    size = "Medium";
                    break;
                    case "3":
                    size = "Large";
                    break;
                    default: Console.WriteLine("Invalid entry");
                    break;
                }
            }
            Console.WriteLine("Please choose a meat:");
            Console.WriteLine("1.Bacon, 2.Ham, 3.Pepperoni, or 4.Sausage.");
            meats = Console.ReadLine();
            while (meats == "1" || meats == "2" || meats == "3" || meats == "4")
            {
                switch (meats)
                {
                    case "1":
                        meats = "Bacon";
                        break;
                    case "2":
                        meats = "Ham";
                        break;
                    case "3":
                        meats = "Pepperoni";
                        break;
                    case "4":
                        meats = "Sausage";
                        break;
                    default: break;


                }
            }
            Console.WriteLine("Please choose a veggie:");
            Console.WriteLine("1.Black olives, 2.Mushrooms, 3.Onions, or 4.Peppers. ");
            veggies = Console.ReadLine();
            while (veggies == "1" || veggies == "2" || veggies == "3" || veggies == "4")
            {
                switch (veggies)
                {
                    case "1":
                        veggies = "blackolives";
                        break;
                    case "2":
                        veggies = "Mushrooms";
                        break;
                    case "3":
                        veggies = "Onions";
                        break;
                    case "4":
                        veggies = "Peppers";
                        break;
                    default: break;
                }
            }
            Console.WriteLine("Please choose a sause:");
            Console.WriteLine("1.Traditional, 2.Garlic, or 3.Oregano.");
            sauce = Console.ReadLine();
            while (sauce == "1" || sauce == "2" || sauce == "3")
            {
                switch (sauce)
                {
                    case "1":
                        sauce = "Traditional";
                        break;
                    case "2":
                        sauce = "Garlic";
                        break;
                    case "3":
                        sauce = "Oregano";
                        break;
                    default: break;
                }
            }
            Console.WriteLine("1.Regular or 2.extra cheese? ");
            cheese = Console.ReadLine();
            while (cheese == "1" || cheese == "2")
            {
                switch (cheese)
                {
                    case "1":
                        cheese = "Regular";
                        break;
                    case "2":
                        cheese = "Extra cheese";
                        break;
                    default: break;
                }
            }
            Console.WriteLine("1.Delivery or 2.takeout?");
            Delivery = Console.ReadLine();
            while (Delivery == "1" || Delivery == "2")
            {
                switch (Delivery)
                {
                    case "1":
                        Delivery = "Delivery";
                        break;
                    case "2":
                        Delivery = "Takeout";
                        break;
                    default: break;
                }
            }
        }
        private static void ModifyOrder()
        {
            Console.WriteLine("This is the Modified order. ");
            Console.WriteLine("Choose an option you wish to modify:");
            Console.WriteLine("1. Size, 2. Meats, 3. Veggies, 4. Sauce, 5. Cheese, or 6. Delivery");
            string choice = Console.ReadLine();
            while (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5" || choice == "6")
            {
                switch (choice)
                {
                    case "1":
                        choice = "Size";
                        break;
                    case "2":
                        choice = "Meats";
                        break;
                    case "3":
                        choice = "Veggies";
                        break;
                    case "4":
                        choice = "Sauce";
                        break;
                    case "5":
                        choice = "Cheese";
                        break;
                    case "6":
                        choice = "Delivery";
                        break;
                    default: break;
                }
            }
        }
        private static void DisplayOrder()
        {
            //double price = (meats + veggies + sauce + cheese + Delivery);

            Console.WriteLine("This is your order. ");

            Console.WriteLine("Size: " + "\t" + size);
            Console.WriteLine("Meats: " + "\t" + meats);
            Console.WriteLine("Veggies: " + veggies);
            Console.WriteLine("Sauce: " + "\t" + sauce);
            Console.WriteLine("Cheese: " + cheese);
            Console.WriteLine("Delivery: " + Delivery);
            Console.WriteLine("--------------------");
            //Console.WriteLine("Total: " + "          " + price);

        }
        private static void Close()
        {
            Environment.Exit(0);
        }
    }
}
