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
    /// Interaction logic for TotalProfitCard.xaml
    /// </summary>
    public partial class TotalProfitCard : UserControl
    {
        int currentMonth = DateTime.Now.Month;
        public TotalProfitCard()
        {
            InitializeComponent();
            SetTotalProfit();
        }
        private float GetTotalProfit()
        {
            float totalProfit = 0;
            List<ReportDTO> list = ReportDAO.Instance.GetListRevenue(currentMonth);
            foreach(ReportDTO report in list)
            {
                totalProfit += report.Price;
            }
            return totalProfit;
        }
        private void SetTotalProfit()
        {
            tbProfit.Text = "$ " + GetTotalProfit().ToString();
        }
    }
}
