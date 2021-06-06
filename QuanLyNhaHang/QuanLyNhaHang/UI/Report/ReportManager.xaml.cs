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

namespace QuanLyNhaHang
{
    /// <summary>
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class ReportManager : UserControl
    {
        int month;
        int year;
        public ReportManager()
        {
            InitializeComponent();
            datePicker.SelectedDate = DateTime.Now;
             
        }

        private void datePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            month = datePicker.SelectedDate.Value.Month;
            year = datePicker.SelectedDate.Value.Year;
            totalProfitCard.SetTotalProfitByMonthAndYear(month, year);
            compareLastMonthCard.SetPercenProfitWithLastMonth(month, year);

            if(cartesianChartContainer.Children.Count > 0)
            {
                cartesianChartContainer.Children.Clear();

                cartesianChartContainer.Children.Add(new CartesianChart(year));
            }
        }
    }
}
