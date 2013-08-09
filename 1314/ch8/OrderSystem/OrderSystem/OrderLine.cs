using System;


namespace OrderSystem
{
    /// <summary>
    /// represents an order line
    /// </summary>
    public class OrderLine
    {
        private int quantity;
        private Product product;

        // no constructor - construct with object initializer

        /// <summary>
        /// the line quantity
        /// </summary>
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        
        /// <summary>
        /// the line product
        /// </summary>
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        /// <summary>
        /// the line price = quan
        /// </summary>
        public decimal LinePrice
        {
            get
            {
                return quantity * product.Price;
            }
        }
    }
}
