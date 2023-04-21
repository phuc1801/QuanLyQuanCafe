using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
    public class Bill
    {
        private int iD;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int status;

        public Bill(int id, DateTime? dateCheckin, DateTime? dateCheckout, int statusBill)
        {
           this.iD = id;
           this.dateCheckIn = dateCheckin;
           this.dateCheckOut = dateCheckout;
           this.status = statusBill;
        }

        public Bill(DataRow row) {
            this.iD = (int)row["id"];
            this.dateCheckIn = (DateTime?)row["dateCheckin"];
            var dateCheckOutTemp = row["dateCheckout"];
            if(dateCheckOutTemp.ToString()!="")
                this.dateCheckOut = (DateTime?)dateCheckOutTemp;
             
            this.status = (int)row["statusBill"];
        }

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
    }

}
