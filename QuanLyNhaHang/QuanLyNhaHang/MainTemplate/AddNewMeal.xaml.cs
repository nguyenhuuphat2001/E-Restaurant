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
using Microsoft.Win32;
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
            string category = cmbCategory.Text;
            //int categoryID = CategoryDAO.Instance.GetIDCategoryByName(category);
            float price = float.Parse(txtPriceMeal.Text);
            int categoryID = 1 ;
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
          

            if (FoodDAO.Instance.AddMeal(name,categoryID, price))
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

        private void ChooseImageButton_Click(object sender, RoutedEventArgs e)
        {
            string link="";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            openFileDialog.ShowDialog();
            bool? diaglogOK = openFileDialog.ShowDialog();
            if (diaglogOK == true)
            {
                link = openFileDialog.FileName;

                Image.Source = new BitmapImage(new Uri(link));
                Imageicon.Visibility = Visibility.Hidden;

                
            }   

        }
    }
}
