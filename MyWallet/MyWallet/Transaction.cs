using System;
using System.Collections.Generic;
using System.Text;

namespace MyWallet
{
    public class Transaction
    {
        public decimal Value { get; set; }
        public DateTime TransactionTime { get; set; }
        public string Description { get; set; }
        public int TransactionId { get; set; }


    }

    
}
