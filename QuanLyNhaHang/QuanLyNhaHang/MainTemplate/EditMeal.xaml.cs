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
    /// Interaction logic for EditMeal.xaml
    /// </summary>
    public partial class EditMeal : Window
    {
        public EditMeal()
        {
            InitializeComponent();
            LoadCategory();
        }
        private event EventHandler editMeal;
        public event EventHandler editmeal
        {
            add { editMeal += value; }
            remove { editMeal -= value; }
        }
        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {

            
         

            string name = txtNameMeal.Text;
            int categoryID = 2;
            string category = cmbCategory.Text;
            float price = float.Parse(txtPriceMeal.Text);
            switch (category)
            {
                case "Hải sản":
                    categoryID = 1;
                    break;
                case "Lâm sản":
                    categoryID = 3;
                    break;
                case "Nông sản":
                    categoryID = 2;
                    break;
                case "Nước":
                    categoryID = 4;
                    break;
                default:
                    break;
            }


            if (FoodDAO.Instance.EditMeal(name, categoryID, price))
            {
                MessageBox.Show("Thành công");
                if (editMeal != null)
                    editMeal(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Không thành công");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        void LoadCategory()
        {
            List<CategoryDTO> listCategory = CategoryDAO.Instance.GetListCategory();
            cmbCategory.ItemsSource = listCategory;
            cmbCategory.DisplayMemberPath = "Name";
        }
    }
}
