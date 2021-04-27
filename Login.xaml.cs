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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txbPassword.Visibility = Visibility.Collapsed;
        }
        private void DisablePasswordBox()
        {
            passwordBox.Visibility = Visibility.Collapsed;
        }
        private void DisablePasswordTextBox()
        {
            txbPassword.Visibility = Visibility.Collapsed;
        }
        private void EnablePasswordBox()
        {
            passwordBox.Visibility = Visibility.Visible;
        }
        private void EnablePasswordTextBox()
        {
            txbPassword.Visibility = Visibility.Visible;
        }
        private void UnmaskPassword()
        {
            txbPassword.Text = passwordBox.Password;
        }
        private void UpdatePassword()
        {
            passwordBox.Password = txbPassword.Text;
        }
        private void ShowPassword()
        {
            UnmaskPassword();
            DisablePasswordBox();
            EnablePasswordTextBox();
            passwordShow.Kind = MaterialDesignThemes.Wpf.PackIconKind.Eye;
        }
        private void HidePassword()
        {
            UpdatePassword();
            EnablePasswordBox();
            DisablePasswordTextBox();
            passwordShow.Kind = MaterialDesignThemes.Wpf.PackIconKind.EyeOff;
        }
        private void passwordShow_Click(object sender, RoutedEventArgs e)
        {
            if (passwordShow.Kind == MaterialDesignThemes.Wpf.PackIconKind.EyeOff)
            {
                ShowPassword();
                
            }
            else
                HidePassword();
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
