using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine("Hello Pizza Creator");
            DisplayMenu();
            DisplayOrder();
        }

        private static void DisplayMenu()
        {
            var neworder = "New Order";
            var modifyorder = "Modify Order";          
            var displayorder = "Display Order";
            var quit = "Quit";

            while (true)
            {
                Console.WriteLine("Please choose one of the following: ");
                Console.WriteLine("1. " + neworder);
                Console.WriteLine("2. " + modifyorder);
                Console.WriteLine("3. " + displayorder);
                Console.WriteLine("4. " + quit);

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
            string size;
            var small = 5;
            var medium = 6.25;
            var large = 8.75;

            string meats;            
            var bacon = .75;
            var ham = .75;
            var pepperoni = .75;
            var sausage = .75;

            string veggies;
            var blackolives = .50;
            var mushrooms = .75;
            var onions = .75;
            var peppers = .75;

            string sauce;
            var traditional = 0;
            var garlic = 1;
            var oregano = 1;

            string cheese;
            var regular = 0;
            var extra = 1.25;

            string Delivery;
            var takeout = 0;
            var delivery = 2.5;

            //Console.WriteLine("This is the New Order. ");
            //Console.WriteLine("Please choose a size");
            Console.WriteLine("Small, Medium, or Large: ");
            size = Console.ReadLine();

            //Console.WriteLine("Please choose a meat:");
            Console.WriteLine("Bacon, Ham, Pepperoni, or Sausage.");
            meats = Console.ReadLine();

            //Console.WriteLine("Please choose a veggie:");
            Console.WriteLine("Black olives, mushrooms, onions, or peppers. ");
            veggies = Console.ReadLine();

            //Console.WriteLine("Please choose a sause:");
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
        private static void DisplayOrder( string size, string meats, string veggies, string sauce, string cheese, string Delivery)
        {
            var price = (meats + veggies + sauce + cheese + Delivery);

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
