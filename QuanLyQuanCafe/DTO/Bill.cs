﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Bill
    {
        private int status;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int iD;
        private int discount;

        public Bill(int id, DateTime? dateCheckin, DateTime? dateCheckOut, int status, int discount = 0)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckin;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
        }

        public Bill(DataRow row) {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckin"];
            var dataCheckOutTemp = row["dateCheckOut"];
            if(dataCheckOutTemp.ToString() != "" ) {
                this.DateCheckOut = (DateTime?)dataCheckOutTemp;
            }
                
            this.Status = (int)row["status"];
            if(row["discount"].ToString() != "")
                this.Discount = (int)row["discount"];
        }

        

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
