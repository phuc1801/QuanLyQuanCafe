namespace QuanLyQuanCafe
{
    partial class Hoadon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flptabFood = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBill = new System.Windows.Forms.ListView();
            this.IDfood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.iBtnHDcafe = new FontAwesome.Sharp.IconButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBtnThanhtoan = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flptabFood);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 730);
            this.panel1.TabIndex = 0;
            // 
            // flptabFood
            // 
            this.flptabFood.AutoScroll = true;
            this.flptabFood.Location = new System.Drawing.Point(4, 4);
            this.flptabFood.Margin = new System.Windows.Forms.Padding(4);
            this.flptabFood.Name = "flptabFood";
            this.flptabFood.Size = new System.Drawing.Size(645, 722);
            this.flptabFood.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBill);
            this.panel2.Location = new System.Drawing.Point(661, 182);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 442);
            this.panel2.TabIndex = 1;
            // 
            // listBill
            // 
            this.listBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDfood,
            this.Count,
            this.columnHeader1,
            this.columnHeader2});
            this.listBill.GridLines = true;
            this.listBill.HideSelection = false;
            this.listBill.Location = new System.Drawing.Point(24, 10);
            this.listBill.Margin = new System.Windows.Forms.Padding(4);
            this.listBill.Name = "listBill";
            this.listBill.Size = new System.Drawing.Size(486, 432);
            this.listBill.TabIndex = 0;
            this.listBill.UseCompatibleStateImageBehavior = false;
            this.listBill.View = System.Windows.Forms.View.Details;
            // 
            // IDfood
            // 
            this.IDfood.Text = "Tên món ";
            this.IDfood.Width = 155;
            // 
            // Count
            // 
            this.Count.Text = "Số lượng";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Đơn giá";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Thành tiền";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.iBtnHDcafe);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Location = new System.Drawing.Point(663, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 175);
            this.panel3.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(416, 111);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // iBtnHDcafe
            // 
            this.iBtnHDcafe.FlatAppearance.BorderSize = 0;
            this.iBtnHDcafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnHDcafe.IconChar = FontAwesome.Sharp.IconChar.MugHot;
            this.iBtnHDcafe.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnHDcafe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnHDcafe.IconSize = 60;
            this.iBtnHDcafe.Location = new System.Drawing.Point(29, 4);
            this.iBtnHDcafe.Margin = new System.Windows.Forms.Padding(4);
            this.iBtnHDcafe.Name = "iBtnHDcafe";
            this.iBtnHDcafe.Size = new System.Drawing.Size(112, 75);
            this.iBtnHDcafe.TabIndex = 2;
            this.iBtnHDcafe.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(265, 97);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thêm món";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(376, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chuyển bàn";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(4, 127);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(233, 24);
            this.comboBox3.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(4, 94);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(233, 24);
            this.comboBox2.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 30);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTotalPrice);
            this.panel4.Controls.Add(this.numericUpDown2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.tBtnThanhtoan);
            this.panel4.Location = new System.Drawing.Point(661, 631);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(556, 98);
            this.panel4.TabIndex = 3;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.txtTotalPrice.Location = new System.Drawing.Point(140, 59);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(235, 27);
            this.txtTotalPrice.TabIndex = 6;
            this.txtTotalPrice.Text = "0";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(140, 16);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(79, 22);
            this.numericUpDown2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giảm giá (%):";
            // 
            // tBtnThanhtoan
            // 
            this.tBtnThanhtoan.BackColor = System.Drawing.Color.SkyBlue;
            this.tBtnThanhtoan.FlatAppearance.BorderSize = 0;
            this.tBtnThanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tBtnThanhtoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tBtnThanhtoan.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.tBtnThanhtoan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tBtnThanhtoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tBtnThanhtoan.Location = new System.Drawing.Point(384, 7);
            this.tBtnThanhtoan.Margin = new System.Windows.Forms.Padding(4);
            this.tBtnThanhtoan.Name = "tBtnThanhtoan";
            this.tBtnThanhtoan.Size = new System.Drawing.Size(109, 76);
            this.tBtnThanhtoan.TabIndex = 2;
            this.tBtnThanhtoan.Text = "Thanh toán";
            this.tBtnThanhtoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tBtnThanhtoan.UseVisualStyleBackColor = false;
            // 
            // Hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 730);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Hoadon";
            this.Text = "Hoadon";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flptabFood;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private FontAwesome.Sharp.IconButton iBtnHDcafe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton tBtnThanhtoan;
        private System.Windows.Forms.ColumnHeader IDfood;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}