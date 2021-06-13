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
    /// Interaction logic for AccountManager.xaml
    /// </summary>
    public partial class AccountManager : UserControl
    {
        public RoutedEventHandler eventSortByUsername;
        public RoutedEventHandler eventSortByOwner;
        public RoutedEventHandler eventSortByPosition;
        public AccountManager(RoutedEventHandler eventSortByUsername, RoutedEventHandler eventSortByOwner, RoutedEventHandler eventSortByPosition)
        {
            this.eventSortByUsername = eventSortByUsername;
            this.eventSortByOwner = eventSortByOwner;
            this.eventSortByPosition = eventSortByPosition;
            InitializeComponent();
        }

        private void sortUsername_Click(object sender, RoutedEventArgs e)
        {
            ToggleIconStatus(buttonSortUsername);
            if (eventSortByUsername != null)
            {
                eventSortByUsername(this, e);
            }
        }

        private void sortOwner_Click(object sender, RoutedEventArgs e)
        {
            ToggleIconStatus(buttonSortOwner);
            if (eventSortByOwner != null)
            {
                eventSortByOwner(this, e);
            }
        }

        private void sortPosition_Click(object sender, RoutedEventArgs e)
        {
            ToggleIconStatus(buttonSortPosition);
            if (eventSortByPosition != null)
            {
                eventSortByPosition(this, e);
            }
        }
        private void ToggleIconStatus(MaterialDesignThemes.Wpf.PackIcon btn)
        {
            if (btn.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom)
            {
                btn.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowTop;
                btn.Foreground = Brushes.Green;
            }
            else
            {
                btn.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom;
                btn.Foreground = Brushes.Red;
            }
        }

        
    }
}
