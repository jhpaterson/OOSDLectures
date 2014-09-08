using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Data.Entity;
using PayrollModel;

namespace DataBindingDemo
{
    /// <summary>
    /// Interaction logic for EmployeesList.xaml
    /// </summary>
    public partial class EmployeesList : Window
    {

        private ICollection<Employee> employees;
        PayrollContext db;

        public EmployeesList()
        {
            InitializeComponent();
            db = new PayrollContext();
        }

        private void cmdGetEmployees_Click(object sender, RoutedEventArgs e)
        {
            // get entire collection of Employees 
            employees = db.Employees.ToList<Employee>();

            lstEmployees.ItemsSource = employees;
        }

    }
}

// suggestion - as an extension of this example, could filter by Department using something like the following,
// could get department name from drop-down box bound to collection of departments
// association mapping is set up to allow this to work
//var query = from d in db.Departments
//            where d.Name == "Research"
//            select d;
//Department dept = query.Include(d => d.Employees).Single();
//employees = dept.Employees;
