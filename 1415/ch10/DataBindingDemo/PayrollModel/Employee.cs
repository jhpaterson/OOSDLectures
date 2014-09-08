using System;

namespace PayrollModel
{
    /// <summary>
    /// represents an employee 
    /// </summary>
    public class Employee
    {
        //INSTANCE VARIABLES

        private int employeeId;
        private string name;
        private string username;
        private string phoneNumber;

        //PROPERTIES

        /// <summary>
        /// the employee id number
        /// </summary>
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        /// <summary>
        /// the name of the employee
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// the username of the employee
        /// </summary>
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        /// <summary>
        /// the phone number of the employee
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }


        //CONSTRUCTORS

        /// <summary>
        /// constructor for Employee objects
        /// </summary>
        /// <param name="employeeId">the employee's id number</param>
        /// <param name="name">the employee's name</param>
        /// <param name="username">the employee's username</param>
        /// <param name="location">the employee's initila location</param>
        /// <param name="phoneNumber">the employee's phone number</param>
        public Employee(int employeeId, string name, string username,
            string phoneNumber)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.username = username;
            this.phoneNumber = phoneNumber;
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public Employee()
        {
            this.employeeId = -1;
            this.name = "default";
            this.username = "default";
            this.phoneNumber = "0000";
        }
  
    }
}
