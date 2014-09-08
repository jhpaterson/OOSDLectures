using System;

namespace StorageDemo
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
    public class Employee
    {
        //CONSTANTS

        private const string EMAIL_SUFFIX = "@example.com";

        //INSTANCE VARIABLES

        private int employeeId;
        private string name;
        private string username;
        private Location currentLocation;
        private string phoneNumber;

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

        /// <summary>
        /// the email address of the employee
        /// </summary>
        public string Email
        {
            get { return username + "@example.com"; }
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
        public void Move(Location newLocation)
        {
            currentLocation = newLocation;
        }
        // end Move

        /// <summary>
        /// records an overtime entry in a specified time sheet
        /// </summary>
        /// <param name="timeSheet">the time sheet</param>
        /// <param name="hours">the number of hours to record</param>
        /// <param name="payRate">payrate enumerated value</param>
        public void RecordOvertime(ITimeSheet timeSheet, int hours,
            PayRate payRate)
        {
            if (payRate == PayRate.Holiday)
            {
                timeSheet.AddEntry(employeeId, hours * 3);
            }
            else if (payRate == PayRate.Weekend)
            {
                timeSheet.AddEntry(employeeId, hours * 2);
            }
            else
            {
                timeSheet.AddEntry(employeeId, hours);
            }
        }
        // end RecordOvertime
    }
}
