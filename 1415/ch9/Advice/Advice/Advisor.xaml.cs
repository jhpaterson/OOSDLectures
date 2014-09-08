using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Input;

namespace Advice
{
    /// <summary>
    /// Interaction logic for Advice.xaml
    /// </summary>

    public partial class Advisor : Window
    {

        public Advisor()
        {
            InitializeComponent();
        }

        private void cmdAnswer_Click(object sender, RoutedEventArgs e)
        {
            AdviceGenerator generator = new AdviceGenerator();
            txtAnswer.Text = generator.GetRandomAnswer(txtQuestion.Text);
        }
    }
}