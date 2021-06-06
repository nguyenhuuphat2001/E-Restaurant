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
using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;

namespace QuanLyNhaHang.MainTemplate
{
    /// <summary>
    /// Interaction logic for EditTable.xaml
    /// </summary>
    public partial class EditTable : Window
    {

        public string tableName = "";
        public bool ableToChange = false;
        public EditTable()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTable.Text))
            {
                MessageBox.Show("Category name must not be empty");
            }
            else
            {
                ableToChange = true;
                tableName = txtTable.Text;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
