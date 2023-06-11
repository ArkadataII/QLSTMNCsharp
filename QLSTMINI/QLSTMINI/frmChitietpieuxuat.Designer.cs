namespace QLSTMINI
{
    partial class frmChitietpieuxuat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMahoadon = new System.Windows.Forms.TextBox();
            this.cmdIn = new System.Windows.Forms.Button();
            this.dgHangHoa = new System.Windows.Forms.DataGridView();
            this.txtTimhang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayxuat = new System.Windows.Forms.DateTimePicker();
            this.cmdThanhtoan = new System.Windows.Forms.Button();
            this.txtTienkhach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTienthua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdLuu = new System.Windows.Forms.Button();
            this.txtTongthanhtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdXoatrang = new System.Windows.Forms.Button();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chkHienToanBo = new System.Windows.Forms.CheckBox();
            this.cmdThem = new System.Windows.Forms.Button();
            this.dgPhieuxuat = new System.Windows.Forms.DataGridView();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieuxuat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(704, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Tiết Hóa Đơn Xuất ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1048, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hóa Đơn :";
            // 
            // txtMahoadon
            // 
            this.txtMahoadon.Location = new System.Drawing.Point(1201, 44);
            this.txtMahoadon.Name = "txtMahoadon";
            this.txtMahoadon.ReadOnly = true;
            this.txtMahoadon.Size = new System.Drawing.Size(157, 32);
            this.txtMahoadon.TabIndex = 2;
            // 
            // cmdIn
            // 
            this.cmdIn.Location = new System.Drawing.Point(1466, 733);
            this.cmdIn.Name = "cmdIn";
            this.cmdIn.Size = new System.Drawing.Size(112, 63);
            this.cmdIn.TabIndex = 7;
            this.cmdIn.Text = "In H.Đơn";
            this.cmdIn.UseVisualStyleBackColor = true;
            // 
            // dgHangHoa
            // 
            this.dgHangHoa.AllowUserToAddRows = false;
            this.dgHangHoa.AllowUserToDeleteRows = false;
            this.dgHangHoa.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3});
            this.dgHangHoa.Location = new System.Drawing.Point(16, 96);
            this.dgHangHoa.Name = "dgHangHoa";
            this.dgHangHoa.ReadOnly = true;
            this.dgHangHoa.RowHeadersWidth = 51;
            this.dgHangHoa.RowTemplate.Height = 24;
            this.dgHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHangHoa.Size = new System.Drawing.Size(664, 306);
            this.dgHangHoa.TabIndex = 11;
            this.dgHangHoa.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgHangHoa_CellMouseClick);
            // 
            // txtTimhang
            // 
            this.txtTimhang.Location = new System.Drawing.Point(160, 48);
            this.txtTimhang.Name = "txtTimhang";
            this.txtTimhang.Size = new System.Drawing.Size(384, 32);
            this.txtTimhang.TabIndex = 52;
            this.txtTimhang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimhang_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tìm Hàng :";
            // 
            // dtpNgayxuat
            // 
            this.dtpNgayxuat.Enabled = false;
            this.dtpNgayxuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayxuat.Location = new System.Drawing.Point(1201, 6);
            this.dtpNgayxuat.Name = "dtpNgayxuat";
            this.dtpNgayxuat.Size = new System.Drawing.Size(157, 32);
            this.dtpNgayxuat.TabIndex = 15;
            // 
            // cmdThanhtoan
            // 
            this.cmdThanhtoan.Location = new System.Drawing.Point(1008, 568);
            this.cmdThanhtoan.Name = "cmdThanhtoan";
            this.cmdThanhtoan.Size = new System.Drawing.Size(158, 55);
            this.cmdThanhtoan.TabIndex = 16;
            this.cmdThanhtoan.Text = "Thanh Toán";
            this.cmdThanhtoan.UseVisualStyleBackColor = true;
            this.cmdThanhtoan.Click += new System.EventHandler(this.cmdThanhtoan_Click);
            // 
            // txtTienkhach
            // 
            this.txtTienkhach.Location = new System.Drawing.Point(912, 464);
            this.txtTienkhach.Name = "txtTienkhach";
            this.txtTienkhach.Size = new System.Drawing.Size(456, 32);
            this.txtTienkhach.TabIndex = 22;
            this.txtTienkhach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienkhach_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(704, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tiền Khách Đưa :";
            // 
            // txtTienthua
            // 
            this.txtTienthua.Location = new System.Drawing.Point(912, 512);
            this.txtTienthua.Name = "txtTienthua";
            this.txtTienthua.ReadOnly = true;
            this.txtTienthua.Size = new System.Drawing.Size(456, 32);
            this.txtTienthua.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(704, 520);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tiền Trả Lại Khách :";
            // 
            // cmdSua
            // 
            this.cmdSua.Location = new System.Drawing.Point(336, 568);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(158, 55);
            this.cmdSua.TabIndex = 29;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Location = new System.Drawing.Point(520, 568);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(158, 55);
            this.cmdXoa.TabIndex = 30;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdLuu
            // 
            this.cmdLuu.Location = new System.Drawing.Point(1208, 568);
            this.cmdLuu.Name = "cmdLuu";
            this.cmdLuu.Size = new System.Drawing.Size(158, 55);
            this.cmdLuu.TabIndex = 31;
            this.cmdLuu.Text = "Lưu H.Đơn";
            this.cmdLuu.UseVisualStyleBackColor = true;
            this.cmdLuu.Click += new System.EventHandler(this.cmdLuu_Click);
            // 
            // txtTongthanhtien
            // 
            this.txtTongthanhtien.Location = new System.Drawing.Point(912, 416);
            this.txtTongthanhtien.Name = "txtTongthanhtien";
            this.txtTongthanhtien.ReadOnly = true;
            this.txtTongthanhtien.Size = new System.Drawing.Size(456, 32);
            this.txtTongthanhtien.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(704, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Tổng Thành Tiền :";
            // 
            // cmdXoatrang
            // 
            this.cmdXoatrang.Location = new System.Drawing.Point(808, 568);
            this.cmdXoatrang.Name = "cmdXoatrang";
            this.cmdXoatrang.Size = new System.Drawing.Size(158, 55);
            this.cmdXoatrang.TabIndex = 35;
            this.cmdXoatrang.Text = "Xóa Trắng";
            this.cmdXoatrang.UseVisualStyleBackColor = true;
            this.cmdXoatrang.Click += new System.EventHandler(this.cmdXoatrang_Click);
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(144, 416);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.ReadOnly = true;
            this.txtTenhang.Size = new System.Drawing.Size(536, 32);
            this.txtTenhang.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 424);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Tên Hàng : ";
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(144, 464);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.ReadOnly = true;
            this.txtDongia.Size = new System.Drawing.Size(536, 32);
            this.txtDongia.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 472);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 25);
            this.label12.TabIndex = 38;
            this.label12.Text = "Đơn Giá :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 520);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 25);
            this.label13.TabIndex = 40;
            this.label13.Text = "Số Lượng : ";
            // 
            // chkHienToanBo
            // 
            this.chkHienToanBo.AutoSize = true;
            this.chkHienToanBo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkHienToanBo.Location = new System.Drawing.Point(560, 56);
            this.chkHienToanBo.Name = "chkHienToanBo";
            this.chkHienToanBo.Size = new System.Drawing.Size(122, 21);
            this.chkHienToanBo.TabIndex = 45;
            this.chkHienToanBo.Text = "Hiện Toàn Bộ";
            this.chkHienToanBo.UseVisualStyleBackColor = true;
            this.chkHienToanBo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(144, 568);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(158, 55);
            this.cmdThem.TabIndex = 47;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // dgPhieuxuat
            // 
            this.dgPhieuxuat.AllowUserToAddRows = false;
            this.dgPhieuxuat.AllowUserToDeleteRows = false;
            this.dgPhieuxuat.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgPhieuxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPhieuxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column7});
            this.dgPhieuxuat.Location = new System.Drawing.Point(704, 96);
            this.dgPhieuxuat.Name = "dgPhieuxuat";
            this.dgPhieuxuat.RowHeadersWidth = 51;
            this.dgPhieuxuat.RowTemplate.Height = 24;
            this.dgPhieuxuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPhieuxuat.Size = new System.Drawing.Size(664, 306);
            this.dgPhieuxuat.TabIndex = 48;
            this.dgPhieuxuat.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPhieuxuat_CellMouseClick);
            // 
            // txtMahang
            // 
            this.txtMahang.Location = new System.Drawing.Point(576, 8);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.ReadOnly = true;
            this.txtMahang.Size = new System.Drawing.Size(9, 32);
            this.txtMahang.TabIndex = 50;
            this.txtMahang.Visible = false;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(144, 512);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(536, 32);
            this.txtSoluong.TabIndex = 51;
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluong_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhân Viên :";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(160, 8);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(384, 33);
            this.cboNhanVien.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1048, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "Ngày Xuất :";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHH";
            this.Column1.HeaderText = "Mã Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenHH";
            this.Column2.HeaderText = "Tên Hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GiaXuat";
            this.Column6.HeaderText = "Đơn Giá";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TonKho";
            this.Column3.HeaderText = "Tồn Kho";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Hàng";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TenHH";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên Hàng";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GiaXuat";
            this.dataGridViewTextBoxColumn5.HeaderText = "Đơn Giá";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TonKho";
            this.dataGridViewTextBoxColumn6.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Thành Tiền";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // frmChitietpieuxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 640);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtMahang);
            this.Controls.Add(this.dgPhieuxuat);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.chkHienToanBo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTenhang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmdXoatrang);
            this.Controls.Add(this.txtTongthanhtien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdLuu);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdSua);
            this.Controls.Add(this.txtTienthua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTienkhach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmdThanhtoan);
            this.Controls.Add(this.dtpNgayxuat);
            this.Controls.Add(this.txtTimhang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgHangHoa);
            this.Controls.Add(this.cboNhanVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdIn);
            this.Controls.Add(this.txtMahoadon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmChitietpieuxuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Phiếu Xuất ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChitietpieuxuat_FormClosed);
            this.Load += new System.EventHandler(this.frmChitietpieuxuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieuxuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMahoadon;
        private System.Windows.Forms.Button cmdIn;
        private System.Windows.Forms.DataGridView dgHangHoa;
        private System.Windows.Forms.TextBox txtTimhang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayxuat;
        private System.Windows.Forms.Button cmdThanhtoan;
        private System.Windows.Forms.TextBox txtTienkhach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTienthua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdLuu;
        private System.Windows.Forms.TextBox txtTongthanhtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdXoatrang;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkHienToanBo;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.DataGridView dgPhieuxuat;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}