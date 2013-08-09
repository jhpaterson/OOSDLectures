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

namespace CustomException
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Account account;

        public MainWindow()
        {
            InitializeComponent();
            double screeHeight = SystemParameters.FullPrimaryScreenHeight;
            double screeWidth = SystemParameters.FullPrimaryScreenWidth;
            this.Top = (screeHeight - this.Height) / 2;
            this.Left = (screeWidth - this.Width) / 2;

            account = new Account(100.0m);

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                account.Withdraw(amount);
                txtAmount.Text = "0";
            }
            catch (OverdrawnException oex)
            {
                MessageBox.Show(String.Format(
                    "Can't withdraw: {0}", oex.Message));
            }
            catch (FormatException fex)
            {
                MessageBox.Show(String.Format(
                    "Can't withdraw: {0}", fex.Message));
            }
        }
    }
}
