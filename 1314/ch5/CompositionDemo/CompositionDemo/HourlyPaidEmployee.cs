using System;


namespace CompositionDemo
{
    /// <summary>
    /// represents an hourly paid employee
    /// </summary>
    public class HourlyPaidEmployee : IEmployee
    {
        // INSTANCE VARIABLES

        private Employee employee;     // composition

        // PROPERTIES

        /// <summary>
        /// the employee id number
        /// </summary>
        public int EmployeeId
        {
            get { return employee.EmployeeId; }
        }

        /// <summary>
        /// the name of the employee
        /// </summary>
        public string Name
        {
            get { return employee.Name; }
        }

        /// <summary>
        /// the username of the employee
        /// </summary>
        public string Username
        {
            get { return employee.Username; }
        }

        /// <summary>
        /// the phone number of the employee
        /// </summary>
        public string PhoneNumber
        {
            get { return employee.PhoneNumber; }
            set { employee.PhoneNumber = value; }
        }
        //CONSTRUCTORS

        /// <summary>
        /// constructor for HourlyPaidEmployee objects
        /// </summary>
        /// <param name="employeeId">the employee's id number</param>
        /// <param name="name">the employee's name</param>
        /// <param name="username">the employee's username</param>
        /// <param name="location">the employee's initila location</param>
        /// <param name="phoneNumber">the employee's phone number</param>
        public HourlyPaidEmployee(int employeeId, string name, 
            string username, Location location, string phoneNumber) 
        {
            this.employee = new Employee(employeeId, name, username, location, phoneNumber); 
        }

        /// <summary>
        /// constructor for SalariedEmployee objects
        /// </summary>
        /// <param name="employee">the employee</param>
        public HourlyPaidEmployee(Employee employee)
        {
            this.employee = employee;
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public HourlyPaidEmployee() 
        {
            this.employee = null;
        }

        // METHODS

        /// <summary>
        /// Move to a new location
        /// </summary>
        /// <param name="newLocation">the new location</param>
        public void Move(Location newLocation)
        {
            employee.Move(newLocation);
        }
        // end Move

        /// <summary>
        /// the email address of the employee
        /// </summary>
        public string Email()
        {
            return  employee.Username + "_h_" + "@example.com";
        }

        /// <summary>
        /// records an entry in a specified time sheet
        /// </summary>
        /// <param name="timeSheet">the time sheet</param>
        /// <param name="hours">the number of hours to record</param>
        /// <param name="payRate">payrate enumerated value</param>
        public void RecordTime(ITimeSheet timeSheet, int hours,
            PayRate payRate)
        {
            if (payRate == PayRate.Holiday)
            {
                timeSheet.AddEntry(employee.Name, hours * 3);
            }
            else if (payRate == PayRate.Weekend)
            {
                timeSheet.AddEntry(employee.Name, hours * 2);
            }
            else
            {
                timeSheet.AddEntry(employee.Name, hours);
            }
        }
        // end RecordTime
    }
}
