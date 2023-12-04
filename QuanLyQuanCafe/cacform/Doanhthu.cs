using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class Doanhthu : Form
    {
        public Doanhthu()
        {
            InitializeComponent();
            loadListBillByDate(dtpcheckIn.Value, dtpcheckOut.Value);
            loadDauThangCuoiThang();
        }

        void loadDauThangCuoiThang()
        {
            DateTime today = DateTime.Now;
            dtpcheckIn.Value = new DateTime(today.Year, today.Month, 1);
            dtpcheckOut.Value = dtpcheckIn.Value.AddMonths(1).AddDays(-1);
        }

        //methods

        void loadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
           dgvBill.DataSource =  BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }


        //even
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            loadListBillByDate(dtpcheckIn.Value, dtpcheckOut.Value);
        }
    }
}
