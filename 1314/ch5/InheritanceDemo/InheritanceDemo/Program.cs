using System;


namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // create objects
            Location loc = new Location { Description = "Head Office", City = "Glasgow" };
            HourlyPaidEmployee emp1 = new HourlyPaidEmployee(1, "Michael", 
                "michael", loc, "1234");
            SalariedEmployee emp2 = new SalariedEmployee(2, "Susan", "susan", 
                loc, "5678", 6);
            Employee emp3 = new HourlyPaidEmployee(3, "Ahmad", "ahmad",
                loc, "4321");
            Department dep = new Department();
            dep.AddEmployee(emp1);
            dep.AddEmployee(emp2);
            dep.AddEmployee(emp3);
            DatabaseTimeSheet dts = new DatabaseTimeSheet(@"mydb");

            // send messages (call methods)
            Console.WriteLine("Email address for {0}: {1}", emp1.Name, emp1.Email());
            emp1.RecordTime(dts, 5, PayRate.Weekend);
            Console.WriteLine("Email address for {0}: {1}", emp2.Name, emp2.Email());
            int newGrade = emp2.PayIncrement();
            Console.WriteLine("New grade for {0}: {1}", emp2.Name, newGrade);
            Console.WriteLine("Email address for {0}: {1}", emp3.Name, emp3.Email());

            Object o = new HourlyPaidEmployee();
            SalariedEmployee semp = o as SalariedEmployee;

            // wait for key press before ending
            Console.ReadLine();
        }
    }
}
