using System;


namespace OrderSystem
{
    /// <summary>
    /// represents a contract with a supplier to supply
    /// this is an association class connecting a product with
    /// a supplier
    /// a product
    /// </summary>
    public class Contract
    {
        private decimal supplyPrice;
        private Supplier supplier;
        private Product product;

        /// <summary>
        /// the price charged by the supplier
        /// </summary>
        public decimal SupplyPrice
        {
            get { return supplyPrice; }
            set { supplyPrice = value; }
        }
        
        /// <summary>
        /// the supplier
        /// </summary>
        public Supplier Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }

        /// <summary>
        /// the product
        /// </summary>
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

    }
}
