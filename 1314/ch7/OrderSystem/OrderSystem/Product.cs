using System;
using System.Collections.Generic;


namespace OrderSystem
{
    /// <summary>
    /// represents a product
    /// </summary>
    public class Product 
    {
        protected string name;
        protected string productID;
        protected decimal price;
        protected List<Contract> suppliers;

        /// <summary>
        /// the product name
        /// </summary>
        public string Name
        {
            get { return name; }
        }
        
        /// <summary>
        /// the product id
        /// </summary>
        public string ProductID
        {
            get { return productID; }
        }

        /// <summary>
        /// the product price
        /// </summary>
        public virtual decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// constructor for objects of type Product
        /// </summary>
        /// <param name="name">the product name</param>
        /// <param name="productID">the product ID</param>
        /// <param name="price">the product price</param>
        public Product(string name, string productID, decimal price)
        {
            this.name = name;
            this.productID = productID;
            this.price = price;
            this.suppliers = new List<Contract>();
        }

        /// <summary>
        /// add a contract for the supply of this product with
        /// a specified supplier
        /// </summary>
        /// <param name="supplier">the supplier</param>
        /// <param name="supplyPrice">the price charged by the supplier</param>
        public void AddSupplier(Supplier supplier, decimal supplyPrice)
        {
            Contract contract = new Contract
            {
                Supplier = supplier,
                SupplyPrice = supplyPrice,
                Product = this
            };
            suppliers.Add(contract);
            supplier.AddProduct(contract);
        }
    }
}
