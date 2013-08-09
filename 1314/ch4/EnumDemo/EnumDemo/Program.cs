using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // create objects
            Location loc = new Location { Description = "Head Office", City = "Glasgow" };
            Employee emp1 = new Employee(1, "Michael", "michael", loc, "1234");
            TimeSheet ts = new TimeSheet();


            // send messages (call methods)
            emp1.RecordOvertime(ts, 5, PayRate.Holiday);   

            // wait for key press before ending
            Console.ReadLine();

        }
    }
}
