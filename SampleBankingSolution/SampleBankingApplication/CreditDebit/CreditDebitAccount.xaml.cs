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
using System.Windows.Shapes;

namespace MagKnowledge.Git.CreditDebit
{
    /// <summary>
    /// Interaction logic for CreditDebitAccount.xaml
    /// </summary>
    public partial class CreditDebitAccount : Window
    {
        public CreditDebitAccount()
        {
            InitializeComponent();
        }
        static int accountId = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = CreditDebitOperations.ValidateUser(txtUserName.Text, txtPassword.Password, cmbAccountType.Text == "Saving" ? false : true);
            if (x > 0)
            {
                accountId = x;
                MessageBox.Show("yr balance : " + x.ToString());
            }
            else
            {
                MessageBox.Show("Invalid");

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool response = CreditDebitOperations.CreditDebitAmount(accountId, true, txtBalance.Text);
            if (response)
            {
                MessageBox.Show("credited");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            bool response = CreditDebitOperations.CreditDebitAmount(accountId, false, txtBalance.Text);
            if (response)
            {
                MessageBox.Show("debited");
            }
        }


    }
}
