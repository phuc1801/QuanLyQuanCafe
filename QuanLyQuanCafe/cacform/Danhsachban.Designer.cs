namespace QuanLyQuanCafe
{
    partial class Danhsachban
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iBtnDSBxem = new FontAwesome.Sharp.IconButton();
            this.iBtnDSBsua = new FontAwesome.Sharp.IconButton();
            this.iBtnDSBxoa = new FontAwesome.Sharp.IconButton();
            this.iBtnDSBthem = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(610, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 593);
            this.panel1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 289);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(44, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "QUẢN LÝ BÀN ĂN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(3, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(6, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên bàn:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(18, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iBtnDSBxem);
            this.panel2.Controls.Add(this.iBtnDSBsua);
            this.panel2.Controls.Add(this.iBtnDSBxoa);
            this.panel2.Controls.Add(this.iBtnDSBthem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 87);
            this.panel2.TabIndex = 1;
            // 
            // iBtnDSBxem
            // 
            this.iBtnDSBxem.BackColor = System.Drawing.Color.SkyBlue;
            this.iBtnDSBxem.FlatAppearance.BorderSize = 0;
            this.iBtnDSBxem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDSBxem.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDSBxem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBxem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iBtnDSBxem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBxem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBxem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBxem.Location = new System.Drawing.Point(453, 6);
            this.iBtnDSBxem.Name = "iBtnDSBxem";
            this.iBtnDSBxem.Size = new System.Drawing.Size(118, 69);
            this.iBtnDSBxem.TabIndex = 3;
            this.iBtnDSBxem.Text = "Xem";
            this.iBtnDSBxem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDSBxem.UseVisualStyleBackColor = false;
            // 
            // iBtnDSBsua
            // 
            this.iBtnDSBsua.BackColor = System.Drawing.Color.SkyBlue;
            this.iBtnDSBsua.FlatAppearance.BorderSize = 0;
            this.iBtnDSBsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDSBsua.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDSBsua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBsua.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.iBtnDSBsua.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBsua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBsua.Location = new System.Drawing.Point(307, 6);
            this.iBtnDSBsua.Name = "iBtnDSBsua";
            this.iBtnDSBsua.Size = new System.Drawing.Size(118, 69);
            this.iBtnDSBsua.TabIndex = 2;
            this.iBtnDSBsua.Text = "Sửa";
            this.iBtnDSBsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDSBsua.UseVisualStyleBackColor = false;
            this.iBtnDSBsua.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iBtnDSBxoa
            // 
            this.iBtnDSBxoa.BackColor = System.Drawing.Color.SkyBlue;
            this.iBtnDSBxoa.FlatAppearance.BorderSize = 0;
            this.iBtnDSBxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDSBxoa.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDSBxoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBxoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iBtnDSBxoa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBxoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBxoa.Location = new System.Drawing.Point(165, 6);
            this.iBtnDSBxoa.Name = "iBtnDSBxoa";
            this.iBtnDSBxoa.Size = new System.Drawing.Size(118, 69);
            this.iBtnDSBxoa.TabIndex = 1;
            this.iBtnDSBxoa.Text = "Xoá";
            this.iBtnDSBxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDSBxoa.UseVisualStyleBackColor = false;
            this.iBtnDSBxoa.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iBtnDSBthem
            // 
            this.iBtnDSBthem.BackColor = System.Drawing.Color.SkyBlue;
            this.iBtnDSBthem.FlatAppearance.BorderSize = 0;
            this.iBtnDSBthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDSBthem.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDSBthem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBthem.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iBtnDSBthem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBthem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBthem.Location = new System.Drawing.Point(21, 6);
            this.iBtnDSBthem.Name = "iBtnDSBthem";
            this.iBtnDSBthem.Size = new System.Drawing.Size(118, 69);
            this.iBtnDSBthem.TabIndex = 0;
            this.iBtnDSBthem.Text = "Thêm";
            this.iBtnDSBthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDSBthem.UseVisualStyleBackColor = false;
            this.iBtnDSBthem.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(610, 506);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 506);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Danhsachban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 593);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Danhsachban";
            this.Text = "Danhsachban";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iBtnDSBxem;
        private FontAwesome.Sharp.IconButton iBtnDSBsua;
        private FontAwesome.Sharp.IconButton iBtnDSBxoa;
        private FontAwesome.Sharp.IconButton iBtnDSBthem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}