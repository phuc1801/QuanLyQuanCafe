﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Account
    {
        private string userName;
        private string passWord;
        private string displayName;
        private int type;

        public Account(string userName, string displayName, int type, string passWord = null) {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Type = type;
            this.PassWord = passWord;
        }

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Type = (int)row["type"];
            this.PassWord = row["passWord"].ToString();
        }

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public int Type { get => type; set => type = value; }
    }
}
