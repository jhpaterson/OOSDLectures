using System;


namespace CompositionDemo
{
    /// <summary>
    /// represents a salaried employee
    /// </summary>
    class SalariedEmployee : IEmployee
    {
        // CONSTANTS

        private const int maxGrade = 10;
   
        // INSTANCE VARIABLES

        private Employee employee;     // composition
        private int payGrade;

        // PROPERTIES

        /// <summary>
        /// the pay grade
        /// </summary>
        public int PayGrade
        {
          get { return payGrade; }
          set { payGrade = value; }
        }

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
        /// constructor for SalariedEmployee objects
        /// </summary>
        /// <param name="employeeId">the employee's id number</param>
        /// <param name="name">the employee's name</param>
        /// <param name="username">the employee's username</param>
        /// <param name="location">the employee's initila location</param>
        /// <param name="phoneNumber">the employee's phone number</param>
        /// <param name="phoneNumber">the employee's pay grade</param>
        public SalariedEmployee(int employeeId, string name, 
            string username, Location location, string phoneNumber, int payGrade) 
        {
            this.employee = new Employee(employeeId, name, username, location, phoneNumber);
            if (payGrade >= 0 && payGrade <= maxGrade)
            {
                this.payGrade = payGrade;
            }
        }

        /// <summary>
        /// constructor for SalariedEmployee objects
        /// </summary>
        /// <param name="employee">the employee</param>
        /// <param name="payGrade">the employee's pay grade</param>
        public SalariedEmployee(Employee employee, int payGrade)
        {
            this.employee = employee;
            if (payGrade >= 0 && payGrade <= maxGrade)
            {
                this.payGrade = payGrade;
            }
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public SalariedEmployee() 
        {
            this.employee = null;
            this.payGrade = 0;
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


        /// <summary>
        /// increment pay grade 
        /// </summary>
        public int PayIncrement()
        {
            if (this.payGrade < maxGrade)
            {
                this.payGrade++;
            }
            return this.payGrade;
        }

        /// <summary>
        /// the email address of the employee
        /// </summary>
        public string Email()
        {
            return employee.Username + "@example.com";
        }
    }
}
