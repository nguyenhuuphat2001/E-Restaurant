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
using LiveCharts;
using LiveCharts.Wpf;
using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using QuanLyNhaHang.MainTemplate;

namespace QuanLyNhaHang
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
            SetReportPage();
        }

        #region Method
        #region Reset
        private void ResetReportManager()
        {
            GridAssistant.Children.Clear();
        }

        private void ResetManagerFieldHolder()
        {
            ManagerFieldHolder.Children.Clear();
        }

        private void ModifyCategory_Modify(object sender, EventArgs e)
        {
            SetCategoryPage();
        }
        #endregion

        #region Set
        private void SetGridAssistantToDefault()
        {
            ResetReportManager();
        }
        private void SetGridPrincipalToDefault()
        {
            ResetManagerFieldHolder();
        }
        private void SetGridPrincipal()
        {
            DisableGridAssistant();
            EnableGridPrincipal();
        }
        private void SetGridAssistant()
        {
            DisableGridPrincipal();
            EnableGridAssistant();
        }
        private void SetReportPage()
        {
            SetGridAssistantToDefault();
            SetGridAssistant();
            IncludeReportManager();

        }
        private void SetStaffPage()
        {
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeStaffManagerTable();
            IncludeStaffList();
        }
        private void SetMealPage()
        {
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeMealManagerTable();
            IncludeFoodList();
        }
        private void SetCategoryPage()
        {
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeCategoryTable();
            IncludeCategoryList();
        }
        private void SetTableManagerPage()
        {
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeTableManager();
            IncludeTableList();
        }
        private void SetAccountManagerPage()
        {
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeAccountManager();
            IncludeAccountList();
        }
        #endregion

        #region Include
        #region Report
        private void IncludeReportManager()
        {
            GridAssistant.Children.Add(new ReportManager());
        }
        #endregion

        #region Category
        private void IncludeCategoryList()
        {
            ListHolder.Children.Clear();
            List<CategoryDTO> categoryList = CategoryDAO.Instance.GetListCategory();
            foreach (CategoryDTO category in categoryList)
            {
                CategoryCard categoryCard = new CategoryCard();
                categoryCard.SetText(category.Id, category.Name);
                ListHolder.Children.Add(categoryCard);
            }
        }
        private void IncludeCategoryListByName(string name)
        {
            ListHolder.Children.Clear();
            List<CategoryDTO> categoryList = CategoryDAO.Instance.GetListCategoryByName(name);

            foreach (CategoryDTO category in categoryList)
            {
                CategoryCard categoryCard = new CategoryCard();
                categoryCard.SetText(category.Id, category.Name);
                ListHolder.Children.Add(categoryCard);
            }
        }
        private void IncludeCategoryListAscending(string name)
        {
            ListHolder.Children.Clear();
            List<CategoryDTO> categoryList = CategoryDAO.Instance.GetListCategoryByNameAscending(name);

            foreach (CategoryDTO category in categoryList)
            {
                CategoryCard categoryCard = new CategoryCard();
                categoryCard.SetText(category.Id, category.Name);
                ListHolder.Children.Add(categoryCard);
            }
        }
        private void IncludeCategoryListDescending(string name)
        {
            ListHolder.Children.Clear();
            List<CategoryDTO> categoryList = CategoryDAO.Instance.GetListCategoryByNameDescending(name);

            foreach (CategoryDTO category in categoryList)
            {
                CategoryCard categoryCard = new CategoryCard();
                categoryCard.SetText(category.Id, category.Name);
                ListHolder.Children.Add(categoryCard);
            }
        }
        private void IncludeCategoryTable()
        {
            ManagerFieldHolder.Children.Add(new CategoryManager(CategoryNameSort));
        }
        #endregion

        #region Staff
        private void IncludeStaffManagerTable()
        {
            ManagerFieldHolder.Children.Add(new StaffManager());
        }
        private void IncludeStaffList()
        {
            ///<summary>
            /// This function load staff list from SQL
            ///</summary>

        }
        #endregion

        #region Meal
        private void IncludeMealManagerTable()
        {
            ManagerFieldHolder.Children.Add(new MealManager());
        }
        private void IncludeFoodList()
        {
            ListHolder.Children.Clear();
            List<FoodDTO> foodList = FoodDAO.Instance.GetListFood();
            foreach (FoodDTO food in foodList)
            {
                string category = CategoryDAO.Instance.GetCategoryByID(food.CategoryID);
                int quantity = FoodDAO.Instance.GetOrderQuantityByID(food.Id);

                MealCard meal = new MealCard();
                meal.SetText(food.Name, category, food.Price, quantity);
                ListHolder.Children.Add(meal);
            }
        }
        #endregion

        #region Account
        private void IncludeAccountManager()
        {
            ManagerFieldHolder.Children.Add(new AccountManager(Account_UserNameSort,Account_OwnerSort,Account_PositionSort));
        }
        private void IncludeAccountList()
        {
            ListHolder.Children.Clear();
            List<AccountDTO> accountList = AccountDAO.Instance.GetListAccount();

            foreach (AccountDTO item in accountList)
            {
                /// <example>
                /// StaffDTO staff= StaffDAO().Instance.GetInfoAccount(item.IDStaff);
                /// AccountCard acc = new AccountCard();
                /// acc.SetText(item.UserName, staff.Name, staff.Position);
                /// </example>

                AccountCard acc = new AccountCard();
                acc.SetText(item.UserName, "me", 0);
                ListHolder.Children.Add(acc);
            }
        }

        private void IncludeAccountListByUserName(string username)
        {
            ListHolder.Children.Clear();
            List<AccountDTO> accountList = AccountDAO.Instance.GetListAccountByUserName(username);

            foreach (AccountDTO item in accountList)
            {
                /// <example>
                /// StaffDTO staff= StaffDAO().Instance.GetInfoAccount(item.IDStaff);
                /// AccountCard acc = new AccountCard();
                /// acc.SetText(item.UserName, staff.Name, staff.Position);
                /// </example>

                AccountCard acc = new AccountCard();
                acc.SetText(item.UserName, "me", 0);
                ListHolder.Children.Add(acc);
            }
        }
        private void IncludeAccount_PositionListAscending(string text)
        {
            ListHolder.Children.Clear();
            List<AccountDTO> accounts = AccountDAO.Instance.GetAccount_PositionListAscending(text);
            foreach (AccountDTO item in accounts)
            {
                /// <example>
                /// StaffDTO staff= StaffDAO().Instance.GetInfoAccount(item.IDStaff);
                /// AccountCard acc = new AccountCard();
                /// acc.SetText(item.UserName, staff.Name, staff.Position);
                /// </example>

                AccountCard acc = new AccountCard();
                acc.SetText(item.UserName, "me", 0);
                ListHolder.Children.Add(acc);
            }
        }
        private void IncludeAccount_PositionListDescending(string text)
        {
            ListHolder.Children.Clear();
            List<AccountDTO> accounts = AccountDAO.Instance.GetAccount_PositionListDescending(text);
            foreach (AccountDTO item in accounts)
            {
                /// <example>
                /// StaffDTO staff= StaffDAO().Instance.GetInfoAccount(item.IDStaff);
                /// AccountCard acc = new AccountCard();
                /// acc.SetText(item.UserName, staff.Name, staff.Position);
                /// </example>

                AccountCard acc = new AccountCard();
                acc.SetText(item.UserName, "me", 0);
                ListHolder.Children.Add(acc);
            }
        }
        private void IncludeAccount_UsernameListAscending(string text)
        {
            ListHolder.Children.Clear();
            List<AccountDTO> accounts = AccountDAO.Instance.GetAccount_UsernameListAscending(text);
            foreach (AccountDTO item in accounts)
            {
                /// <example>
                /// StaffDTO staff= StaffDAO().Instance.GetInfoAccount(item.IDStaff);
                /// AccountCard acc = new AccountCard();
                /// acc.SetText(item.UserName, staff.Name, staff.Position);
                /// </example>

                AccountCard acc = new AccountCard();
                acc.SetText(item.UserName, "me", 0);
                ListHolder.Children.Add(acc);
            }
        }
        private void IncludeAccount_UsernameListDescending(string text)
        {
            ListHolder.Children.Clear();
            List<AccountDTO> accounts = AccountDAO.Instance.GetAccount_UsernameListDescending(text);
            foreach (AccountDTO item in accounts)
            {
                /// <example>
                /// StaffDTO staff= StaffDAO().Instance.GetInfoAccount(item.IDStaff);
                /// AccountCard acc = new AccountCard();
                /// acc.SetText(item.UserName, staff.Name, staff.Position);
                /// </example>

                AccountCard acc = new AccountCard();
                acc.SetText(item.UserName, "me", 0);
                ListHolder.Children.Add(acc);
            }
        }
        private void IncludeAccount_OwnerListAscending(string text)
        {
            ListHolder.Children.Clear();
            List<AccountDTO> accounts = AccountDAO.Instance.GetAccount_OwnerListAscending(text);
            foreach (AccountDTO item in accounts)
            {
                /// <example>
                /// StaffDTO staff= StaffDAO().Instance.GetInfoAccount(item.IDStaff);
                /// AccountCard acc = new AccountCard();
                /// acc.SetText(item.UserName, staff.Name, staff.Position);
                /// </example>

                AccountCard acc = new AccountCard();
                acc.SetText(item.UserName, "me", 0);
                ListHolder.Children.Add(acc);
            }
        }
        private void IncludeAccount_OwnerListDescending(string text)
        {
            ListHolder.Children.Clear();
            List<AccountDTO> accounts = AccountDAO.Instance.GetAccount_OwnerListDescending(text);
            foreach (AccountDTO item in accounts)
            {
                /// <example>
                /// StaffDTO staff= StaffDAO().Instance.GetInfoAccount(item.IDStaff);
                /// AccountCard acc = new AccountCard();
                /// acc.SetText(item.UserName, staff.Name, staff.Position);
                /// </example>

                AccountCard acc = new AccountCard();
                acc.SetText(item.UserName, "me", 0);
                ListHolder.Children.Add(acc);
            }
        }
        #endregion

        #region Table
        private void IncludeTableListAscending()
        {
            ListHolder.Children.Clear();
            List<TableDTO> tables = TableDAO.Instance.GetTableListAscending();
            foreach (TableDTO table in tables)
            {
                TableCard tableCard = new TableCard();
                tableCard.SetText(table.ID, table.Status);
                ListHolder.Children.Add(tableCard);
            }
        }
        private void IncludeTableListDescending()
        {
            ListHolder.Children.Clear();
            List<TableDTO> tables = TableDAO.Instance.GetTableListDescending();
            foreach (TableDTO table in tables)
            {
                TableCard tableCard = new TableCard();
                tableCard.SetText(table.ID, table.Status);
                ListHolder.Children.Add(tableCard);
            }
        }
        private void IncludeTableManager()
        {
            ManagerFieldHolder.Children.Add(new TableManager(TableSort));
        }
        private void IncludeTableList()
        {
            ListHolder.Children.Clear();
            List<TableDTO> tableList = TableDAO.Instance.GetTableList();
            foreach (TableDTO table in tableList)
            {
                TableCard tableCard = new TableCard();
                tableCard.SetText(table.ID, table.Status);
                ListHolder.Children.Add(tableCard);
            }
        }
        #endregion
        #endregion

        #region Sort
        private void TableSort(object sender, RoutedEventArgs eventArgs)
        {
            if (tableButtonClickCount % 2 == 0)
            {
                IncludeTableListDescending();
            }
            else
            {
                IncludeTableListAscending();
            }
            tableButtonClickCount++;
        }
        private void CategoryNameSort(object sender, RoutedEventArgs e)
        {
            //categoryButtonClickCount % 2 == 0 : sort descending
            //caegoryButtonClickCount % 2 != 0 : sort ascending
            if (categoryButtonClickCount % 2 == 0)
            {

                IncludeCategoryListDescending(searchTxb.Text);
            }
            else
            {
                IncludeCategoryListAscending(searchTxb.Text);
            }

            categoryButtonClickCount++;
        }

        #region Account
        private void Account_UserNameSort(object sender, RoutedEventArgs e)
        {
            //Account_UsernameButtonClickCount % 2 == 0 : sort descending
            //Account_UsernameButtonClickCount % 2 != 0 : sort ascending
            if (Account_UsernameButtonClickCount % 2 == 0)
            {
                IncludeAccount_UsernameListDescending(searchTxb.Text);
            }
            else
            {
                IncludeAccount_UsernameListAscending(searchTxb.Text);
            }

            Account_UsernameButtonClickCount++;
        }
        private void Account_OwnerSort(object sender, RoutedEventArgs e)
        {
            //Account_OwnerButtonClickCount % 2 == 0 : sort descending
            //Account_OwnerButtonClickCount % 2 != 0 : sort ascending
            if (Account_OwnerButtonClickCount % 2 == 0)
            {
                IncludeAccount_OwnerListDescending(searchTxb.Text);
            }
            else
            {
                IncludeAccount_OwnerListAscending(searchTxb.Text);
            }

            Account_OwnerButtonClickCount++;
        }
        private void Account_PositionSort(object sender, RoutedEventArgs e)
        {
            //Account_PositionButtonClickCount % 2 == 0 : sort descending
            //Account_PositionButtonClickCount % 2 != 0 : sort ascending
            if (Account_PositionButtonClickCount % 2 == 0)
            {

                IncludeAccount_PositionListDescending(searchTxb.Text);
            }
            else
            {
                IncludeAccount_PositionListAscending(searchTxb.Text);
            }

            Account_PositionButtonClickCount++;
        }
        #endregion
        #endregion

        private void DisableGridPrincipal()
        {
            GridPrincipal.Visibility = Visibility.Collapsed;
        }
        private void EnableGridPrincipal()
        {
            GridPrincipal.Visibility = Visibility.Visible;
        }
        private void DisableGridAssistant()
        {
            GridAssistant.Visibility = Visibility.Collapsed;

        }
        private void EnableGridAssistant()
        {
            GridAssistant.Visibility = Visibility.Visible;

        }

        private void MoveCursorMenu(int index)
        {
            //TrainsitioningContentSlide.OnApplyTemplate();
            //GridCursor.Margin = new Thickness(0, (150+(60 * index)), 0, 0);
        }
        #endregion

        #region Event
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);
            switch (index)
            {
                case 0:
                    SetReportPage();
                    break;
                case 1:
                    SetStaffPage();
                    break;
                case 2:
                    SetMealPage();
                    break;
                case 3:
                    SetCategoryPage();
                    break;
                case 4:
                    SetTableManagerPage();
                    break;
                case 5:
                    SetAccountManagerPage();
                    break;
            }
        }
        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            if (!String.IsNullOrWhiteSpace(searchTxb.Text))
            {
                switch (index)
                {
                    case 3:
                        IncludeCategoryListByName(searchTxb.Text);
                        break;
                    case 5:
                        IncludeAccountListByUserName(searchTxb.Text);
                        break;
                }
            }
            else
            {
                switch (index)
                {
                    case 1:
                        SetStaffPage();
                        break;
                    case 2:
                        SetMealPage();
                        break;
                    case 3:
                        SetCategoryPage();
                        break;
                    case 4:
                        SetTableManagerPage();
                        break;
                    case 5:
                        SetAccountManagerPage();
                        break;
                }
            }
        }
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            switch (index)
            {
                case 1:
                    AddNewStaff addNewStaff = new AddNewStaff();
                    addNewStaff.ShowDialog();
                    break;
                case 2:
                    AddNewMeal addNewMeal = new AddNewMeal();
                    addNewMeal.ShowDialog();
                    break;
                case 3:
                    ModifyCategory modifyCategory = new ModifyCategory("Add", -1);
                    modifyCategory.Modify += ModifyCategory_Modify;
                    modifyCategory.ShowDialog();
                    break;
                case 4:
                    AddNewTable addNewTable = new AddNewTable();
                    addNewTable.ShowDialog();
                    break;
            }
        }
        #endregion

        #region Field
        public Func<ChartPoint, string> PointLabel { get; set; }

        private int categoryButtonClickCount = 0;

        private int tableButtonClickCount = 0;

        private int Account_UsernameButtonClickCount = 0;

        private int Account_OwnerButtonClickCount = 0;

        private int Account_PositionButtonClickCount = 0;

        #endregion


    }
}