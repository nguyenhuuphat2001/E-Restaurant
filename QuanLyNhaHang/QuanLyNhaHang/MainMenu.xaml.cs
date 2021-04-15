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
            this.PieChar();
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
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

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //int index = ListViewItem.SelectedIndex;
            //MoveCursorMenu(index);

            UserControl usc = null;
            GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemHome":
                    usc = new UserControl();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemCreate":
                    usc = new UserControl();
                    GridMain.Children.Add(usc);
                    break;
                default:
                    break;
            }


        }
        public Func<ChartPoint, string> PointLabel { get; set; }
        public void PieChar()
        {
            PointLabel = chartPoint => string.Format("{0}({1}:P)", chartPoint.Y , chartPoint.Participation);
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
            foreach(PieSeries pieSeries in chart.Series)
            {
                pieSeries.PushOut = 0;
            }
            var selectionSeries = (PieSeries)chartPoint.SeriesView;
            selectionSeries.PushOut = 0;
        }
    }
}
