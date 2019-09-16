using System;

namespace TestTaskInvoice
{
    /// <summary>
    /// Class represent invoice from DB.
    /// </summary>
    internal class Invoice
    {
        internal int ID { get; set; }
        internal string Date { get; set; }
        internal string Client { get; set; }
        internal Decimal Amount { get; set; }

        internal Invoice(DateTime dateTime, string client, Decimal amount)
        {
            //TODO: Add arguments check
            Date = dateTime.ToString("MM/dd/yyyy");
            Client = client;
            Amount = amount;
        }

        internal Invoice(DateTime dateTime, string client, Decimal amount, int id) 
            : this(dateTime, client, amount) => ID = id;

        internal Invoice() { }
    }
}
