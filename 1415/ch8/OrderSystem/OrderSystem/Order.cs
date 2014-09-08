using System;
using System.Collections.Generic;

namespace OrderSystem
{
    /// <summary>
    /// represents an order
    /// </summary>
    public class Order
    {
        private string ordNumber;
        private DateTime dateReceived;
        private Customer customer;
        private List<OrderLine> orderLines;
     

        /// <summary>
        /// the order number
        /// </summary>
        public string OrdNumber
        {
            get { return ordNumber; }
        }
        
        /// <summary>
        /// the date the order was received
        /// </summary>
        public DateTime DateReceived
        {
            get { return dateReceived; }
        }

        /// <summary>
        /// the customer who placed this order
        /// </summary>
        public Customer Customer
        {
            get { return customer; }
        }

        /// <summary>
        /// the order lines
        /// </summary>
        public List<OrderLine> OrderLines
        {
            get { return orderLines; }
        }

        /// <summary>
        /// constructor for objects of type Order
        /// </summary>
        /// <param name="ordNumber"></param>
        /// <param name="dateReceived"></param>
        /// <param name="customer"></param>
        public Order(string ordNumber, DateTime dateReceived, 
            Customer customer)
        {
            this.ordNumber = ordNumber;
            this.dateReceived = dateReceived;
            this.customer = customer;
            this.orderLines = new List<OrderLine>();
            customer.AddOrder(this);
        }

        // calculates the discount price based on the full price
        // and the customer's discount level
        private decimal CalcDiscPrice(decimal price)
        {
            decimal discount = customer.Discount;
            decimal discPrice = price * (1 - discount);
            return discPrice;
        }

        /// <summary>
        /// calculates the order price by adding the
        /// prices of all order lines and applying
        /// customer discount
        /// </summary>
        /// <returns></returns>
        public decimal CalcPrice()
        {
            decimal price = 0.0m;
            foreach (OrderLine ol in orderLines)
            {
                decimal linePrice = ol.LinePrice;
                price = linePrice;                     // error - should add
            }
            price = CalcDiscPrice(price);
            return price;
        }

        /// <summary>
        /// add an order line for a specified quantity of a product
        /// </summary>
        /// <param name="quantity">the line quantity</param>
        /// <param name="product">the product</param>
        public void AddLine(int quantity, Product product)
        {
            OrderLine newOrderLine = new OrderLine{
                Quantity = quantity,
                Product = product
            };
            orderLines.Add(newOrderLine);
        }

        /// <summary>
        /// raise an invoice for this order
        /// </summary>
        /// <returns>the invoice</returns>
        public Invoice RaiseInvoice()
        {
            string invoiceID = "I-" + ordNumber;
            Invoice invoice = new Invoice
            {
                InvoiceID = invoiceID,
                Date = DateTime.Now,
                Status = PaymentStatus.Unpaid,
                Order = this
            };
            return invoice;
        }

    }
}
