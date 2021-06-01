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

namespace QuanLyNhaHang
{
    /// <summary>
    /// Interaction logic for CompareWithLastMonthCard.xaml
    /// </summary>
    public partial class CompareWithLastMonthCard : UserControl
    {
        int currentMonth = DateTime.Now.Month;
        public CompareWithLastMonthCard()
        {
            InitializeComponent();
            SetPercentProfitWithLastMonth();
        }
        private float GetCurrentMonthProfit()
        {
            float profit = 0;
            List<ReportDTO> list = ReportDAO.Instance.GetListRevenue(currentMonth);
            foreach(ReportDTO report in list)
            {
                profit += report.Price;
            }
            return profit;
        }
        private float GetPreMonthProfit()
        {
            float profit = 0;
            List<ReportDTO> list = ReportDAO.Instance.GetListRevenue(currentMonth - 1);
            foreach (ReportDTO report in list)
            {
                profit += report.Price;
            }
            return profit;
        }

        private void SetPercentProfitWithLastMonth()
        {
            float currentProfit = GetCurrentMonthProfit();
            float preProfit = GetPreMonthProfit() == 0 ? 1 : GetPreMonthProfit() ;
            float percent = currentMonth / preProfit * 100;
            tbPercent.Text = percent.ToString() + "%";
        }
    }
}
