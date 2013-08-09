using System;


namespace OrderSystem
{
    public enum PaymentStatus
    {
        Unpaid, Paid, Overdue
    }
    
    
    /// <summary>
    /// represents an invoice
    /// </summary>
    public class Invoice
    {
        private string invoiceID;
        private DateTime date;
        private PaymentStatus status;
        private Order order;

        // no constructor - construct with object initializer

        /// <summary>
        /// the invoice id
        /// </summary>
        public string InvoiceID
        {
            get { return invoiceID; }
            set { invoiceID = value; }
        }
        
        /// <summary>
        /// the invoice date
        /// </summary>
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        
        /// <summary>
        /// the invoice status payment status
        /// </summary>
        public PaymentStatus Status
        {
            get { return status; }
            set { status = value; }
        }
        
        /// <summary>
        /// the order which raised this invoice
        /// </summary>
        public Order Order
        {
            get { return order; }
            set { order = value; }
        }

    }
}
