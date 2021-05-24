﻿using System;
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
    /// Interaction logic for MenuCard.xaml
    /// </summary>
    public partial class MealCard : UserControl
    {
        public MealCard()
        {
            InitializeComponent();
        }

        private void addButton_MouseEnter(object sender, MouseEventArgs e)
        {
            addIcon.Foreground = Brushes.Green;
        }

        private void addButton_MouseLeave(object sender, MouseEventArgs e)
        {
            addIcon.Foreground = Brushes.White;
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.Red;
        }

        private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.White;
        }

        public void SetText(string mealName, int mealCategory, float mealPrice,int orderQuantity )
        {
            this.mealName.Text = mealName;
            
            switch(mealCategory)
            {
                case 1:
                    this.mealCategory.Text = "fasd";
                    break;
                case 2:
                    this.mealCategory.Text = "Nông sản";
                    break;
                case 3:
                    this.mealCategory.Text = "Lâm sản";
                    break;
                case 4:
                    this.mealCategory.Text = "Nước";
                    break;
                case 5:
                    this.mealCategory.Text = "Bottle";
                    break;
            }
            this.mealPrice.Text = mealPrice.ToString();
            this.orderQuantity.Text = orderQuantity.ToString();
        }


    }
}
