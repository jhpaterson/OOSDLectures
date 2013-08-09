using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace ObjectBindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee emp;

        public MainWindow()
        {
            InitializeComponent();

            emp = new Employee { Name = "default name", Address = "default address" };
            emp.PropertyChanged += EmployeePropertyChanged;      // capture event just to show when property changes
            DataContext = emp;
        }

        public void EmployeePropertyChanged(Object sender, PropertyChangedEventArgs args)
        {
            MessageBox.Show("Detected property change: "  + args.PropertyName);
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Name - " + emp.Name + ",  Address - " + emp.Address, "Current object state");
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            emp.Name = "default name";
            emp.Address = "default address";
        }
    }
}
