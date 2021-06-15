using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuanLyNhaHang.MainTemplate
{
    class TableManagementCommand : Base   {

        public ICommand LoadCommand { get; set; }
        public ICommand GetTableManagement { get; set; }
        private TableManagement tableManagement;
        public TableManagementCommand()
        {
            LoadCommand = new RelayCommand<Table>((parameter) => true, (parameter) => Load(parameter));
            GetTableManagement = new RelayCommand<TableManagement>((parameter) => true, (parameter) => Get(parameter));
        }
        public void Load(Table table)
        {

            int tableID = (table.Tag as TableDTO).ID;

            this.tableManagement.spmealstatus.Tag = table.Tag;

            LoadMealStatus(tableID);
            LoadDiscount(tableID);
            LoadPrice(tableID);
        }

        private void LoadMealStatus(int tableID)
        {
            List<MealStatusDTO> listBillInfo = MealStatusDAO.Instance.GetListMealStatuses(tableID);

            this.tableManagement.spmealstatus.Children.Clear();

            foreach (MealStatusDTO item in listBillInfo)
            {
                MealStatusCard card = new MealStatusCard();
                card.Tag = item;
                card.SetText(item.Foodname, item.Count, item.Description, item.Status);
                this.tableManagement.spmealstatus.Children.Add(card);
            }
        }
        private void LoadDiscount(int tableID)
        {
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(tableID);
            this.tableManagement.discount.discountTextBox.Text = BillDAO.Instance.GetDiscount(idBill).ToString();
        }
        private void LoadPrice(int tableID)
        {
            float price = 0;
            List<BillInfoDTO> listBill = BillInfoDAO.Instance.GetListMenuByTable(tableID);
            foreach (BillInfoDTO bill in listBill)
            {
                price += bill.TotalPrice;
            }

            this.tableManagement.Price.Text = price.ToString() + " VND";
        }

        public void Get(TableManagement table)
        {
            this.tableManagement = table;
        }
    }
}
