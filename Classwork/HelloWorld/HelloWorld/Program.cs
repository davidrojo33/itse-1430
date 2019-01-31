/*
 * Lab 1
 * Your Name
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    // Single line comment
    class Program
    {
        static void Main( string[] args )
        {
            NewGame();
            DisplayGame();
        }

        private static void CSharpBasics()
        {
            string name;
            int hours = 8; //8L
            double payRate = 8.25; //8.25F
            int length = 10, width = 12;
            int aReallyLongIdentifierJustToSeeHowLongICanGo;
            char ch = 'X';
            bool result = true; //false
            //int counter;

            //Never!!!!

            //int a, b;            
            Console.WriteLine(hours);
            //name = "Sue";
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            //string message = "Hello " + name;
            string message = "Hello ";
            message += name;

            Console.WriteLine(message);
            //Console.Write("Hello ");
            //Console.WriteLine(name);
        }

        private static void NewGame()
        {
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();

            //Console.WriteLine("Do you own this? ");
            //string owned = Console.ReadLine();
            owned = ReadBoolean("Owned (Y/N)?");

            //Console.WriteLine("Price? ");
            //string price = Console.ReadLine();
            price = ReadDecimal("Price?");

            Console.WriteLine("Publisher? ");
            publisher = Console.ReadLine();

            //Console.WriteLine("Completed? ");
            //string completed = Console.ReadLine();
            completed = ReadBoolean("Completed (Y/N)?");
        }

        private static void DisplayGame()
        {
            var literal1 = "Hello \"Bob\"";
            var path = "C:\\Windows\\System32";
            path += "\\Temp";
            var path2 = @"C:\Windows\System32";

            // 1. String concat
            Console.WriteLine("Name" + name);

            // 2. String Format
            var str = String.Format("Price: {0:C}", price);
            Console.WriteLine(str);
            //Console.WriteLine("Price: $" + price);

            // 3. Function overload - just calls String.Format
            Console.WriteLine("Publisher: {0} ", publisher);

            // 4. Concatenation
            str = String.Concat("Owned?", " ", owned);
            Console.WriteLine(str);
            //Console.WriteLine("Owned? " + owned);

            // 5. Interpolation
            //Console.WriteLine("Completed? " + completed);            
            //Console.WriteLine("Completed? {0}", completed);
            //String.Format("Completed? {0}", completed);
            //$"Completed? {completed}";
            Console.WriteLine($"Completed? {completed}");

            // Convert to a string
            string strPrice = price.ToString("C");
            string strLiteral = "Hello".ToString();
            //ReadBoolean("Hello").ToString();
            10.ToString(); // "10"

            //Is string empty?
            string input = "";
            //int length = input.Length;
            bool isEmpty;

            // 1.
            //if (input != null)
            //    isEmpty = input.Length == 0;
            //else
            //    isEmpty = true;

            // 2.
            isEmpty = (input != null) ? input.Length == 0 : true;

            // 3.
            isEmpty = input == "";

            // 4.
            isEmpty = input == String.Empty;

            // 5.
            isEmpty = String.IsNullOrEmpty(input);

            //Comparison
            bool areEqual = "Hello" == "hello";
            areEqual = String.Compare("Hello", "hello", true) == 0;

            //Conversion
            input = input.ToUpper();
            input = input.ToLower();

            //Manipulation
            bool startsWith = input.StartsWith("http:");
            bool endsWith = input.EndsWith("/");

            input = input.TrimStart();
            input = input.TrimEnd();
            input = input.Trim();

            input = input.PadLeft(10);
            input = input.PadRight(10, '-');

        }

        private static bool ReadBoolean( string message )
        {
            do
            {
                Console.WriteLine(message);
                string result = Console.ReadLine().ToUpper();

                //Validate it is a boolean
                if (result == "Y")
                    return true;
                if (result == "N")
                    return false;

                //switch (result)
                //{
                //    case "Y":
                //    case "y": return true;

                //    case "N": 
                //    case "n": return false;

                //    default: Console.WriteLine("Enter Y or N"); break;
                //};

                //if (result == "Y" || "y")
                //if (result == "Y" || result == "y")
                //if (result == "y")
                //  return true;
                //if (result == "n")
                //  return false;

                Console.WriteLine("Enter Y or N");
            } while (true);
        }

        //bool TryParse( string input, out decimal result );

        private static decimal ReadDecimal( string message )
        {
            while (true)
            {
                Console.WriteLine(message);
                string value = Console.ReadLine();

                //decimal result;
                ///if (Decimal.TryParse(value, out result))            
                if (Decimal.TryParse(value, out var result))
                    return result;

                Console.WriteLine("Enter a valid decimal value");
            };
        }

        private static void PlayWithArrays()
        {
            //int size = 100;
            int[] prices = new int[100];
            for (var index = 0; index < prices.Length; ++index)
            {
                prices[index] = index + 1;
            };

            DisplayArray(prices);

            var input = "field1,field2,field3;field4,,field5";
            var fields = input.Split(',', ';');
        }

        private static void DisplayArray( int[] values/*, int count*/ )
        {
            //for (var index = 0; index < values.Length; ++index)
            foreach (var item in values)
            {
                //Console.WriteLine(values[index]);
                Console.WriteLine(item);
            };
        }

        private static string name;
        private static string publisher;
        private static decimal price;
        private static bool owned;
        private static bool completed;
    }
}
