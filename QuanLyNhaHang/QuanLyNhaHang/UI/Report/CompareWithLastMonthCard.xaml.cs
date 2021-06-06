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
        int currentYear = DateTime.Now.Year;
        public CompareWithLastMonthCard()
        {
            InitializeComponent();
            SetPercentProfitWithLastMonth();
        }
        private float GetCurrentMonthProfit()
        {
            float profit = 0;
            List<ReportDTO> list = ReportDAO.Instance.GetListRevenue(currentMonth);
            foreach (ReportDTO report in list)
            {
                profit += report.Price;
            }
            return profit;
        }
        private float GetPreMonthProfit()
        {
            List<ReportDTO> list;
            float profit = 0;
            if (currentMonth == 1)
            {
                list = ReportDAO.Instance.GetListRevenue(12, currentYear - 1);
            }
            else
            {
                list = ReportDAO.Instance.GetListRevenue(currentMonth - 1);
            }
            foreach (ReportDTO report in list)
            {
                profit += report.Price;
            }
            return profit;
        }

        private void SetPercentProfitWithLastMonth()
        {
            double currentProfit = GetCurrentMonthProfit();
            double preProfit = GetPreMonthProfit() == 0 ? 1 : GetPreMonthProfit();
            double percent = Math.Round(currentMonth / preProfit * 100,5);
            tbPercent.Text = percent.ToString() + "%";
        }
        private float GetSelectedMonthProfit(int month, int year)
        {
            float profit = 0;
            List<ReportDTO> list = ReportDAO.Instance.GetListRevenue(month, year);
            foreach(ReportDTO report in list)
            {
                profit += report.Price;
            }
            return profit;
        }
        private float GetPreSelectedMonthProfit(int month, int year)
        {
            float profit = 0;
            int preMonth;
            if (month == 1)
            {
                preMonth = 12;
                year = year - 1;
            }
            else
            {
                preMonth = month - 1;
            }
            List<ReportDTO> list = ReportDAO.Instance.GetListRevenue(preMonth, year);
               
            foreach(ReportDTO report in list)
            {
                profit += report.Price;
            }
            return profit;
        }
        public void SetPercenProfitWithLastMonth(int month, int year)
        {
            double selectedMonthProfit = GetSelectedMonthProfit(month, year);
            double preSelectedMonthProfit = GetPreSelectedMonthProfit(month, year) == 0 ? 1 : GetPreSelectedMonthProfit(month, year) ;
            double percent = Math.Round(selectedMonthProfit / preSelectedMonthProfit * 100, 5);
            tbPercent.Text = percent.ToString() + "%";
        }
    }
}
