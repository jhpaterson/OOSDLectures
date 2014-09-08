using OrderSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OrderSystemTestProject
{
    
    
    /// <summary>
    ///This is a test class for OrderTest and is intended
    ///to contain all OrderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class OrderTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for AddLine
        ///</summary>
        [TestMethod()]
        public void AddLineTest()
        {
            // Arrange
            string ordNumber = "O1"; 
            DateTime dateReceived = DateTime.Now; 
            Customer customer = new Customer(null,null,0.0m,null); 
            Order target = new Order(ordNumber, dateReceived, customer); 
            int quantity = 5; 
            Product product = new Product("PRODUCTNAME",null,0.0m);
            target.AddLine(quantity, product);

            // Act
            string result = target.OrderLines[0].Product.Name;

            // Assert
            Assert.AreEqual("PRODUCTNAME", result);
        }

        /// <summary>
        ///A test for CalcPrice
        ///</summary>
        [TestMethod()]
        public void CalcPriceTest()
        {
            // Arrange
            string ordNumber = "O2"; 
            DateTime dateReceived = DateTime.Now;
            Customer customer = new Customer(null, null, 0.10m, null);
            Order target = new Order(ordNumber, dateReceived, customer);
            Product product1 = new Product(null, null, 20.0m);
            Product product2 = new Product(null, null, 30.0m);
            target.AddLine(1, product1);
            target.AddLine(2, product2);

            // Act
            Decimal result = target.CalcPrice();

            // Assert
            Assert.AreEqual(72.0m, result);
        }
    }
}
