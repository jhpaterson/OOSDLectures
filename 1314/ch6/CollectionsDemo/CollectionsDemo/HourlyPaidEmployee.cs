using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsDemo
{
    /// <summary>
    /// represents an hourly paid employee
    /// </summary>
    public sealed class HourlyPaidEmployee : Employee
    { 
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
            string username, Location location, string phoneNumber) : 
            base(employeeId, name, username,location, phoneNumber)
        {
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public HourlyPaidEmployee() : base()
        {
        }

        // METHODS

        /// <summary>
        /// the email address of the employee
        /// </summary>
        public override string Email()
        {
            return  username + "_h_" + "@example.com";
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
                timeSheet.AddEntry(name, hours * 3);
            }
            else if (payRate == PayRate.Weekend)
            {
                timeSheet.AddEntry(name, hours * 2);
            }
            else
            {
                timeSheet.AddEntry(name, hours);
            }
        }
    }
}
