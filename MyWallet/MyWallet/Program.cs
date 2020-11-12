using System;

namespace MyWallet
{
    class Program
    {
        static void Main(string[] args)
        {

            AppAction.Introduction();
            AppAction.ActionList();
            TransactionsHistory transactionsHistory = new TransactionsHistory();
            var menuOption = Console.ReadKey();
            while (menuOption.KeyChar != '0')
            {
                switch (menuOption.KeyChar)
                {
                    case '1':
                        Console.WriteLine("\n \rPodaj wartość transakcji: ");
                        var valueInput = Console.ReadLine();
                        Decimal.TryParse(valueInput, out decimal value);
                        Console.WriteLine("\n \rPodaj opis transakcji: ");
                        string description = Console.ReadLine();
                        transactionsHistory.AddTransaction(value, description);
                        break;

                    case '2':
                        transactionsHistory.RemoveLastTransaction();
                        break;

                    case '3':
                        transactionsHistory.CheckBalance();
                        break;

                    case '4':
                        transactionsHistory.ViewTransactions();
                        break;
                }
                AppAction.ActionList();
                menuOption = Console.ReadKey();
            }

        }
    }
}
