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
    /// Interaction logic for CategoryManager.xaml
    /// </summary>
    public partial class CategoryManager : UserControl
    {

        //event click chuyen
        public RoutedEventHandler RouteEventClick;
        public CategoryManager()
        {
            InitializeComponent();
        }

        public CategoryManager(RoutedEventHandler eventClick)
        {
            this.RouteEventClick = eventClick;
            InitializeComponent();
        }

        private void sortButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleIconStatus();

            if(RouteEventClick != null)
            {
                RouteEventClick(this, e);
            }
        }
        public string GetCurrentButtonStatus()
        {
            if(buttonSortIcon.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom)
            {
                return "descending";
            }
            return "ascending";
        }
        private void ToggleIconStatus()
        {
            if (buttonSortIcon.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom)
            {
                buttonSortIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowTop;
                buttonSortIcon.Foreground = Brushes.Green;
            }
            else
            {
                buttonSortIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom;
                buttonSortIcon.Foreground = Brushes.Red;
            }
        }
    }
}
