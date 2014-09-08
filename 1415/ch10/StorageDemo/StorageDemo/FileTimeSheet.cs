using System;
using System.IO;

namespace StorageDemo
{
    /// <summary>
    /// a time sheet which stores entries in a file
    /// </summary>
    public struct FileTimeSheet : ITimeSheet
    {
        private string filename;

        /// <summary>
        /// constructor for objects of type FileTimeSheet
        /// </summary>
        /// <param name="filename">the file name</param>
        public FileTimeSheet(string filename)
        {
            this.filename = filename;
        }

        /// <summary>
        /// adds an entry to a this time sheet
        /// </summary>
        /// <param name="name">name of employee</param>
        /// <param name="hours">hours to be recorded</param>
        public void AddEntry(int employeeId, int hours)
        {
            // store information in file 
            FileStream fs = new FileStream(filename, 
                FileMode.Append, FileAccess.Write);

            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("{0}:{1},{2}", DateTime.Now.ToShortDateString(), 
                    employeeId, hours);
            }

            Console.WriteLine("Entry stored to file");
        }
    }
}
