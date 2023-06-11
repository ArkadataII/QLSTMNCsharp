namespace QLSTMINI
{
    partial class QLHH
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
            this.dgHH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdThem = new System.Windows.Forms.Button();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdLuu = new System.Windows.Forms.Button();
            this.cmdKhong = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo2 = new System.Windows.Forms.ComboBox();
            this.cmdALL = new System.Windows.Forms.Button();
            this.cbo3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgHH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHH
            // 
            this.dgHH.AllowUserToAddRows = false;
            this.dgHH.AllowUserToDeleteRows = false;
            this.dgHH.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgHH.Location = new System.Drawing.Point(8, 104);
            this.dgHH.Margin = new System.Windows.Forms.Padding(5);
            this.dgHH.Name = "dgHH";
            this.dgHH.ReadOnly = true;
            this.dgHH.RowHeadersWidth = 51;
            this.dgHH.RowTemplate.Height = 24;
            this.dgHH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHH.Size = new System.Drawing.Size(688, 392);
            this.dgHH.TabIndex = 1;
            this.dgHH.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgHH_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHH";
            this.Column1.HeaderText = "Mã hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenHH";
            this.Column2.HeaderText = "Tên hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 135;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaNH";
            this.Column3.HeaderText = "Mã NH";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaNCC";
            this.Column4.HeaderText = "Mã NCC";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GiaNhap";
            this.Column5.HeaderText = "Gía nhập";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 135;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GiaXuat";
            this.Column6.HeaderText = "Gía xuất";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 135;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TonKho";
            this.Column7.HeaderText = "Tồn kho";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhóm hàng :";
            // 
            // cbo1
            // 
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Location = new System.Drawing.Point(152, 64);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(232, 33);
            this.cbo1.TabIndex = 3;
            this.cbo1.SelectedIndexChanged += new System.EventHandler(this.cbo1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(704, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã hàng :";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(872, 176);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.ReadOnly = true;
            this.txtMaHang.Size = new System.Drawing.Size(304, 32);
            this.txtMaHang.TabIndex = 5;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(872, 216);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(304, 32);
            this.txtTenHang.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên hàng: ";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(872, 296);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(304, 32);
            this.txtDonGia.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(704, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gía xuất: ";
            // 
            // txtTonKho
            // 
            this.txtTonKho.Location = new System.Drawing.Point(872, 336);
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.Size = new System.Drawing.Size(304, 32);
            this.txtTonKho.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(704, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tồn kho :";
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(736, 392);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(112, 48);
            this.cmdThem.TabIndex = 12;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.Location = new System.Drawing.Point(896, 392);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(112, 48);
            this.cmdSua.TabIndex = 13;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Location = new System.Drawing.Point(1056, 392);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(112, 48);
            this.cmdXoa.TabIndex = 14;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdLuu
            // 
            this.cmdLuu.Location = new System.Drawing.Point(816, 448);
            this.cmdLuu.Name = "cmdLuu";
            this.cmdLuu.Size = new System.Drawing.Size(112, 48);
            this.cmdLuu.TabIndex = 15;
            this.cmdLuu.Text = "Lưu";
            this.cmdLuu.UseVisualStyleBackColor = true;
            this.cmdLuu.Click += new System.EventHandler(this.cmdLuu_Click);
            // 
            // cmdKhong
            // 
            this.cmdKhong.Location = new System.Drawing.Point(976, 448);
            this.cmdKhong.Name = "cmdKhong";
            this.cmdKhong.Size = new System.Drawing.Size(112, 48);
            this.cmdKhong.TabIndex = 16;
            this.cmdKhong.Text = "Không";
            this.cmdKhong.UseVisualStyleBackColor = true;
            this.cmdKhong.Click += new System.EventHandler(this.cmdKhong_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(424, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 34);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quản Lý Hàng Hóa";
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(704, 464);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(72, 32);
            this.lbl2.TabIndex = 19;
            this.lbl2.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(704, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nhà cung cấp :";
            // 
            // cbo2
            // 
            this.cbo2.FormattingEnabled = true;
            this.cbo2.Location = new System.Drawing.Point(872, 88);
            this.cbo2.Name = "cbo2";
            this.cbo2.Size = new System.Drawing.Size(304, 33);
            this.cbo2.TabIndex = 21;
            // 
            // cmdALL
            // 
            this.cmdALL.Location = new System.Drawing.Point(640, 64);
            this.cmdALL.Name = "cmdALL";
            this.cmdALL.Size = new System.Drawing.Size(56, 32);
            this.cmdALL.TabIndex = 22;
            this.cmdALL.Text = "ALL";
            this.cmdALL.UseVisualStyleBackColor = true;
            this.cmdALL.Click += new System.EventHandler(this.cmdALL_Click);
            // 
            // cbo3
            // 
            this.cbo3.FormattingEnabled = true;
            this.cbo3.Location = new System.Drawing.Point(872, 136);
            this.cbo3.Name = "cbo3";
            this.cbo3.Size = new System.Drawing.Size(304, 33);
            this.cbo3.TabIndex = 24;
            this.cbo3.SelectedIndexChanged += new System.EventHandler(this.cbo3_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(704, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Nhóm hàng :";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(872, 256);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(304, 32);
            this.txtGiaNhap.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(704, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Gía nhập: ";
            // 
            // QLHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 508);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbo3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdALL);
            this.Controls.Add(this.cbo2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdKhong);
            this.Controls.Add(this.cmdLuu);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdSua);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.txtTonKho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgHH);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QLHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hàng Hóa";
            this.Load += new System.EventHandler(this.QLHH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgHH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdLuu;
        private System.Windows.Forms.Button cmdKhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo2;
        private System.Windows.Forms.Button cmdALL;
        private System.Windows.Forms.ComboBox cbo3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label9;
    }
}