using System;


namespace StorageDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // create objects
            Location loc = new Location();
            Employee emp1 = new Employee(1, "Michael", "michael", loc, "1234");
            FileTimeSheet fts = new FileTimeSheet(@"timesheet.dat");
            DatabaseTimeSheet dts = new DatabaseTimeSheet(@"mydb");
            //ITimeSheet ts = new FileTimeSheet(@"timesheet.dat");

            // send messages (call methods)
            emp1.RecordOvertime(fts, 8, PayRate.Weekend);
            emp1.RecordOvertime(fts, 5, PayRate.Day);
            emp1.RecordOvertime(dts, 8, PayRate.Weekend);
            emp1.RecordOvertime(dts, 5, PayRate.Day);
            //emp1.RecordOvertime(ts, 10, PayRate.Day);

            // wait for key press before ending
            Console.ReadLine();
        }
    }
}
