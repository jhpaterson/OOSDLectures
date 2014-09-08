using System;


namespace CompositionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // create objects
            Location loc = new Location { Description = "Head Office", City = "Glasgow" };
            HourlyPaidEmployee hpemp1 = new HourlyPaidEmployee(1, "Michael", "michael", loc, "1234");
            Employee emp2 = new Employee(2, "Susan", "susan", loc, "5678");
            SalariedEmployee semp2 = new SalariedEmployee(emp2, 6);
            DatabaseTimeSheet dts = new DatabaseTimeSheet(@"mydb");

            // send messages (call methods)
            Console.WriteLine("Email address for {0}: {1}", hpemp1.Name, hpemp1.Email());
            hpemp1.RecordTime(dts, 5, PayRate.Weekend);
            Console.WriteLine("Email address for {0}: {1}", semp2.Name, emp2.Email());
            int newGrade = semp2.PayIncrement();
            Console.WriteLine("New grade for {0}: {1}", semp2.Name, newGrade);

            // change Susan's role to an HourlyPaidEmployee
            HourlyPaidEmployee hpemp2 = new HourlyPaidEmployee(emp2);
            semp2 = null;
            hpemp2.RecordTime(dts, 5, PayRate.Weekend);
            Console.WriteLine("Email address for {0}: {1}", hpemp2.Name, hpemp2.Email());

            // wait for key press before ending
            Console.ReadLine();
        }
    }
}
