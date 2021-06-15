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
    /// Interaction logic for MealStatusCard.xaml
    /// </summary>
    public partial class MealStatusCard : UserControl
    {
        public MealStatusCard()
        {
            InitializeComponent();
        }
        public void SetText(string foodname, int count, string des, int status)
        {
            mealOrder.Text = count.ToString();
            name.Text = foodname;
            mealDescription.Text = des;
            if (status == 1)
                mealStatus.Text = "Done";
            else
                mealStatus.Text = "Not done";
        }
    }
}
