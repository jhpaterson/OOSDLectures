using System;


namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // create objects
            Location loc = new Location { Description = "Head Office", City = "Glasgow" };
            Employee emp1 = new Employee(1, "Michael", "michael", loc, "1234");
            FileTimeSheet fts = new FileTimeSheet(@"c:\file.dat");
            DatabaseTimeSheet dts = new DatabaseTimeSheet(@"mydb");
            ITimeSheet ts = new FileTimeSheet(@"d:\file.dat");

            // send messages (call methods)
            emp1.RecordOvertime(fts, 5, PayRate.Weekend);
            emp1.RecordOvertime(dts, 8, PayRate.Weekend);
            emp1.RecordOvertime(ts, 10, PayRate.Day);

            // wait for key press before ending
            Console.ReadLine();
        }
    }
}
