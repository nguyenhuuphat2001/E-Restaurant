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

namespace QuanLyNhaHang
{
    /// <summary>
    /// Interaction logic for AddNewMeal.xaml
    /// </summary>
    public partial class AddNewMeal : Window
    {
        public AddNewMeal()
        {
            InitializeComponent();
            LoadCategory();
        }



        #region events
        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            string name = txtNameMeal.Text;
            string category = cmbCategory.SelectedItem.ToString();
            int categoryID = CategoryDAO.Instance.GetIDCategoryByName(category);
            float price = float.Parse(txtPriceMeal.Text);

            if (FoodDAO.Instance.AddMeal(name, categoryID, price))
            {
                MessageBox.Show("Thành công");
                if (addMeal != null)
                    addMeal(this, new EventArgs());
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





        private event EventHandler addMeal;
        public event EventHandler AddMeal
        {
            add { addMeal += value; }
            remove { addMeal -= value; }
        }





        #endregion

        #region Method
        void LoadCategory()
        {
            List<CategoryDTO> listCategory = CategoryDAO.Instance.GetListCategory();
            cmbCategory.ItemsSource = listCategory;
            cmbCategory.DisplayMemberPath = "Name";
        }
        #endregion


    }
}
