using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceDemo
{
    /// <summary>
    /// represents a time sheet
    /// </summary>
    public class TimeSheet
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public TimeSheet()
        {
            // code to construct a TimeSheet object - incomplete
        }

        /// <summary>
        /// adds an entry to a this time sheet
        /// </summary>
        /// <param name="name">name of employee</param>
        /// <param name="hours">hours to be recorded</param>
        public void AddEntry(string name, int hours)
        {
            // do something with this information - incomplete
            Console.WriteLine("recorded that {0} worked {1} hours", name, hours);
        }
    }
}
