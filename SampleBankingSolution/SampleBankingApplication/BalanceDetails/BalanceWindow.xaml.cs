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

namespace MagKnowledge.Git.BalanceDetails
{
    /// <summary>
    /// Interaction logic for BalanceWindow.xaml
    /// </summary>
    public partial class BalanceWindow : Window
    {
        public BalanceWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          double x =   BalanceOperations.CheckBalance(txtUserName.Text, txtPassword.Password, cmbAccountType.Text == "Saving" ? false : true);
          MessageBox.Show("yr balance : " + x.ToString());
        }

       
    }
}
