using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        public BillDAO() { }

        // thanh cong bill.ID
        // that bai bang -1;
        public int GetUncheckBillIDByTableID(int id) {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT id FROM Bill WHERE idTable = "+id+" AND statusBill = 0");
            if (data.Rows.Count > 0) {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
    }
}
