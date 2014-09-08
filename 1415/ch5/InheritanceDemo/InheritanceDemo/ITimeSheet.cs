using System;

namespace InheritanceDemo
{
    public interface ITimeSheet
    {
        /// <summary>
        /// adds an entry to a this time sheet
        /// </summary>
        /// <param name="name">name of employee</param>
        /// <param name="hours">hours to be recorded</param>
        void AddEntry(string name, int hours);

    }
}
