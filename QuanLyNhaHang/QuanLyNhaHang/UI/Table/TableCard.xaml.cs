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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyNhaHang
{
    /// <summary>
    /// Interaction logic for TableCard.xaml
    /// </summary>
    public partial class TableCard : UserControl
    {
        public TableCard()
        {
            InitializeComponent();
        }

        private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.Red;
        }

        private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.White;
        }

        private void addButton_MouseEnter(object sender, MouseEventArgs e)
        {
            addIcon.Foreground = Brushes.Green;
        }

        private void addButton_MouseLeave(object sender, MouseEventArgs e)
        {
            addIcon.Foreground = Brushes.White;
        }

        public void SetText(int name, string status)
        {
            tbkName.Text = name.ToString();
            tbkStatus.Text = status;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { DeleteTable += value; }
    remove { DeleteTable -= value; }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(tbkName.Text);
            if (TableDAO.Instance.DeleteTable(id))
            {
                MessageBox.Show("Thành công");
                if (deleteTable != null)
                    deleteTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Không thành công");
            }
        }

    }
}


