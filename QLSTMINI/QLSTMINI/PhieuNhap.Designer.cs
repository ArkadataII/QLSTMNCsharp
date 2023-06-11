namespace QLSTMINI
{
    partial class PhieuNhap
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
            this.txtTim = new System.Windows.Forms.TextBox();
            this.chkHienToanBo = new System.Windows.Forms.CheckBox();
            this.dgNhaCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgHangHoa = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNhaCC = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmdThem = new System.Windows.Forms.Button();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdTaoPhieu = new System.Windows.Forms.Button();
            this.cmdKhongGhi = new System.Windows.Forms.Button();
            this.cmdGhi = new System.Windows.Forms.Button();
            this.dgChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.cmdLuuPhieu = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtNguoiLap = new System.Windows.Forms.TextBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtMaNhap = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhaCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(112, 16);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(248, 28);
            this.txtTim.TabIndex = 1;
            this.txtTim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTim_KeyPress);
            // 
            // chkHienToanBo
            // 
            this.chkHienToanBo.AutoSize = true;
            this.chkHienToanBo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkHienToanBo.Location = new System.Drawing.Point(368, 24);
            this.chkHienToanBo.Name = "chkHienToanBo";
            this.chkHienToanBo.Size = new System.Drawing.Size(122, 21);
            this.chkHienToanBo.TabIndex = 2;
            this.chkHienToanBo.Text = "Hiện Toàn Bộ";
            this.chkHienToanBo.UseVisualStyleBackColor = true;
            this.chkHienToanBo.CheckedChanged += new System.EventHandler(this.chkHienToanBo_CheckedChanged);
            // 
            // dgNhaCC
            // 
            this.dgNhaCC.AllowUserToAddRows = false;
            this.dgNhaCC.AllowUserToDeleteRows = false;
            this.dgNhaCC.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNhaCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgNhaCC.Enabled = false;
            this.dgNhaCC.Location = new System.Drawing.Point(24, 64);
            this.dgNhaCC.Name = "dgNhaCC";
            this.dgNhaCC.ReadOnly = true;
            this.dgNhaCC.RowHeadersWidth = 51;
            this.dgNhaCC.RowTemplate.Height = 24;
            this.dgNhaCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNhaCC.Size = new System.Drawing.Size(456, 280);
            this.dgNhaCC.TabIndex = 3;
            this.dgNhaCC.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgNhaCC_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNCC";
            this.Column1.HeaderText = "Mã NCC";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNCC";
            this.Column2.HeaderText = "Tên Nhà Cung Cấp";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SdtNCC";
            this.Column3.HeaderText = "SĐT";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DiaChiNCC";
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 300;
            // 
            // dgHangHoa
            // 
            this.dgHangHoa.AllowUserToAddRows = false;
            this.dgHangHoa.AllowUserToDeleteRows = false;
            this.dgHangHoa.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column12});
            this.dgHangHoa.Location = new System.Drawing.Point(24, 368);
            this.dgHangHoa.Name = "dgHangHoa";
            this.dgHangHoa.ReadOnly = true;
            this.dgHangHoa.RowHeadersWidth = 51;
            this.dgHangHoa.RowTemplate.Height = 24;
            this.dgHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHangHoa.Size = new System.Drawing.Size(456, 280);
            this.dgHangHoa.TabIndex = 5;
            this.dgHangHoa.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgHangHoa_CellMouseClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaHH";
            this.Column5.HeaderText = "Mã Hàng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TenHH";
            this.Column6.HeaderText = "Tên Hàng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 155;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "GiaNhap";
            this.Column12.HeaderText = "Giá Nhập";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(856, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phiếu Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Người Lập :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(960, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày Lập :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhà Cung Cấp :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(928, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số Điện Thoại :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Địa Chỉ :";
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.Location = new System.Drawing.Point(632, 120);
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.ReadOnly = true;
            this.txtNhaCC.Size = new System.Drawing.Size(280, 28);
            this.txtNhaCC.TabIndex = 12;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(1064, 120);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(200, 28);
            this.txtSDT.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(632, 160);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(632, 28);
            this.txtDiaChi.TabIndex = 14;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(632, 256);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.ReadOnly = true;
            this.txtGiaNhap.Size = new System.Drawing.Size(280, 28);
            this.txtGiaNhap.TabIndex = 20;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(1040, 256);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(224, 28);
            this.txtThanhTien.TabIndex = 19;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(632, 216);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.ReadOnly = true;
            this.txtTenHang.Size = new System.Drawing.Size(280, 28);
            this.txtTenHang.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(528, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Giá Nhập :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(936, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Số Lượng :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(528, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tên Hàng :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(920, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Thành Tiền :";
            // 
            // cmdThem
            // 
            this.cmdThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdThem.Location = new System.Drawing.Point(632, 304);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(112, 40);
            this.cmdThem.TabIndex = 25;
            this.cmdThem.Text = "Thêm ";
            this.cmdThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSua.Location = new System.Drawing.Point(760, 304);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(112, 40);
            this.cmdSua.TabIndex = 26;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdXoa.Location = new System.Drawing.Point(888, 304);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(112, 40);
            this.cmdXoa.TabIndex = 27;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdTaoPhieu
            // 
            this.cmdTaoPhieu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmdTaoPhieu.Location = new System.Drawing.Point(520, 664);
            this.cmdTaoPhieu.Name = "cmdTaoPhieu";
            this.cmdTaoPhieu.Size = new System.Drawing.Size(112, 48);
            this.cmdTaoPhieu.TabIndex = 30;
            this.cmdTaoPhieu.Text = "Tạo Phiếu";
            this.cmdTaoPhieu.UseVisualStyleBackColor = true;
            this.cmdTaoPhieu.Click += new System.EventHandler(this.cmdTaoPhieu_Click);
            // 
            // cmdKhongGhi
            // 
            this.cmdKhongGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdKhongGhi.Location = new System.Drawing.Point(1160, 304);
            this.cmdKhongGhi.Name = "cmdKhongGhi";
            this.cmdKhongGhi.Size = new System.Drawing.Size(104, 40);
            this.cmdKhongGhi.TabIndex = 29;
            this.cmdKhongGhi.Text = "Không";
            this.cmdKhongGhi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdKhongGhi.UseVisualStyleBackColor = true;
            this.cmdKhongGhi.Click += new System.EventHandler(this.cmdKhongGhi_Click);
            // 
            // cmdGhi
            // 
            this.cmdGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGhi.Location = new System.Drawing.Point(1040, 304);
            this.cmdGhi.Name = "cmdGhi";
            this.cmdGhi.Size = new System.Drawing.Size(104, 40);
            this.cmdGhi.TabIndex = 28;
            this.cmdGhi.Text = "Ghi";
            this.cmdGhi.UseVisualStyleBackColor = true;
            this.cmdGhi.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // dgChiTietPhieuNhap
            // 
            this.dgChiTietPhieuNhap.AllowUserToAddRows = false;
            this.dgChiTietPhieuNhap.AllowUserToDeleteRows = false;
            this.dgChiTietPhieuNhap.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column9,
            this.Column11});
            this.dgChiTietPhieuNhap.Location = new System.Drawing.Point(520, 368);
            this.dgChiTietPhieuNhap.Name = "dgChiTietPhieuNhap";
            this.dgChiTietPhieuNhap.ReadOnly = true;
            this.dgChiTietPhieuNhap.RowHeadersWidth = 51;
            this.dgChiTietPhieuNhap.RowTemplate.Height = 24;
            this.dgChiTietPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChiTietPhieuNhap.Size = new System.Drawing.Size(744, 280);
            this.dgChiTietPhieuNhap.TabIndex = 31;
            this.dgChiTietPhieuNhap.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgChiTietPhieuNhap_CellMouseClick);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaHH";
            this.Column7.HeaderText = "Mã Hàng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenHH";
            this.Column8.HeaderText = "Tên Hàng";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 255;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "GiaNhap";
            this.Column10.HeaderText = "Giá Nhập";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "SoLuong";
            this.Column9.HeaderText = "Số Lượng";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "ThanhTien";
            this.Column11.HeaderText = "Thành Tiền";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 125;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 680);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Tổng Số Tiền :";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(160, 672);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(320, 28);
            this.txtTongTien.TabIndex = 33;
            // 
            // cmdLuuPhieu
            // 
            this.cmdLuuPhieu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmdLuuPhieu.Location = new System.Drawing.Point(1152, 656);
            this.cmdLuuPhieu.Name = "cmdLuuPhieu";
            this.cmdLuuPhieu.Size = new System.Drawing.Size(112, 48);
            this.cmdLuuPhieu.TabIndex = 34;
            this.cmdLuuPhieu.Text = "Lưu Phiếu";
            this.cmdLuuPhieu.UseVisualStyleBackColor = true;
            this.cmdLuuPhieu.Click += new System.EventHandler(this.cmdLuuPhieu_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(656, 672);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(480, 32);
            this.label13.TabIndex = 35;
            this.label13.Text = "3HD - Hân Hạnh Kính Chào Quý Khách";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tìm :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(1040, 216);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(224, 28);
            this.txtSoLuong.TabIndex = 37;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Location = new System.Drawing.Point(632, 64);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.ReadOnly = true;
            this.txtNguoiLap.Size = new System.Drawing.Size(280, 28);
            this.txtNguoiLap.TabIndex = 39;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd / MM / yyyy";
            this.dtpNgayLap.Enabled = false;
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(1064, 64);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(200, 28);
            this.dtpNgayLap.TabIndex = 40;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(520, 24);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(8, 28);
            this.txtMaNCC.TabIndex = 41;
            this.txtMaNCC.Visible = false;
            // 
            // txtMaNhap
            // 
            this.txtMaNhap.Location = new System.Drawing.Point(1144, 24);
            this.txtMaNhap.Name = "txtMaNhap";
            this.txtMaNhap.Size = new System.Drawing.Size(120, 28);
            this.txtMaNhap.TabIndex = 42;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(504, 24);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(8, 28);
            this.txtMaHang.TabIndex = 43;
            this.txtMaHang.Visible = false;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(552, 24);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(8, 28);
            this.txtMaNV.TabIndex = 44;
            this.txtMaNV.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1064, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 20);
            this.label14.TabIndex = 45;
            this.label14.Text = "Mã Nhập :";
            // 
            // PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 716);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.txtMaNhap);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.txtNguoiLap);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmdLuuPhieu);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgChiTietPhieuNhap);
            this.Controls.Add(this.cmdTaoPhieu);
            this.Controls.Add(this.cmdKhongGhi);
            this.Controls.Add(this.cmdGhi);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdSua);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtNhaCC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgHangHoa);
            this.Controls.Add(this.dgNhaCC);
            this.Controls.Add(this.chkHienToanBo);
            this.Controls.Add(this.txtTim);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhieuNhap_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PhieuNhap_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNhaCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.CheckBox chkHienToanBo;
        private System.Windows.Forms.DataGridView dgNhaCC;
        private System.Windows.Forms.DataGridView dgHangHoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNhaCC;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdTaoPhieu;
        private System.Windows.Forms.Button cmdKhongGhi;
        private System.Windows.Forms.Button cmdGhi;
        private System.Windows.Forms.DataGridView dgChiTietPhieuNhap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button cmdLuuPhieu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtNguoiLap;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtMaNhap;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}

