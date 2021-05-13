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
        private void SetGridAssistantToDefault()
        {
            ResetTotalProfitCardContainer();
            ResetCompareWithLastMonthCardContainer();
            ResetUserRatingCardContainer();
            ResetPieChartContainer();
            ResetCartesianChartContainer();
        }
            
        private void ResetManagerFieldHolder()
        {
            ManagerFieldHolder.Children.Clear();
        }
        private void SetGridPrincipalToDefault()
        {
            ResetManagerFieldHolder();
        }
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
       private void SetStaffPage()
        {
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeStaffManagerTable();
            IncludeStaffList();
        }
        private void IncludeMealManagerTable()
        {
            ManagerFieldHolder.Children.Add(new MealManager());
        }
        private void IncludeMealList()
        {
            ///<summary>
            /// This function load meal list from SQL
            ///</summary>
        }
        private void SetMealPage()
        {
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeMealManagerTable();
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

        
        private void SetCategoryPage()
        {
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeCategoryTable();
        }
        private void SetTableManagerPage()
        {
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeTableManager();
        }
        private void IncludeTableManager()
        {
            ManagerFieldHolder.Children.Add(new TableManager());
        }
        private void SetAccountPage()
        {
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeAccountManager();
        }
        private void IncludeAccountManager()
        {
            ManagerFieldHolder.Children.Add(new AccountManager());
        }
        private void SetAccountManagerPage()
        {
            SetGridPrincipalToDefault();
            SetGridPrincipal();
            IncludeAccountManager();
        }
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);
            switch(index)
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
        public Func<ChartPoint, string> PointLabel { get; set; }
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
    }
}
