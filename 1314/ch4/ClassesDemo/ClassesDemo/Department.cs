using System;
using System.Collections.Generic;

namespace ClassesDemo
{
    /// <summary>
    /// represents a department
    /// </summary>
    class Department
    {
        List<Employee> employees;

        /// <summary>
        /// default constructor
        /// </summary>
        public Department()
        {
            employees = new List<Employee>();
        }
    }
}
