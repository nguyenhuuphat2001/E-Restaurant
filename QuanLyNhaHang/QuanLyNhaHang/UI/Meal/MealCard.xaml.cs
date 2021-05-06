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

        //private void addButton_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    addButton.Foreground = Brushes.Green;
        //}

        //private void addButton_MouseLeave(object sender, MouseEventArgs e)
        //{
        //    addButton.Foreground = Brushes.White;
        //}

        //private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    deleteButton.Foreground = Brushes.Red;
        //}

        //private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        //{
        //    deleteButton.Foreground = Brushes.White;
        //}


    }
}
