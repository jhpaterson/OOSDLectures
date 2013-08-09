using System;
using System.Collections.Generic;

namespace StorageDemo
{
    /// <summary>
    /// represents a department
    /// </summary>
    class Department
    {
        // INSTANCE VARIABLES

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Employee> employees;

        // CONSTRUCTOR

        /// <summary>
        /// constructor for department 
        /// </summary>
        public Department(string name)
        {
            this.name = name;
            employees = new List<Employee>();
        }

        // METHODS

        public void AddEmployee(Employee newEmployee)
        {
            employees.Add(newEmployee);
        }
    }
}
