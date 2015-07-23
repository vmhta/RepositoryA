using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleBankingApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MagKnowledge.Git.BalanceDetails.BalanceWindow win = new MagKnowledge.Git.BalanceDetails.BalanceWindow();
            win.Show();
        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MagKnowledge.Git.AccountDetails.AccountWindow win = new MagKnowledge.Git.AccountDetails.AccountWindow();
            win.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MagKnowledge.Git.CreditDebit.CreditDebitAccount win = new MagKnowledge.Git.CreditDebit.CreditDebitAccount();
            win.Show();
        }
    }
}
