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
        }

        #region Method
        #region Reset
        private void ResetTotalProfitCardContainer()
        {
            TotalProfitCardContainer.Children.Clear();
        }
        private void ResetCompareWithLastMonthCardContainer()
        {
            CompareWithLastMonthCardContainer.Children.Clear();
        }
        private void ResetUserRatingCardContainer()
        {
            UserRatingCardContainer.Children.Clear();
        }
        private void ResetPieChartContainer()
        {
            PieChartContainer.Children.Clear();
        }
        private void ResetCartesianChartContainer()
        {
            CartesianChartContainer.Children.Clear();
        }
        private void ResetManagerFieldHolder()
        {
            ManagerFieldHolder.Children.Clear();
        }
        #endregion

        #region Set
        private void SetGridAssistantToDefault()
        {
            ResetTotalProfitCardContainer();
            ResetCompareWithLastMonthCardContainer();
            ResetUserRatingCardContainer();
            ResetPieChartContainer();
            ResetCartesianChartContainer();
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
            IncludeTotalProfitCard();
            IncludeCompareWithLastMonthCard();
            IncludeUserRatingCard();
            //IncludePieChart();
            IncludeCartesianChart();
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
        private void IncludeTotalProfitCard()
        {
            TotalProfitCardContainer.Children.Add(new TotalProfitCard());
        }
        private void IncludeCompareWithLastMonthCard()
        {
            CompareWithLastMonthCardContainer.Children.Add(new CompareWithLastMonthCard());
        }
        private void IncludeUserRatingCard()
        {
            UserRatingCardContainer.Children.Add(new UserRatingCard());
        }
        private void IncludePieChart()
        {
            PieChartContainer.Children.Add(new PieChart());
        }
        private void IncludeCartesianChart()
        {
            CartesianChartContainer.Children.Add(new CartesianChart());
        }
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
        private void IncludeMealManagerTable()
        {
            ManagerFieldHolder.Children.Add(new MealManager());
        }
        private void IncludeCategoryList()
        {
            ///<summary>
            /// This function load category list from SQL
            ///</summary>

        }
        private void IncludeCategoryTable()
        {
            ManagerFieldHolder.Children.Add(new CategoryManager());
        }
        private void IncludeTableManager()
        {
            ManagerFieldHolder.Children.Add(new TableManager());
        }
        private void IncludeAccountManager()
        {
            ManagerFieldHolder.Children.Add(new AccountManager());
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
        private void IncludeFoodList()
        {
            ListHolder.Children.Clear();
            List<FoodDTO> foodList = FoodDAO.Instance.GetListFood();
            foreach(FoodDTO food in foodList)
            {
                string category = CategoryDAO.Instance.GetCategoryByID(food.CategoryID);
                int quantity = FoodDAO.Instance.GetOrderQuantityByID(food.Id);

                MealCard meal = new MealCard();
                meal.SetText(food.Name, category, food.Price, quantity);
                ListHolder.Children.Add(meal);
            }
        }
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
        
        public void PieChar()
        {
            PointLabel = chartPoint => string.Format("{0}({1}:P)", chartPoint.Y, chartPoint.Participation);
            DataContext = this;
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
        private void PieChart_DataClick(object sender, ChartPoint chartPoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartPoint.ChartView;
            foreach (PieSeries pieSeries in chart.Series)
            {
                pieSeries.PushOut = 0;
            }
            var selectionSeries = (PieSeries)chartPoint.SeriesView;
            selectionSeries.PushOut = 0;
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
                    AddNewCategory addNewCategory = new AddNewCategory();
                    addNewCategory.ShowDialog();
                    break;
                case 4:
                    //AddNewTable
                    break;
            }
        }
        #endregion

        #region Field
        public Func<ChartPoint, string> PointLabel { get; set; }
        #endregion

        
    }
}