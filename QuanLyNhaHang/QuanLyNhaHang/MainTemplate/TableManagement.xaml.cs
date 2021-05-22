﻿using QuanLyNhaHang.DAO;
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
using System.Windows.Shapes;

namespace QuanLyNhaHang
{
    /// <summary>
    /// Interaction logic for TableManagement.xaml
    /// </summary>
    public partial class TableManagement : Window
    {
        public TableManagement()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            LoadTable();
        }

        private void LoadTable()
        {
            wpTable.Children.Clear();
            List<TableDTO> tableList = TableDAO.Instance.LoadTableList();

            foreach (TableDTO item in tableList)
            {
                Table btn = new Table();
                btn.SetTest(item.Name, item.Status);
                btn.Tag = item;

                Thickness margin = btn.Margin;
                margin.Left = margin.Right = margin.Top = margin.Bottom = TableDAO.tableMargin;
                btn.Margin = margin;

                btn.SetBackGround(item.Status);

                btn.Click += BtnTable_Click;
                wpTable.Children.Add(btn);
            }
        }
        private void BtnTable_Click(object sender, RoutedEventArgs e)
        {
            int tableID = ((sender as Button).Tag as TableDTO).ID;
            //lvBill.Tag = (sender as Button).Tag;
            //ShowBill(tableID);
        }

        private void exportBillBtn_Click(object sender, RoutedEventArgs e)
        {
            
            
        }
    }
}
