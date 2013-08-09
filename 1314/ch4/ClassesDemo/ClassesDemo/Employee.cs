using System;

namespace ClassesDemo
{
    /// <summary>
    /// represents an employee 
    /// </summary>
    public class Employee
    {
        //CONSTANTS

        private const string EMAIL_SUFFIX = "@example.com";
 
        //INSTANCE VARIABLES

        private int employeeId;
        private String name;
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
        /// <param name="isWeekend">true if overtime worked at weekend - 
        /// weekend hours count as double time</param>
        public void RecordOvertime(TimeSheet timeSheet, int hours, 
            bool isWeekend)
        {
            // send message to time sheet object to ask it to 
            // record information
            if (isWeekend)
            {
                timeSheet.AddEntry(name, hours * 2);
            }
            else
            {
                timeSheet.AddEntry(name, hours);
            }
        }  
        // end RecordOvertime

        /// <summary>
        /// gets the total overtime recorded for this employee in the specified time sheet
        /// </summary>
        /// <param name="timeSheet">the time sheet</param>
        /// <returns>the total hours recorded</returns>
        public int TotalOvertime(TimeSheet timeSheet)
        {
            // get total overtime hours recorded in the specified timesheet
            // for this employee - we will fill in the details of this later,
            // just return an arbitrary value for now
            return 100;
        }

    }
}
