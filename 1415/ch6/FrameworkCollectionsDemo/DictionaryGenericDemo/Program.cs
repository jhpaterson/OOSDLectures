using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictionaryGenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            dict.Add("Chai", 18.0);
            dict.Add("Aniseed Syrup", 17.1);
            dict.Add("Chef Anton's Gumbo Mix", 28.58);
            PrintEntries(dict);
            PrintKeys(dict);
            PrintValues(dict);


            // contains specific key? then remove
            if (dict.ContainsKey("Chai"))
            {
                // get item by key
                double val1 = dict["Chai"];
                Console.WriteLine("Found Chai, price: {0:c}.\n", val1);

                dict.Remove("Chai");
            }

            PrintEntries(dict);

            // error if you try to get a key which is not present
            // double val = dict["stuff"];

            // get safely - use ContainsKey as above or use TryGetValue
            // uses out parameter to set value at same time as checking for key
            double val2;
            dict.TryGetValue("stuff", out val2);                 // not found, value is null or default but no error
            Console.WriteLine("Stuff, price: {0:c}.\n", val2);

            double val3;
            dict.TryGetValue("Aniseed Syrup", out val3);
            Console.WriteLine("Aniseed Syrup, price: {0:c}.\n", val3);
        }

        public static void PrintEntries(Dictionary<string,double> myDictionary)
        {
            foreach (KeyValuePair<string, double> entry in myDictionary)
            {
                Console.WriteLine("{0} price: {1:c}", entry.Key, entry.Value);
            }

            // can also use implicit type for entry
            //foreach (var entry in myDictionary)
            //{
            //    Console.WriteLine("{0} price: {1:c}", entry.Key, entry.Value);
            //}
            Console.WriteLine();
        }

        public static void PrintKeys(Dictionary<string, double> myDictionary)
        {
            // use foreach - can also use Enumerator
            foreach (string key in myDictionary.Keys)
            {
                Console.WriteLine("{0}", key);
            }
            Console.WriteLine();
        }

        public static void PrintValues(Dictionary<string, double> myDictionary)
        {
            foreach (double value in myDictionary.Values)
            {
                Console.WriteLine("{0:c}", value);
            }

            // alternatively use Enumerator 
            //Dictionary<string, double>.ValueCollection.Enumerator denum;
            //denum = myDictionary.Values.GetEnumerator();
            //while (denum.MoveNext()) 
            //{
            //    double value = denum.Current;
            //    Console.WriteLine("{0:c}", value);
            //}

            Console.WriteLine();
        }
    }
}
