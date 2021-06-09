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
    /// Interaction logic for TableManager.xaml
    /// </summary>
    public partial class TableManager : UserControl
    {
        public RoutedEventHandler eventHandler;
        public TableManager()
        {
            InitializeComponent();
        }
        public TableManager(RoutedEventHandler eventHandler)
        {
            this.eventHandler = eventHandler;
            InitializeComponent();
        }
        private void sortButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleIconStatus();
            if(eventHandler != null)
            {
                eventHandler(this, e);
            }
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
