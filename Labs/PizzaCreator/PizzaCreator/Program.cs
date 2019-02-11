/*
 * Lab 1
 * David Rojo
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        public static string option = string.Empty;
        public static string pizzaSize = string.Empty;
        public static string crustType = string.Empty;
        public static string sauceType = string.Empty;
        public static string meatType = string.Empty;
        public static string veggieType = string.Empty;
        public static string cheeseType = string.Empty;
        public static string deliveryType = string.Empty;

        public static double pizzaSizePrice = 0;
        public static double sauceTypePrice = 0;
        public static double meatTypePrice = 0;
        public static double veggieTypePrice = 0;
        public static double cheeseTypePrice = 0;
        public static double deliveryTypePrice = 0;

        public static bool orderComplete = false;
        public static double totalPrice = 0;

        static void Main( string[] args )
        {
            Console.WriteLine("MY PIZZA CREATOR");
            MainMenu();
        }

        private static void MainMenu()
        {
            option = string.Empty;

            Console.WriteLine("");
            Console.WriteLine("Please select an option.");
            Console.WriteLine("     1.  New Order");
            Console.WriteLine("     2.  Modify Order");
            Console.WriteLine("     3.  Dispaly Order");
            Console.WriteLine("     4.  Quit");

            while (!ValidOption(option))
            {
                Console.Write("Enter option:  ");
                option = Console.ReadLine();
            }

            switch (option)
            {
                case "1":
                NewOrder();
                break;
                case "2":
                ModifyOrder();
                break;
                case "3":
                DisplayOrder();
                break;
                case "4":
                Close();
                break;
                default:
                break;
            }

            Console.WriteLine("");
            Console.ReadLine();
        }

        private static void MainMenu2()
        {
            option = string.Empty;

            Console.WriteLine("");
            Console.WriteLine("Please select an option.");
            Console.WriteLine("     1.  Modify Order");
            Console.WriteLine("     2.  Dispaly Order");
            Console.WriteLine("     3.  Quit");

            while (!ValidOption(option))
            {
                Console.Write("Enter option:  ");
                option = Console.ReadLine();
            }

            switch (option)
            {
                case "1":
                ModifyOrder();
                break;
                case "2":
                DisplayOrder();
                break;
                case "3":
                Close();
                break;
                default:
                break;
            }

            Console.WriteLine("");
            Console.ReadLine();
        }

        #region New Order
        private static void NewOrder()
        {
            SelectPizzaSize();
            SelectCrustType();
            SelectSauceType();
            SelectMeatToppings();
            SelectVeggieToppings();
            SelectChesseType();
            DeliveryType();
            DisplayOrder();
            MainMenu2();

            Console.WriteLine("");
            Console.ReadLine();
        }

        private static void SelectPizzaSize()
        {
            option = string.Empty;

            Console.WriteLine();
            Console.WriteLine("Please select the size of the pizza.");
            Console.WriteLine("     1.  Small");
            Console.WriteLine("     2.  Medium");
            Console.WriteLine("     3.  Large");

            while (!ValidOption(option))
            {
                Console.Write("Enter option:  ");
                option = Console.ReadLine();
            }

            switch (option)
            {
                case "1":
                pizzaSize = "Small";
                pizzaSizePrice = 5.00;
                break;
                case "2":
                pizzaSize = "Medium";
                pizzaSizePrice = 7.00;
                break;
                case "3":
                pizzaSize = "Large";
                pizzaSizePrice = 9.00;
                break;
                default:
                break;
            }

            CalculateTotalPrice();
        }

        private static void SelectCrustType()
        {
            option = string.Empty;
            Console.WriteLine("");
            Console.WriteLine("Please select the crust type.");
            Console.WriteLine("     1.  Thin");
            Console.WriteLine("     2.  Hand Tossed");
            Console.WriteLine("     3.  Pan");

            while (!ValidOption(option))
            {
                Console.Write("Enter option:  ");
                option = Console.ReadLine();
            }

            switch (option)
            {
                case "1":
                crustType = "Thin";
                break;
                case "2":
                crustType = "Hand Tossed";
                break;
                case "3":
                crustType = "Pan";
                break;
                default:
                break;
            }
        }

        private static void SelectSauceType()
        {
            option = string.Empty;
            Console.WriteLine("");
            Console.WriteLine("Please select the sauce type.");
            Console.WriteLine("     1.  Traditional");
            Console.WriteLine("     2.  Garlic");
            Console.WriteLine("     3.  Oregano");

            while (!ValidOption(option))
            {
                Console.Write("Enter option:  ");
                option = Console.ReadLine();
            }

            switch (option)
            {
                case "1":
                sauceType = "Traditional";
                sauceTypePrice = 0;
                break;
                case "2":
                sauceType = "Garlic";
                sauceTypePrice = 1.00;
                break;
                case "3":
                sauceType = "Oregano";
                sauceTypePrice = 1.00;
                break;
                default:
                break;
            }

            CalculateTotalPrice();
        }

        private static void SelectMeatToppings()
        {
            StringBuilder meatToppings = new StringBuilder();
            option = string.Empty;

            Console.WriteLine("");
            Console.WriteLine("Please select the meat toppings.");
            Console.WriteLine("     1.  Pepperoni");
            Console.WriteLine("     2.  Beef");
            Console.WriteLine("     3.  Sausage");
            Console.WriteLine("     4.  CONTINUE");

            while (option != "4")
            {
                option = string.Empty;

                while (!ValidOption(option))
                {
                    Console.Write("Enter option:  ");
                    option = Console.ReadLine();
                }

                switch (option)
                {
                    case "1":
                    if (meatToppings.Length > 0)
                    { meatToppings.Append(", "); }
                    meatToppings.Append("Pepperoni");
                    meatTypePrice += .75;
                    break;
                    case "2":
                    if (meatToppings.Length > 0)
                    { meatToppings.Append(", "); }
                    meatToppings.Append("Beef");
                    meatTypePrice += .75;
                    break;
                    case "3":
                    if (meatToppings.Length > 0)
                    { meatToppings.Append(", "); }
                    meatToppings.Append("Sausage");
                    meatTypePrice += .75;
                    break;
                    case "4":
                    meatType = meatToppings.ToString();
                    break;
                    default:
                    break;
                }

                CalculateTotalPrice();
            }
        }

        private static void SelectVeggieToppings()
        {
            StringBuilder veggieToppings = new StringBuilder();
            option = string.Empty;

            Console.WriteLine("");
            Console.WriteLine("Please select the meat toppings.");
            Console.WriteLine("     1.  Onion");
            Console.WriteLine("     2.  Tomato");
            Console.WriteLine("     3.  Bell Pepper");
            Console.WriteLine("     4.  CONTINUE");

            while (option != "4")
            {
                option = string.Empty;

                while (!ValidOption(option))
                {
                    Console.Write("Enter option:  ");
                    option = Console.ReadLine();
                }

                switch (option)
                {
                    case "1":
                    if (veggieToppings.Length > 0)
                    { veggieToppings.Append(", "); }
                    veggieToppings.Append("Onion");
                    veggieTypePrice += .50;
                    break;
                    case "2":
                    if (veggieToppings.Length > 0)
                    { veggieToppings.Append(", "); }
                    veggieToppings.Append("Tomato");
                    veggieTypePrice += .50;
                    break;
                    case "3":
                    if (veggieToppings.Length > 0)
                    { veggieToppings.Append(", "); }
                    veggieToppings.Append("Bell Pepper");
                    veggieTypePrice += .50;
                    break;
                    default:
                    break;
                }

                CalculateTotalPrice();
            }
        }

        private static void SelectChesseType()
        {
            option = string.Empty;
            Console.WriteLine("");
            Console.WriteLine("Please select the cheese type.");
            Console.WriteLine("     1.  Regular");
            Console.WriteLine("     2.  Extra");

            while (!ValidOption(option))
            {
                Console.Write("Enter option:  ");
                option = Console.ReadLine();
            }

            switch (option)
            {
                case "1":
                cheeseType = "Regular";
                break;
                case "2":
                cheeseType = "Extra";
                cheeseTypePrice += 1.25;
                break;
                default:
                break;
            }

            CalculateTotalPrice();
        }

        private static void DeliveryType()
        {
            option = string.Empty;
            Console.WriteLine("");
            Console.WriteLine("Please select the delivery type.");
            Console.WriteLine("     1.  Take Out");
            Console.WriteLine("     2.  Delivery");

            while (!ValidOption(option))
            {
                Console.Write("Enter option:  ");
                option = Console.ReadLine();
            }

            switch (option)
            {
                case "1":
                deliveryType = "Take Out";
                deliveryTypePrice = 0;
                break;
                case "2":
                deliveryType = "Delivery";
                deliveryTypePrice = 2.25;
                break;
                default:
                break;
            }

            CalculateTotalPrice();
            orderComplete = true;
        }
        #endregion


        private static bool ValidOption( string option )
        {
            if (option != "1" && option != "2" && option != "3" && option != "4")
            {
                return false;
            }

            return true;
        }

        private static void Close()
        {
            Console.WriteLine("");
            Console.WriteLine("===================================================================");
            Console.WriteLine("");
            Console.WriteLine("Thank you for using My Pizza Creator!");
            Console.WriteLine("This application will self distruct in 3 seconds...");
            Thread.Sleep(3000);
            Environment.Exit(0);
        }


        #region Display Order
        private static void DisplayOrder()
        {
            Console.WriteLine("");

            if (orderComplete)
            {
                Console.WriteLine("===================================================================");
                Console.WriteLine("Your Order:");
                Console.WriteLine(string.Format("   Size:  {0}            ${1}", pizzaSize, pizzaSizePrice.ToString()));
                Console.WriteLine(string.Format("   Crust Type:  {0}", crustType));
                Console.WriteLine(string.Format("   Sauce:  {0}           ${1}", sauceType, sauceTypePrice.ToString()));
                Console.WriteLine(string.Format("   Meat(s):  {0}         ${1}", meatType, meatTypePrice.ToString()));
                Console.WriteLine(string.Format("   Veggie(s):  {0}       ${1}", veggieType, veggieTypePrice.ToString()));
                Console.WriteLine(string.Format("   Cheese Type:  {0}     ${1}", cheeseType, cheeseTypePrice.ToString()));
                Console.WriteLine("");
                Console.WriteLine(string.Format("   Delivery Type:  {0}   ${1}", deliveryType, deliveryTypePrice.ToString()));
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine(string.Format("Total Cost:  ${0}", totalPrice.ToString()));
                Console.WriteLine("===================================================================");
            } else
            {
                Console.WriteLine("No order taken.  Please enter your order.");
                MainMenu();
            }
        }
        #endregion

        #region Modify Order
        private static bool ValidModifyOption( string option )
        {
            if (option != "1" && option != "2" && option != "3" && option != "4" && option != "5" && option != "6" && option != "7" && option != "8")
            {
                return false;
            }

            return true;
        }

        private static void ModifyOrder()
        {
            Console.WriteLine("");

            if (orderComplete)
            {
                while (option != "8")
                {
                    option = string.Empty;
                    Console.WriteLine("");
                    Console.WriteLine("Please select the section you need to modify.");
                    Console.WriteLine("     1.  Pizza Size");
                    Console.WriteLine("     2.  Crust Type");
                    Console.WriteLine("     3.  Sauce Type");
                    Console.WriteLine("     4.  Meat Toppings");
                    Console.WriteLine("     5.  Veggie Toppings");
                    Console.WriteLine("     6.  Cheese Type");
                    Console.WriteLine("     7.  Delivery Type");
                    Console.WriteLine("     8.  CONTINUE");

                    while (!ValidModifyOption(option))
                    {
                        Console.Write("Enter option:  ");
                        option = Console.ReadLine();
                    }

                    switch (option)
                    {
                        case "1":
                        SelectPizzaSize();
                        break;
                        case "2":
                        SelectCrustType();
                        break;
                        case "3":
                        SelectSauceType();
                        break;
                        case "4":
                        SelectMeatToppings();
                        break;
                        case "5":
                        SelectVeggieToppings();
                        break;
                        case "6":
                        SelectChesseType();
                        break;
                        case "7":
                        DeliveryType();
                        break;
                        case "8":
                        DisplayOrder();
                        MainMenu2();
                        break;
                        default:
                        break;
                    }
                }
            } else
            {
                Console.WriteLine("No order taken.  Please enter your order.");
                MainMenu();
            }
        }

        private static void CalculateTotalPrice()
        {
            totalPrice = pizzaSizePrice + sauceTypePrice + meatTypePrice + veggieTypePrice + cheeseTypePrice + deliveryTypePrice;
        }
        #endregion
    }
}
