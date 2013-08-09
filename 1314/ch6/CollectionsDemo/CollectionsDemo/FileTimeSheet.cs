using System;

namespace CollectionsDemo
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
        public void AddEntry(string name, int hours)
        {
            // store information in file - incomplete
            Console.WriteLine("recorded that {0} worked {1} hours", name, hours);
            Console.WriteLine("stored in file: {0}", filename);
        }
    }
}
