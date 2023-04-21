using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    public class BillinforDAO
    {
        private static BillinforDAO instance;
        public static BillinforDAO Instance
        {
            get { if (instance == null) instance = new BillinforDAO(); return BillinforDAO.instance; }
            private set { BillinforDAO.instance = value; }
        }
        private BillinforDAO() { }

        public List<Billinfor> GetListInfor(int id) {
            List<Billinfor> listBillInfor = new List<Billinfor>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BillInfo WHERE  idBill = " + id);
            foreach (DataRow item in data.Rows) {
                Billinfor info = new Billinfor(item);
                listBillInfor.Add(info);
            }
            return listBillInfor;
        } 
    }
}
