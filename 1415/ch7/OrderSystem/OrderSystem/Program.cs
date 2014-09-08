using System;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Address add1 = new Address
            {
                Number = "1",
                Street = "First Street",
                Town = "Glasgow",
                Postcode = "G99 9GL"
            };
            Customer cust1 = new Customer("Schumacher", "Michael", 0.1m, add1);
            
            Product prod1 = new Product("widget","P1", 10.99m);
            Product prod2 = new Product("gadget", "P2", 8.99m);
            Supplier supp1 = new Supplier("S1", "Acme", "Timo Glock");
            prod1.AddSupplier(supp1, 4.99m);
            prod1.AddSupplier(supp1, 2.99m);

            Order ord1 = new Order("O1", DateTime.Now, cust1);
            ord1.AddLine(3, prod1);
            ord1.AddLine(2, prod2);

            Invoice inv1 = ord1.RaiseInvoice();

            Console.WriteLine("Order price: {0:C}", ord1.CalcPrice());

            Console.ReadLine();
        }
    }
}
