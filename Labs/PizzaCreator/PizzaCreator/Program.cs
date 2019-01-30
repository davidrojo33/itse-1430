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
            //new order
            var neworder = "New Order";
            //modify order
            var modifyorder = "Modify Order";
            //display order
            var displayorder = "Display Order";
            //quit
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
            Console.WriteLine("This is the New Order. ");
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
