using System;
using System.Linq;
using System.Windows;
using PayrollModel;

namespace DataBindingDemo
{
    /// <summary>
    /// Interaction logic for SingleEmployee.xaml
    /// </summary>
    public partial class SingleEmployee : Window
    {
        private Employee employee;
        PayrollContext db;

        public SingleEmployee()
        {
            InitializeComponent();
            db = new PayrollContext();
        }

        private void cmdGetEmployee_Click(object sender, RoutedEventArgs e)
        {
            int ID;
            if (Int32.TryParse(txtID.Text, out ID))
            {
                try
                {
                    // query with LINQ
                    var query = from emp in db.Employees
                                where emp.EmployeeId == ID
                                select emp;

                    // same query using LINQ lambda expression
                    //var query = db.Employees.Where(emp => emp.EmployeeId == ID);

                    employee = query.First();

                    gridEmployeeDetails.DataContext = employee;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error contacting database." + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid ID.");
            }
        }

        private void cmdUpdateEmployee_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int rows = db.SaveChanges();
                MessageBox.Show(String.Format("{0} row(s) updated", rows.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error contacting database." + ex.Message);
            }

        }
    }
}
