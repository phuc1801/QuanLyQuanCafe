namespace QuanLyQuanCafe
{
    partial class frmTableManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ibtnTaikhoan = new FontAwesome.Sharp.IconButton();
            this.ibtnDoanhthu = new FontAwesome.Sharp.IconButton();
            this.ibtnDanhmuc = new FontAwesome.Sharp.IconButton();
            this.ibtnThucdon = new FontAwesome.Sharp.IconButton();
            this.ibtnlistBan = new FontAwesome.Sharp.IconButton();
            this.ibtnHoadon = new FontAwesome.Sharp.IconButton();
            this.ibtnTrangchu = new FontAwesome.Sharp.IconButton();
            this.logocoffee = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.panelMenu.Controls.Add(this.ibtnTaikhoan);
            this.panelMenu.Controls.Add(this.ibtnDoanhthu);
            this.panelMenu.Controls.Add(this.ibtnDanhmuc);
            this.panelMenu.Controls.Add(this.ibtnThucdon);
            this.panelMenu.Controls.Add(this.ibtnlistBan);
            this.panelMenu.Controls.Add(this.ibtnHoadon);
            this.panelMenu.Controls.Add(this.ibtnTrangchu);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 623);
            this.panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.logocoffee);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 125);
            this.panel2.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ibtnTaikhoan
            // 
            this.ibtnTaikhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnTaikhoan.FlatAppearance.BorderSize = 0;
            this.ibtnTaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnTaikhoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnTaikhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ibtnTaikhoan.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ibtnTaikhoan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ibtnTaikhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnTaikhoan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnTaikhoan.Location = new System.Drawing.Point(0, 509);
            this.ibtnTaikhoan.Name = "ibtnTaikhoan";
            this.ibtnTaikhoan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnTaikhoan.Size = new System.Drawing.Size(230, 64);
            this.ibtnTaikhoan.TabIndex = 7;
            this.ibtnTaikhoan.Text = "Tài khoản";
            this.ibtnTaikhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnTaikhoan.UseVisualStyleBackColor = true;
            this.ibtnTaikhoan.Click += new System.EventHandler(this.ibtnTaikhoan_Click);
            // 
            // ibtnDoanhthu
            // 
            this.ibtnDoanhthu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnDoanhthu.FlatAppearance.BorderSize = 0;
            this.ibtnDoanhthu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDoanhthu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnDoanhthu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ibtnDoanhthu.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.ibtnDoanhthu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ibtnDoanhthu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDoanhthu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnDoanhthu.Location = new System.Drawing.Point(0, 445);
            this.ibtnDoanhthu.Name = "ibtnDoanhthu";
            this.ibtnDoanhthu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnDoanhthu.Size = new System.Drawing.Size(230, 64);
            this.ibtnDoanhthu.TabIndex = 6;
            this.ibtnDoanhthu.Text = "Doanh thu";
            this.ibtnDoanhthu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDoanhthu.UseVisualStyleBackColor = true;
            this.ibtnDoanhthu.Click += new System.EventHandler(this.ibtnDoanhthu_Click);
            // 
            // ibtnDanhmuc
            // 
            this.ibtnDanhmuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnDanhmuc.FlatAppearance.BorderSize = 0;
            this.ibtnDanhmuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDanhmuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnDanhmuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ibtnDanhmuc.IconChar = FontAwesome.Sharp.IconChar.List;
            this.ibtnDanhmuc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ibtnDanhmuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDanhmuc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnDanhmuc.Location = new System.Drawing.Point(0, 381);
            this.ibtnDanhmuc.Name = "ibtnDanhmuc";
            this.ibtnDanhmuc.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnDanhmuc.Size = new System.Drawing.Size(230, 64);
            this.ibtnDanhmuc.TabIndex = 5;
            this.ibtnDanhmuc.Text = "Danh mục";
            this.ibtnDanhmuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDanhmuc.UseVisualStyleBackColor = true;
            this.ibtnDanhmuc.Click += new System.EventHandler(this.ibtnDanhmuc_Click);
            // 
            // ibtnThucdon
            // 
            this.ibtnThucdon.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnThucdon.FlatAppearance.BorderSize = 0;
            this.ibtnThucdon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnThucdon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnThucdon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ibtnThucdon.IconChar = FontAwesome.Sharp.IconChar.FillDrip;
            this.ibtnThucdon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ibtnThucdon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThucdon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnThucdon.Location = new System.Drawing.Point(0, 317);
            this.ibtnThucdon.Name = "ibtnThucdon";
            this.ibtnThucdon.Padding = new System.Windows.Forms.Padding(5, 0, 20, 0);
            this.ibtnThucdon.Size = new System.Drawing.Size(230, 64);
            this.ibtnThucdon.TabIndex = 4;
            this.ibtnThucdon.Text = "Thực đơn";
            this.ibtnThucdon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnThucdon.UseVisualStyleBackColor = true;
            this.ibtnThucdon.Click += new System.EventHandler(this.ibtnThucdon_Click);
            // 
            // ibtnlistBan
            // 
            this.ibtnlistBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnlistBan.FlatAppearance.BorderSize = 0;
            this.ibtnlistBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnlistBan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnlistBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ibtnlistBan.IconChar = FontAwesome.Sharp.IconChar.Th;
            this.ibtnlistBan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ibtnlistBan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnlistBan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnlistBan.Location = new System.Drawing.Point(0, 253);
            this.ibtnlistBan.Name = "ibtnlistBan";
            this.ibtnlistBan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnlistBan.Size = new System.Drawing.Size(230, 64);
            this.ibtnlistBan.TabIndex = 3;
            this.ibtnlistBan.Text = "Danh sách bàn";
            this.ibtnlistBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnlistBan.UseVisualStyleBackColor = true;
            this.ibtnlistBan.Click += new System.EventHandler(this.ibtnlistBan_Click);
            // 
            // ibtnHoadon
            // 
            this.ibtnHoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnHoadon.FlatAppearance.BorderSize = 0;
            this.ibtnHoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnHoadon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnHoadon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ibtnHoadon.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.ibtnHoadon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ibtnHoadon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnHoadon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnHoadon.Location = new System.Drawing.Point(0, 189);
            this.ibtnHoadon.Name = "ibtnHoadon";
            this.ibtnHoadon.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.ibtnHoadon.Size = new System.Drawing.Size(230, 64);
            this.ibtnHoadon.TabIndex = 2;
            this.ibtnHoadon.Text = "Hoá đơn";
            this.ibtnHoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnHoadon.UseVisualStyleBackColor = true;
            this.ibtnHoadon.Click += new System.EventHandler(this.ibtnHoadon_Click);
            // 
            // ibtnTrangchu
            // 
            this.ibtnTrangchu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnTrangchu.FlatAppearance.BorderSize = 0;
            this.ibtnTrangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnTrangchu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnTrangchu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ibtnTrangchu.IconChar = FontAwesome.Sharp.IconChar.House;
            this.ibtnTrangchu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ibtnTrangchu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnTrangchu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnTrangchu.Location = new System.Drawing.Point(0, 125);
            this.ibtnTrangchu.Name = "ibtnTrangchu";
            this.ibtnTrangchu.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.ibtnTrangchu.Size = new System.Drawing.Size(230, 64);
            this.ibtnTrangchu.TabIndex = 1;
            this.ibtnTrangchu.Text = "Trang chủ";
            this.ibtnTrangchu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnTrangchu.UseVisualStyleBackColor = true;
            this.ibtnTrangchu.Click += new System.EventHandler(this.ibtnTrangchu_Click);
            // 
            // logocoffee
            // 
            this.logocoffee.Dock = System.Windows.Forms.DockStyle.Top;
            this.logocoffee.FlatAppearance.BorderSize = 0;
            this.logocoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logocoffee.IconChar = FontAwesome.Sharp.IconChar.MugHot;
            this.logocoffee.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logocoffee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logocoffee.IconSize = 120;
            this.logocoffee.Location = new System.Drawing.Point(0, 0);
            this.logocoffee.Name = "logocoffee";
            this.logocoffee.Size = new System.Drawing.Size(230, 125);
            this.logocoffee.TabIndex = 0;
            this.logocoffee.UseVisualStyleBackColor = true;
            this.logocoffee.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDesktop.Location = new System.Drawing.Point(230, 3);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(876, 620);
            this.panelDesktop.TabIndex = 1;
            // 
            // frmTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 623);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconButton ibtnTaikhoan;
        private FontAwesome.Sharp.IconButton ibtnDoanhthu;
        private FontAwesome.Sharp.IconButton ibtnDanhmuc;
        private FontAwesome.Sharp.IconButton ibtnThucdon;
        private FontAwesome.Sharp.IconButton ibtnlistBan;
        private FontAwesome.Sharp.IconButton ibtnHoadon;
        private FontAwesome.Sharp.IconButton logocoffee;
        private FontAwesome.Sharp.IconButton ibtnTrangchu;
        private System.Windows.Forms.Panel panelDesktop;
    }
}