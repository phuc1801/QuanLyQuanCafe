using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCafe.DTO
{
    public class TableDTO
    {
        private int iD;
        private String name;
        private String Status;
        public TableDTO(int iD, string name, string Status)
        {
            this.iD = iD;
            this.Name = name;
            this.Status1 = Status;
        }
        public static int TableWidth = 100;
        public static int TableHeight = 100;
        public TableDTO(DataRow row) {
            this.iD = (int)row["id"];
            this.name = (String)row["nametab"].ToString();
            this.Status = (String)row["statusCheck"].ToString();
            
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Status1 { get => Status; set => Status = value; }
    }
}
