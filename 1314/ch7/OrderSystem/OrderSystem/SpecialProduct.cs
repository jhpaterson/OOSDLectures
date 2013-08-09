using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderSystem
{
    /// <summary>
    /// represents a product with a discount code
    /// </summary>
    public class SpecialProduct : Product
    {
        private string discountCode;

        /// <summary>
        /// the discount code
        /// </summary>
        public string DiscountCode
        {
            get { return discountCode; }
            set { discountCode = value; }
        }

        /// <summary>
        /// constructor for objects of type SpecialProduct
        /// </summary>
        /// <param name="name">the product name</param>
        /// <param name="productID">the product ID</param>
        /// <param name="price">the product price</param>
        /// <param name="discountCode">the discount code</param>
        public SpecialProduct(
             string name, string productID, decimal price, string discountCode) :
            base(name, productID, price)
        {
            this.discountCode = discountCode;
        }

        /// <summary>
        /// the price of the product
        /// overrides Price property in base class
        /// </summary>
        public new decimal Price
        {
            get
            {
                if (discountCode.Equals("A"))
                {
                    return price * 0.9m;
                }
                else if (discountCode.Equals("B"))
                {
                    return price * 0.75m;
                }
                else
                {
                    return price;
                }
            }
            set { price = value; }
        }

    }
}
