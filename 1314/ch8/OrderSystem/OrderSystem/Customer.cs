using System;
using System.Collections.Generic;


namespace OrderSystem
{
    /// <summary>
    /// represents a customer
    /// </summary>
    public class Customer
    {
        private string lastName;
        private string firstName; 
        private decimal discount;
        private Address address;
        private IDictionary<string, Order> orders;

        /// <summary>
        /// the customer's last name
        /// </summary>
        public string LastName
        {
            get { return lastName; }
        }

        /// <summary>
        /// the customer's first name
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
        }
       
        /// <summary>
        /// the customer's discount level
        /// </summary>
        public decimal Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        
        /// <summary>
        /// the customer's address
        /// </summary>
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// constructor for objects of type Customer
        /// </summary>
        /// <param name="lastName">the last name</param>
        /// <param name="firstName">the first name</param>
        /// <param name="discount">the discount level</param>
        /// <param name="address">the address</param>
        public Customer(string lastName, string firstName, decimal discount, Address address)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.discount = discount;
            this.address = address;
            this.orders = new Dictionary<string, Order>();
        }

        /// <summary>
        /// add a new order for this customer
        /// called in constructor of Order
        /// </summary>
        /// <param name="newOrder">the order to add</param>
        public void AddOrder(Order newOrder)
        {
            orders.Add(newOrder.OrdNumber, newOrder);
        }

       

    }
}
