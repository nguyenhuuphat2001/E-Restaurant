using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using QuanLyNhaHang.UI.Meal;
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
    /// Interaction logic for TableManagement.xaml
    /// </summary>
    public partial class TableManagement : Window
    {
        public TableManagement()
        {
            InitializeComponent();
            Load();
        }

        #region method
        private void Load()
        {
            LoadTable();
            LoadCategory();
            LoadFoodList();
        }
        private void LoadTable()
        {
            TableDAO.Instance.SetTableStatus();
            wpTable.Children.Clear();
            List<TableDTO> tableList = TableDAO.Instance.LoadTableList();
            for (int i = 0; i < tableList.Count; i++)
            {
                TableDAO.Instance.SetTableStatus();
            }

            foreach (TableDTO item in tableList)
            {
                Table btn = new Table();
                btn.SetTest(item.Name, item.Status);
                btn.Tag = item;

                btn.SetBackGround(item.Status);

                btn.Click += BtnTable_Click;
                wpTable.Children.Add(btn);
            }
        }
        private void LoadFoodList()
        {
            wpFood.Children.Clear();

            List<FoodDTO> foodList = FoodDAO.Instance.GetListFood();
            foreach (FoodDTO food in foodList)
            {
                MealButton foodBTN = new MealButton();
                foodBTN.SetName(food.Name);
                wpFood.Children.Add(foodBTN);
            }

        }
        void LoadCategory()
        {
            List<CategoryDTO> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.ItemsSource = listCategory;
            cbCategory.DisplayMemberPath = "Name";
        }
        private void LoadFoodListByCategory(int id)
        {
            wpFood.Children.Clear();

            List<FoodDTO> listFoodByCategory = FoodDAO.Instance.GetFoodByCategoryID(id);

            foreach (FoodDTO food in listFoodByCategory)
            {
                MealButton foodBTN = new MealButton();
                foodBTN.SetName(food.Name);
                wpFood.Children.Add(foodBTN);
            }
        }
        #endregion

        #region event
        private void BtnTable_Click(object sender, RoutedEventArgs e)
        {
            int tableID = ((sender as Button).Tag as TableDTO).ID;
            //lvBill.Tag = (sender as Button).Tag;
            //ShowBill(tableID);
        }
        private void exportBillBtn_Click(object sender, RoutedEventArgs e)
        {
            BillTemplate bill = new BillTemplate();
            bill.Show();
        }
        private void cbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            CategoryDTO selected = cb.SelectedItem as CategoryDTO;

            id = selected.Id;

            LoadFoodListByCategory(id);

        }
        private void cbFood_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion



    }
}
