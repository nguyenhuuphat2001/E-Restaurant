using QuanLyNhaHang.DAO;
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
    /// Interaction logic for ModifyCategory.xaml
    /// </summary>
    
    
    public partial class ModifyCategory : Window
    {
        private string funtion;
        private int id;
        private event EventHandler modify;
        private string name;
        public bool isUpdate=false;

        public string Name { get => name; set => name = value; }

        public event EventHandler Modify
        {
            add { modify += value; }
            remove { modify -= value; }
        }
        public ModifyCategory(string funtion, int id)
        {
            InitializeComponent();
            this.funtion = funtion;
            this.id = id;
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            this.Name = txtNameCategory.Text;
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Category name must not be empty");
            }
            
            switch (funtion)
            {
                case "Add":
                    AddCategory();
                    break;
                case "Edit":
                    EditCategory();
                    break;
            }
            
        }

        private void AddCategory()
        {
            if (CategoryDAO.Instance.InsertCategory(this.Name))
            {
                MessageBox.Show("Add new category succesfully");
                if (modify != null)
                    modify(this, new EventArgs());
                this.Close();
            }
            else
            {
                MessageBox.Show("Add new category failed");
                this.Close();
            }
        }

        private void EditCategory()
        {
            if (CategoryDAO.Instance.UpdateCategory(this.Name, this.id))
            {
                MessageBox.Show("Edit category succesfully");
                if (modify != null)
                {
                    isUpdate = true;
                    modify(this, new EventArgs());
                }
                    
                this.Close();
            }
            else
            {
                MessageBox.Show("Edit category failed");
                this.Close();
            }
        }
    }
}
