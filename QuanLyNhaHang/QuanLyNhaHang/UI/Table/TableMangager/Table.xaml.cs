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
    /// Interaction logic for Table.xaml
    /// </summary>
    public partial class Table : UserControl
    {
        //string name=null;
        //string status=null;
        public Table()
        {
            InitializeComponent();

        }

        public Action<object, RoutedEventArgs> Click { get; internal set; }

        public void SetTest(string name, string status)
        {
            tableName.Text = name;
            tableStatus.Text = status;
        }

        public void SetBackGround(string status)
        {
            switch (status)
            {
                case "Empty":
                    btnTable.Background = new SolidColorBrush(Colors.PaleGreen);
                    break;
                default:
                    btnTable.Background = new SolidColorBrush(Colors.Salmon);
                    break;
            }
        }
    }
}
