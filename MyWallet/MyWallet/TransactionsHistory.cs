using System;
using System.Collections.Generic;
using System.Text;

namespace MyWallet
{
    class TransactionsHistory
    {
        private List<Transaction> Transactions { get; set; }
        public TransactionsHistory()
        {
            Transactions = new List<Transaction>();
        }
        public void ViewTransactions()
        {
            foreach (Transaction transaction in Transactions)
            {
                Console.WriteLine($"\nID operacji: {transaction.TransactionId} | Wartość: {transaction.Value} | Data: {transaction.TransactionTime} | Opis: {transaction.Description}");
            }
        }
        public void AddTransaction(decimal value, string description)
        {
            var transaction = new Transaction
            {
                Value = value,
                TransactionTime = DateTime.Now,
                Description = description,
                TransactionId = (Transactions.Count +1)
            };
            Transactions.Add(transaction);
        }
        public void RemoveLastTransaction()
        {
            Transactions.Remove(Transactions[Transactions.Count-1]);
        }
        public void CheckBalance()
        {
            decimal Balance = 0;
            foreach (Transaction transaction in Transactions)
            {
                Balance += transaction.Value;
            }
            Console.WriteLine($"\nTwój balans konta: {Balance}");
        }
    }
}
