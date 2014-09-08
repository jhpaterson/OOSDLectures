using System;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // create objects
            Location loc = new Location { Description = "Head Office", City = "Glasgow" };
            Employee emp1 = new Employee("Michael", "michael", loc, "1234");
            Employee emp2 = new Employee("Susan", "susan", loc, "4321");
            Employee emp3 = new Employee();
            TimeSheet ts = new TimeSheet();

            // use properties
            string uname = emp2.Username;
            Console.WriteLine("Email address for Susan is {0}", emp2.Email);
            emp2.PhoneNumber = "5678";
            TimeSheet.MaxEntries = 100;

            // send messages (call methods)
            emp1.RecordOvertime(ts, 5, true);    // note that as a result of this, emp1 sends a message to ts
            int overTime = emp1.TotalOvertime(ts);
            Console.WriteLine("total hours for Michael: {0}", overTime);
            TimeSheet.IncreaseMaxEntriesBy(50);

            // wait for key press before ending
            Console.ReadLine();

            double angle = Math.PI;
            double result = Math.Sin(angle);
        }
    }
}
