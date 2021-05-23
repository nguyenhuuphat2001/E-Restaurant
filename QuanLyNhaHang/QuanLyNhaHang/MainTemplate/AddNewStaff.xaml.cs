using QuanLyNhaHang.DAO;
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

namespace QuanLyNhaHang
{
    /// <summary>
    /// Interaction logic for AddNewStaff.xaml
    /// </summary>
    public partial class AddNewStaff : Window
    {
        public AddNewStaff()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            string name = txtNameEmployee.Text;
            string UserName = txtUserNameEmployee.Text;
            string email = txtEmailEmployee.Text;
            string phone = txtPhoneEmployee.Text;
            string salary = txtSalaryEmployee.Text;
            int position = cmbPoition.SelectedIndex;
            int sex = Convert.ToInt32(rdoMale.IsChecked.Value);
            int idStaff;

            if(name==null||UserName==null||email==null||phone==null||salary==null||position==null||sex==null)
                MessageBox.Show("Please fill out the form first","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            //AddStaff

            //AddAcount
            idStaff = AccountDAO.Instance.GetIDStaffByPhone(phone);
            if (idStaff != null) {
                if (AccountDAO.Instance.InsertAccount(UserName,idStaff))
                {
                    MessageBox.Show("Create successful \n Default password: 123456");
                }
                else
                    MessageBox.Show("Create fail");
            }
            else
                MessageBox.Show("Create fail");
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
