using System;
using System.Collections.Generic;

namespace PayrollModel
{
    /// <summary>
    /// represents a department
    /// </summary>
    public class Department
    {
        // INSTANCE VARIABLES

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Employee> employees;

        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        // CONSTRUCTOR

        /// <summary>
        /// constructor for department 
        /// </summary>
        public Department(string name)
        {
            this.name = name;
            employees = new List<Employee>();
        }

        /// <summary>
        /// default constructor for department 
        /// </summary>
        public Department()
        {
            this.name = "deafult";
            employees = new List<Employee>();
        }

        // METHODS

        public void AddEmployee(Employee newEmployee)
        {
            employees.Add(newEmployee);
        }
    }
}
