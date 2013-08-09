using System;
using System.Collections.Generic;

namespace CollectionsDemo
{
    /// <summary>
    /// represents a department
    /// </summary>
    class Department
    {
        // INSTANCE VARIABLES

        private List<Employee> employees;

        // CONSTRUCTOR

        /// <summary>
        /// constructor for department 
        /// </summary>
        public Department()
        {
            employees = new List<Employee>();
        }

        // METHODS

        public void AddEmployee(Employee newEmployee)
        {
            employees.Add(newEmployee);
        }
    }
}
