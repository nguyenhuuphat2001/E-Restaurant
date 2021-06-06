﻿using LiveCharts;
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
        bool collIsBusy = false;
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
        
        public void SetSelectedYearChart(int year)
        {
            try
            {
                if (SeriesCollection != null && SeriesCollection.Count > 0 && !collIsBusy)
                {
                    collIsBusy = true;
                    SeriesCollection.Clear();
                    collIsBusy = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in clearing seriesCollection\n")  ;
            }
            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Profit",
                    Values = new ChartValues<float>(GetSelectedYearRevenue(year))
                }
            };
            
            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            MessageBox.Show("Set succesful");
            Formatter = value => value.ToString("N");
            DataContext = this;
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
        private List<float> GetSelectedYearRevenue(int year)
        {
            List<float> list = new List<float>();
            for (int month = 1; month < 13; month++)
            {
                List<ReportDTO> reports = ReportDAO.Instance.GetListRevenue(month, year);
                float profit = 0;
                foreach (ReportDTO report in reports)
                {
                    profit += report.Price;
                }
                list.Add(profit);
            }
            return list;
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
