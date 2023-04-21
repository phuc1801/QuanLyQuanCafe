using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
    public class Billinfor
    {
        private int iD;
        private int billID;
        private int foodID;
        private int count;
        public Billinfor(int id, int idBill, int idFood, int countBI)
        {
           this.iD = id;
           this.billID = idBill;
           this.foodID = idFood;
           this.count = countBI;
        }

        public Billinfor(DataRow row) {
            this.iD = (int)row["iD"];
            this.billID = (int)row["idbill"];
            this.foodID = (int)row["idfood"];
            this.count = (int)row["count"];
        }

        public int ID { get => iD; set => iD = value; }
        public int BillID { get => billID; set => billID = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public int Count { get => count; set => count = value; }
    }
}
