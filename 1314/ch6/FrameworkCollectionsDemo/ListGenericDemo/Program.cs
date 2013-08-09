using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListGenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new List<DateTime> and add in some objects
            List<DateTime> aList = new List<DateTime>();

            aList.Add(new DateTime(1968, 4, 5));
            aList.AddRange(new DateTime[] {
                new DateTime(1965, 1, 19),
                new DateTime(1994, 12, 3),
                new DateTime(1966, 2, 1),
                new DateTime(1997, 7, 2)});

            // alternatively, create complete List using object initializer syntax
            //List<DateTime> aList = new List<DateTime>{
            //    new DateTime(1968, 4, 5),
            //    new DateTime(1965, 1, 19),
            //    new DateTime(1994, 12, 3),
            //    new DateTime(1966, 2, 1),
            //    new DateTime(1997, 7, 2)
            //};

            Console.WriteLine("Count:    {0}", aList.Count);
            Console.WriteLine("Capacity: {0}", aList.Capacity);
            PrintValues(aList);

            // Get second item in list
            DateTime dt = aList[1];     // no need to cast, no unboxing (DateTime items stored as an array of value types)
            Console.WriteLine("aList[1] = {0}", dt.ToShortDateString());

            // Trim capacity
            aList.TrimExcess();    // c.f. TrimToSize in non-generic list
            Console.WriteLine("Count:    {0}", aList.Count);
            Console.WriteLine("Capacity: {0}", aList.Capacity);

            // Get first three items
            List<DateTime> firstThree = aList.GetRange(0, 3);
            PrintValues(firstThree);

            // find using a Predicate function
            List<DateTime> sixtiesDates = aList.FindAll(IsSixties);
            Console.WriteLine("Sixties dates");
            PrintValues(sixtiesDates);

            // find using a lambda expression
            DateTime firstSixtiesDate = aList.Find(d => (d.Year >= 1960 && d.Year < 1970));
            Console.WriteLine("First sixties date: {0}", firstSixtiesDate.ToShortDateString());

            // find index using a lambda expression and remove
            int target = aList.FindIndex(d => d.Year == 1994);
            aList.RemoveAt(target);
            Console.WriteLine("Removed first item with year = 1994");
            PrintValues(aList);

            // remove all using a lambda expression
            aList.RemoveAll(d => (d.Year >= 1960 && d.Year < 1970));
            Console.WriteLine("Removed all sixties dates");
            PrintValues(aList);
        }

        public static void PrintValues(IEnumerable<DateTime> myList)
        {
            foreach (DateTime dt in myList)
            {
                Console.WriteLine("{0}", dt.ToShortDateString());
            }
        }

        private static bool IsSixties(DateTime dt)
        {
            if (dt.Year >= 1960 && dt.Year < 1970)
                return true;
            else
                return false;
        }

    }
}
