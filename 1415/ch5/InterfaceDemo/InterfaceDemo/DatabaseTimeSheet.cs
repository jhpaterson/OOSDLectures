using System;

namespace InterfaceDemo
{
    /// <summary>
    /// a time sheet which stores entries in a database
    /// </summary>
    public class DatabaseTimeSheet : ITimeSheet
    {
        private string database;

        /// <summary>
        /// constructor for objects of type DatabaseTimeSheet
        /// </summary>
        /// <param name="database">the database name</param>
        public DatabaseTimeSheet(string database)
        {
            this.database = database;
        }

        /// <summary>
        /// adds an entry to a this time sheet
        /// </summary>
        /// <param name="name">name of employee</param>
        /// <param name="hours">hours to be recorded</param>
        public void AddEntry(string name, int hours)
        {
            // store information in database - incomplete
            Console.WriteLine("recorded that {0} worked {1} hours", name, hours);
            Console.WriteLine("stored in database: {0}", database);
        }
    }
}
