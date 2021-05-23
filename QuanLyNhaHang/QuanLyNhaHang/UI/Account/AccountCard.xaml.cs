using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace QuanLyNhaHang
{
    /// <summary>
    /// Interaction logic for AccountCard.xaml
    /// </summary>
    public partial class AccountCard : UserControl
    {
        public AccountCard()
        {
            InitializeComponent();
        }

        private void addButton_MouseEnter(object sender, MouseEventArgs e)
        {
            addIcon.Foreground = Brushes.Green;
        }

        private void addButton_MouseLeave(object sender, MouseEventArgs e)
        {
            addIcon.Foreground = Brushes.White;
        }

        private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.Red;
        }

        private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.White;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Delete account will delete staff. Do you want to countinue?", "Warning", MessageBoxButton.OKCancel,MessageBoxImage.Warning) != MessageBoxResult.OK)
            {
                return;
            }
            string username = txbUserName.Text;
            int idStaff = AccountDAO.Instance.GetIDStaffByUserName(username);
            //delete staff

            //delete account
            if (AccountDAO.Instance.DeleteAccount(username))
            {
                MessageBox.Show("Delete account successful");
            }
            else
                MessageBox.Show("Delete account fail");
        }

        public void SetText(string userName, string name, int position)
        {
            txbUserName.Text = userName;
            txbName.Text = name;            
            switch (position)
            {
                case 0:
                    txbWorkingPosition.Text = "Manager";
                    break;
                case 1:
                    txbWorkingPosition.Text = "Waiter";
                    break;
                case 2:
                    txbWorkingPosition.Text = "Staff";
                    break;
            }
        }
    }
}
