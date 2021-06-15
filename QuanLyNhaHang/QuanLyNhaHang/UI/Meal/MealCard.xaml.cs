using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
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
using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using QuanLyNhaHang.MainTemplate;

namespace QuanLyNhaHang
{
    /// <summary>
    /// Interaction logic for MenuCard.xaml
    /// </summary>
    public partial class MealCard : UserControl
    {
        private string nameFood;

        public string NameFood
        {
            get { return nameFood; }
            set { nameFood = value; }
        }

        public MealCard()
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

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.Red;
        }

        private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.White;
        }

        public void SetText(string mealName, string mealCategory, float mealPrice, int orderQuantity)
        {
            this.mealName.Text = mealName;
            this.mealCategory.Text = mealCategory;
            this.mealPrice.Text = mealPrice.ToString();
            this.orderQuantity.Text = orderQuantity.ToString();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            nameFood = mealName.Text;
         
            EditMeal editmeal = new EditMeal();
            editmeal.txtNameMeal.Text = nameFood;
            editmeal.ShowDialog();
            
           
        }



        //private void deleteIcon_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        //{
        //    //Fix: get IDfood by name, idCategory first then delete 
        //    int id = 1;

        //    if (FoodDAO.Instance.DeleteMeal(id))
        //    {
        //        MessageBox.Show("Thành công");
        //        if (deleteMeal != null)
        //            deleteMeal(this, new EventArgs());
        //    }
        //    else
        //    {
        //        MessageBox.Show("Không thành công");
        //    }
        //}

        private event EventHandler deleteMeal;
        public event EventHandler DeleteMeal
        {
            add { DeleteMeal += value; }
            remove { DeleteMeal -= value; }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            string name = mealName.Text;
            if (FoodDAO.Instance.DeleteMeal(name))
            {
                MessageBox.Show("Thành công");
                if (deleteMeal != null)
                    deleteMeal(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Không thành công");
            }
        }
    }
}
