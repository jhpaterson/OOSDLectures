using System;
using System.Data.OleDb;
using System.Data.SqlServerCe;

namespace StorageDemo
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
        public void AddEntry(int employeeId, int hours)
        {
            // create connection to database
            using (SqlCeConnection conn = new SqlCeConnection(@"Data Source=payroll.sdf"))
            {
                // build query string
                string insertQuery =
                    @"INSERT INTO TimesheetEntries(entrydate,employeeid, hours)";
                insertQuery += "VALUES ('";
                insertQuery += DateTime.Now.ToString("yyyy-MM-dd") + "', ";     // ISO date format to avoid date format errors
                insertQuery += employeeId + ", ";
                insertQuery += hours + ")";

                // create command object
                SqlCeCommand command = new SqlCeCommand(insertQuery, conn);
                command.Connection.Open();

                // execute insert query
                int rowsAffected = command.ExecuteNonQuery();

                Console.WriteLine("rows affected: {0}", rowsAffected);
            }
        }
    }
}
