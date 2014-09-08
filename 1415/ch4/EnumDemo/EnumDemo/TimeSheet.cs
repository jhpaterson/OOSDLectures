﻿using System;

namespace EnumDemo
{
    /// <summary>
    /// represents a time sheet
    /// </summary>
    public class TimeSheet
    {
        // INSTANCE VARIABLES

        private int numberOfEntries;

        // STATIC VARIABLES

        private static int maxEntries;

        // PROPERTIES

        /// <summary>
        /// the current number of time sheet entries
        /// </summary>
        public int NumberOfEntries
        {
            get { return numberOfEntries; }
        }

        /// <summary>
        /// the maximum number of time sheet entries
        /// </summary>
        public static int MaxEntries
        {
            get { return TimeSheet.maxEntries; }
            set { TimeSheet.maxEntries = value; }
        }

        // CONSTRUCTORS

        /// <summary>
        /// default constructor
        /// </summary>
        public TimeSheet()
        {
            // code to construct a TimeSheet object - incomplete
            numberOfEntries = 0;
            maxEntries = 10;
        }


        // METHODS

        /// <summary>
        /// adds an entry to a this time sheet
        /// </summary>
        /// <param name="name">name of employee</param>
        /// <param name="hours">hours to be recorded</param>
        public void AddEntry(string name, int hours)
        {
            // do something with this information - incomplete
            Console.WriteLine("recorded that {0} worked {1} hours", name, hours);
            numberOfEntries++;
        }

        /// <summary>
        /// increases the value of maxEntries by a specified number
        /// </summary>
        /// <param name="increment">the number to increase by</param>
        public static void IncreaseMaxEntriesBy(int increment)
        {
            TimeSheet.maxEntries += increment;
        }
    }
}
