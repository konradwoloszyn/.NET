using System;
using System.Collections.Generic;
using System.Text;

namespace MyWallet
{
    class AppAction
    {
        public static void Introduction ()
        {
            Console.WriteLine("Welcome to MyWallet app!");
        }

        public static void ActionList()
        {
            Console.WriteLine("\nPlease let me know wahat you want to do:");
            Console.WriteLine("1. Add funds");
            Console.WriteLine("2. Remove last transaction");
            Console.WriteLine("3. Check your balance");
            Console.WriteLine("4. View wallet history");
            Console.WriteLine("0. Exit");
        }
    }
}
