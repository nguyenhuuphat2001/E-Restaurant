using LiveCharts;
using LiveCharts.Wpf;
using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for CartesianChart.xaml
    /// </summary>
    public partial class CartesianChart : UserControl
    {

        public CartesianChart()
        {
            InitializeComponent();


            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Profit",
                    Values = new ChartValues<float>(GetYearRevenue())
                }
            };

            
            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            Formatter = value => value.ToString("N");
            DataContext = this; 

        }



        private void LoadCollection()
        {

        }

        private List<float> GetYearRevenue()
        {
            List<float> list = new List<float>();
            for (int month = 1; month < 13; month++)
            {
                List<ReportDTO> reports = ReportDAO.Instance.GetListRevenue(month);
                float profit = 0;
                foreach (ReportDTO report in reports)
                {
                    profit += report.Price;
                }
                list.Add(profit);
            }

            return list;
        }

        private void SetXAxis()
        {
            SeriesCollection[1].Values.Add(48d);
            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        }
        private void SetYAxis()
        {
            List<float> profit = GetYearRevenue();
            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Month",
                Values = new ChartValues<float>(profit)
            }
            );
        }

        public SeriesCollection SeriesCollection
        {
            get;
            set;
        }
        public string[] Labels { get; set; }
        public Func<float, string> Formatter { get; set; }

    }
}
