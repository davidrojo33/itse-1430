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
            var size = "Size";
            var small = 5;
            var medium = 6.25;
            var large = 8.75;

            var meats = "Meats";
            string bacon, ham, pepperoni, sausage;

            var veggies = "Vegetables";
            string blackolives, mushrooms, onions, peppers;

            var sauce = "Sauce";
            var traditional = 0;
            var garlic = 1;
            var oregano = 1;

            var cheese = "Cheese";
            var regular = 0;
            var extra = 1.25;

            var Delivery = "Delivery";
            var takeout = 0;
            var delivery = 2.5;

            Console.WriteLine("This is the New Order. ");
            Console.WriteLine("Please choose a " + size);
           
        }
        private static void ModifyOrder()
        {
            Console.WriteLine("This is the Modified order. ");
        }
        private static void DisplayOrder()
        {
            Console.WriteLine("This is your order. ");
        }
    }
}
