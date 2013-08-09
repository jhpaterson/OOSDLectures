using System;

namespace SimpleAssociation
{
    public class Program
    {
        static void Main(string[] args)
        {
            // create objects
            Used used1 = new Used("used 1");
            Uses uses = new Uses("uses");

            // call methods
            Console.WriteLine("Method parameter: {0}", uses.Use(used1));
            Console.WriteLine("Local variable: {0}", uses.SomeMethod("used 2"));
            Used used3 = uses.GetUsed("used 3");
            Console.WriteLine("Return value: {0}", used3.SomeProperty);

            Console.ReadLine();
        }
    }
}
