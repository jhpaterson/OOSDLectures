using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositionDemo
{
    /// <summary>
    /// interface for any kind of employee
    /// </summary>
    interface IEmployee
    {
        // PROPERTIES

        /// <summary>
        /// the employee id number
        /// </summary>
        int EmployeeId
        {
            get;
        }

        /// <summary>
        /// the name of the employee
        /// </summary>
        string Name
        {
            get;
        }

        /// <summary>
        /// the username of the employee
        /// </summary>
        string Username
        {
            get;
        }

        /// <summary>
        /// the phone number of the employee
        /// </summary>
        string PhoneNumber
        {
            get;
            set;
        }

        // METHODS

        /// <summary>
        /// Move to a new location
        /// </summary>
        /// <param name="newLocation">the new location</param>
        void Move(Location newLocation);

        /// <summary>
        /// the email address of the employee
        /// </summary>
        string Email();
    }
}
