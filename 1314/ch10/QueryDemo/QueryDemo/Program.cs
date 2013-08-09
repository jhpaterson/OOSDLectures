using System;
using System.Data.SqlServerCe;


namespace QueryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // create connection to database
            using (SqlCeConnection conn = new SqlCeConnection(@"Data Source=payroll.sdf"))
            {
                string selectQuery;

                // build query string
                if (args.Length == 0)
                {
                    selectQuery =
                        @"SELECT employeename, username, department FROM Employees";
                }
                else
                {
                    selectQuery =
                        @"SELECT employeename, username, department FROM Employees";
                    selectQuery += " WHERE department ='";
                    selectQuery += args[0];
                    selectQuery += "'";
                }

                // create command object
                SqlCeCommand command = new SqlCeCommand(selectQuery, conn);
                command.Connection.Open();

                // execute select query               
                SqlCeDataReader dr = command.ExecuteReader();

                // Call Read before accessing data.
                while (dr.Read())
                {
                    Console.WriteLine(String.Format("{0}, {1} , {2}",
                        dr[0], dr[1], dr[2]));
                }

                dr.Close();
            }

            Console.ReadLine();
        }
    }
}
