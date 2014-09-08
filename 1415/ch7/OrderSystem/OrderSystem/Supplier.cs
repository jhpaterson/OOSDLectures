using System;
using System.Collections.Generic;


namespace OrderSystem
{
    /// <summary>
    /// represents a supplier
    /// </summary>
    public class Supplier
    {
        private string supplierID;
        private string name;
        private string contactName;
        private List<Contract> contracts;

       /// <summary>
       /// the supplier ID
       /// </summary>
        public string SupplierID
        {
            get { return supplierID; }
        }
        
        /// <summary>
        /// the supplier name
        /// </summary>
        public string Name
        {
            get { return name; }
        }
        
        /// <summary>
        /// the name of the supplier contact
        /// </summary>
        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }

        /// <summary>
        /// the suppliers contracts with this company
        /// </summary>
        public List<Contract> Contracts
        {
            get { return contracts; }
        }

        /// <summary>
        /// constructor for objects of type Supplier
        /// </summary>
        /// <param name="supplierID">the supplier ID</param>
        /// <param name="name">the supplier name</param>
        /// <param name="contactName">the supplier contact name</param>
        public Supplier(string supplierID, string name, string contactName)
        {
            this.name = name;
            this.supplierID = supplierID;
            this.contactName = contactName;
            contracts = new List<Contract>();
        }

        /// <summary>
        /// add a contract to supply a product
        /// </summary>
        /// <param name="contract"></param>
        public void AddProduct(Contract contract)
        {
            contracts.Add(contract);
        }

    }
}
