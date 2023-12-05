namespace QuanLyQuanCafe
{
    partial class Thucdon
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.iBtnTDcafe = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowFood = new FontAwesome.Sharp.IconButton();
            this.iBtnDSBsua = new FontAwesome.Sharp.IconButton();
            this.iBtnDSBxoa = new FontAwesome.Sharp.IconButton();
            this.iBtnDSBthem = new FontAwesome.Sharp.IconButton();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchFood);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.cbFoodCategory);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.iBtnTDcafe);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTenMon);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(623, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 593);
            this.panel1.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(91, 432);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(182, 22);
            this.txtPrice.TabIndex = 12;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(91, 382);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(182, 24);
            this.cbFoodCategory.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyQuanCafe.Properties.Resources.cafe;
            this.pictureBox2.Location = new System.Drawing.Point(155, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyQuanCafe.Properties.Resources.A_small_cup_of_coffee;
            this.pictureBox1.Location = new System.Drawing.Point(19, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearch.Location = new System.Drawing.Point(207, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // iBtnTDcafe
            // 
            this.iBtnTDcafe.BackColor = System.Drawing.SystemColors.Control;
            this.iBtnTDcafe.FlatAppearance.BorderSize = 0;
            this.iBtnTDcafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnTDcafe.IconChar = FontAwesome.Sharp.IconChar.MugSaucer;
            this.iBtnTDcafe.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnTDcafe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnTDcafe.Location = new System.Drawing.Point(0, 80);
            this.iBtnTDcafe.Name = "iBtnTDcafe";
            this.iBtnTDcafe.Size = new System.Drawing.Size(66, 51);
            this.iBtnTDcafe.TabIndex = 9;
            this.iBtnTDcafe.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(16, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giá:";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(91, 332);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(182, 22);
            this.txtTenMon.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(91, 278);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(182, 22);
            this.txtID.TabIndex = 4;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(44, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "QUẢN LÝ MÓN ĂN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(16, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh mục:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(16, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên món:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(16, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnShowFood);
            this.panel2.Controls.Add(this.iBtnDSBsua);
            this.panel2.Controls.Add(this.iBtnDSBxoa);
            this.panel2.Controls.Add(this.iBtnDSBthem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 68);
            this.panel2.TabIndex = 2;
            // 
            // btnShowFood
            // 
            this.btnShowFood.BackColor = System.Drawing.Color.SkyBlue;
            this.btnShowFood.FlatAppearance.BorderSize = 0;
            this.btnShowFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowFood.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnShowFood.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowFood.Location = new System.Drawing.Point(453, 6);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(118, 54);
            this.btnShowFood.TabIndex = 3;
            this.btnShowFood.Text = "Xem";
            this.btnShowFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowFood.UseVisualStyleBackColor = false;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // iBtnDSBsua
            // 
            this.iBtnDSBsua.BackColor = System.Drawing.Color.SkyBlue;
            this.iBtnDSBsua.FlatAppearance.BorderSize = 0;
            this.iBtnDSBsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDSBsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDSBsua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBsua.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.iBtnDSBsua.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBsua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBsua.Location = new System.Drawing.Point(307, 6);
            this.iBtnDSBsua.Name = "iBtnDSBsua";
            this.iBtnDSBsua.Size = new System.Drawing.Size(118, 54);
            this.iBtnDSBsua.TabIndex = 2;
            this.iBtnDSBsua.Text = "Sửa";
            this.iBtnDSBsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDSBsua.UseVisualStyleBackColor = false;
            this.iBtnDSBsua.Click += new System.EventHandler(this.iBtnDSBsua_Click);
            // 
            // iBtnDSBxoa
            // 
            this.iBtnDSBxoa.BackColor = System.Drawing.Color.SkyBlue;
            this.iBtnDSBxoa.FlatAppearance.BorderSize = 0;
            this.iBtnDSBxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDSBxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDSBxoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBxoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iBtnDSBxoa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBxoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBxoa.Location = new System.Drawing.Point(165, 6);
            this.iBtnDSBxoa.Name = "iBtnDSBxoa";
            this.iBtnDSBxoa.Size = new System.Drawing.Size(118, 54);
            this.iBtnDSBxoa.TabIndex = 1;
            this.iBtnDSBxoa.Text = "Xoá";
            this.iBtnDSBxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDSBxoa.UseVisualStyleBackColor = false;
            this.iBtnDSBxoa.Click += new System.EventHandler(this.iBtnDSBxoa_Click);
            // 
            // iBtnDSBthem
            // 
            this.iBtnDSBthem.BackColor = System.Drawing.Color.SkyBlue;
            this.iBtnDSBthem.FlatAppearance.BorderSize = 0;
            this.iBtnDSBthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDSBthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDSBthem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBthem.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iBtnDSBthem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBthem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBthem.Location = new System.Drawing.Point(21, 6);
            this.iBtnDSBthem.Name = "iBtnDSBthem";
            this.iBtnDSBthem.Size = new System.Drawing.Size(118, 54);
            this.iBtnDSBthem.TabIndex = 0;
            this.iBtnDSBthem.Text = "Thêm";
            this.iBtnDSBthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDSBthem.UseVisualStyleBackColor = false;
            this.iBtnDSBthem.Click += new System.EventHandler(this.iBtnDSBthem_Click);
            // 
            // dgvFood
            // 
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFood.Location = new System.Drawing.Point(0, 68);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.Size = new System.Drawing.Size(623, 525);
            this.dgvFood.TabIndex = 3;
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFood.Location = new System.Drawing.Point(72, 95);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(119, 22);
            this.txtSearchFood.TabIndex = 13;
            // 
            // Thucdon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 593);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Thucdon";
            this.Text = "Thucdon";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnShowFood;
        private FontAwesome.Sharp.IconButton iBtnDSBsua;
        private FontAwesome.Sharp.IconButton iBtnDSBxoa;
        private FontAwesome.Sharp.IconButton iBtnDSBthem;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iBtnTDcafe;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSearchFood;
    }
}