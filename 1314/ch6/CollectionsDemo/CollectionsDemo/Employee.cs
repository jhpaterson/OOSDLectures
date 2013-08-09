using System;

namespace CollectionsDemo
{
    /// <summary>
    /// enumeration of possible pay rates
    /// </summary>
    public enum PayRate
    {
        Day,
        Weekend,
        Holiday
    }
    
    /// <summary>
    /// represents an employee 
    /// </summary>
    public class Employee : IEquatable<Employee>
    {
        //CONSTANTS
        protected const string EMAIL_SUFFIX = "@example.com";

        //INSTANCE VARIABLES
        protected int employeeId;
        protected string name;
        protected string username;
        protected Location currentLocation;
        protected string phoneNumber;

        //PROPERTIES

        /// <summary>
        /// the employee id number
        /// </summary>
        public int EmployeeId
        {
            get { return employeeId; }
        }

        /// <summary>
        /// the name of the employee
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// the username of the employee
        /// </summary>
        public string Username
        {
            get { return username; }
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
            Location location, string phoneNumber)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.username = username;
            this.currentLocation = location;
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
            this.currentLocation = null;
            this.phoneNumber = "0000";
        }

        //METHODS

        /// <summary>
        /// Move to a new location
        /// </summary>
        /// <param name="newLocation">the new location</param>
        public virtual void Move(Location newLocation)
        {
            currentLocation = newLocation;
        }


        /// <summary>
        /// the email address of the employee
        /// </summary>
        public virtual string Email()
        {
            return username + "@example.com"; 
        }

        /// <summary>
        /// required to implement IEquatable
        /// </summary>
        /// <param name="obj">the object to test</param>
        /// <returns></returns>
        public bool Equals(Employee emp)
        {
            if (emp != null)
            {
                return this.EmployeeId == emp.EmployeeId;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// overrides Equals method in Object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null) return base.Equals(obj);

            if (!(obj is Employee))
                throw new InvalidCastException("The 'obj' argument is not an Employee object.");
            else
                return Equals(obj as Employee);
        }

        /// <summary>
        /// overrides GetHashCode method in Object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            // Which is preferred?

            return base.GetHashCode();

            //return this.FooId.GetHashCode();
        }



    }
}
