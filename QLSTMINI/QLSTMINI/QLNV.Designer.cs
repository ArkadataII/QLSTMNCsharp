namespace QLSTMINI
{
    partial class QLNV
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
            this.dgNV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.opt3 = new System.Windows.Forms.RadioButton();
            this.opt4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.cmdThem = new System.Windows.Forms.Button();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdLuu = new System.Windows.Forms.Button();
            this.cmdKhong = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCV = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdALL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgNV
            // 
            this.dgNV.AllowUserToAddRows = false;
            this.dgNV.AllowUserToDeleteRows = false;
            this.dgNV.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6,
            this.Column7});
            this.dgNV.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgNV.Location = new System.Drawing.Point(8, 96);
            this.dgNV.Name = "dgNV";
            this.dgNV.ReadOnly = true;
            this.dgNV.RowHeadersWidth = 51;
            this.dgNV.RowTemplate.Height = 24;
            this.dgNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNV.Size = new System.Drawing.Size(1136, 328);
            this.dgNV.TabIndex = 0;
            this.dgNV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgNV_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNV";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 165;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ChucVu";
            this.Column3.HeaderText = "Chức vụ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NamSinh";
            this.Column5.HeaderText = "Năm sinh";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 140;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GioiTinh";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SdtNV";
            this.Column6.HeaderText = "Số điện thoại";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 175;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DiaChiNV";
            this.Column7.HeaderText = "Địa chỉ";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã NV : ";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(152, 440);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(240, 32);
            this.txtMaNV.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(152, 488);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(240, 32);
            this.txtHoTen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên :";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Location = new System.Drawing.Point(568, 488);
            this.txtNamSinh.MaxLength = 4;
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(216, 32);
            this.txtNamSinh.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Năm sinh :";
            // 
            // opt3
            // 
            this.opt3.AutoSize = true;
            this.opt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opt3.Location = new System.Drawing.Point(8, 32);
            this.opt3.Name = "opt3";
            this.opt3.Size = new System.Drawing.Size(78, 29);
            this.opt3.TabIndex = 0;
            this.opt3.Text = "Nam";
            this.opt3.UseVisualStyleBackColor = true;
            // 
            // opt4
            // 
            this.opt4.AutoSize = true;
            this.opt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opt4.Location = new System.Drawing.Point(112, 32);
            this.opt4.Name = "opt4";
            this.opt4.Size = new System.Drawing.Size(60, 29);
            this.opt4.TabIndex = 1;
            this.opt4.Text = "Nữ";
            this.opt4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opt4);
            this.groupBox1.Controls.Add(this.opt3);
            this.groupBox1.Location = new System.Drawing.Point(800, 512);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 64);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.opt2);
            this.groupBox2.Controls.Add(this.opt1);
            this.groupBox2.Location = new System.Drawing.Point(800, 432);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 64);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức vụ";
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opt2.Location = new System.Drawing.Point(112, 32);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(121, 29);
            this.opt2.TabIndex = 1;
            this.opt2.Text = "Importer";
            this.opt2.UseVisualStyleBackColor = true;
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opt1.Location = new System.Drawing.Point(8, 32);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(91, 29);
            this.opt1.TabIndex = 0;
            this.opt1.Text = "Seller";
            this.opt1.UseVisualStyleBackColor = true;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(568, 536);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(216, 32);
            this.txtSdt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sđt: ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(152, 536);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(240, 32);
            this.txtDiaChi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ : ";
            // 
            // lbSL
            // 
            this.lbSL.Location = new System.Drawing.Point(440, 440);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(344, 32);
            this.lbSL.TabIndex = 19;
            this.lbSL.Text = "Trần Duy Hải";
            this.lbSL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(32, 600);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(144, 48);
            this.cmdThem.TabIndex = 13;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.Location = new System.Drawing.Point(200, 600);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(144, 48);
            this.cmdSua.TabIndex = 14;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Location = new System.Drawing.Point(368, 600);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(144, 48);
            this.cmdXoa.TabIndex = 15;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdLuu
            // 
            this.cmdLuu.Location = new System.Drawing.Point(536, 600);
            this.cmdLuu.Name = "cmdLuu";
            this.cmdLuu.Size = new System.Drawing.Size(144, 48);
            this.cmdLuu.TabIndex = 16;
            this.cmdLuu.Text = "Lưu";
            this.cmdLuu.UseVisualStyleBackColor = true;
            this.cmdLuu.Click += new System.EventHandler(this.cmdLuu_Click);
            // 
            // cmdKhong
            // 
            this.cmdKhong.Location = new System.Drawing.Point(704, 600);
            this.cmdKhong.Name = "cmdKhong";
            this.cmdKhong.Size = new System.Drawing.Size(144, 48);
            this.cmdKhong.TabIndex = 17;
            this.cmdKhong.Text = "Không";
            this.cmdKhong.UseVisualStyleBackColor = true;
            this.cmdKhong.Click += new System.EventHandler(this.cmdKhong_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(872, 600);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 48);
            this.button6.TabIndex = 18;
            this.button6.Text = "Thoát";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(367, 36);
            this.label6.TabIndex = 20;
            this.label6.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // cboCV
            // 
            this.cboCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCV.FormattingEnabled = true;
            this.cboCV.Items.AddRange(new object[] {
            "Importer",
            "Seller"});
            this.cboCV.Location = new System.Drawing.Point(128, 48);
            this.cboCV.Name = "cboCV";
            this.cboCV.Size = new System.Drawing.Size(192, 33);
            this.cboCV.TabIndex = 21;
            this.cboCV.SelectedIndexChanged += new System.EventHandler(this.cboCV_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Chức vụ: ";
            // 
            // cmdALL
            // 
            this.cmdALL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdALL.Location = new System.Drawing.Point(976, 48);
            this.cmdALL.Name = "cmdALL";
            this.cmdALL.Size = new System.Drawing.Size(72, 32);
            this.cmdALL.TabIndex = 23;
            this.cmdALL.Text = "ALL";
            this.cmdALL.UseVisualStyleBackColor = true;
            this.cmdALL.Click += new System.EventHandler(this.cmdALL_Click);
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 674);
            this.Controls.Add(this.cmdALL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboCV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.cmdKhong);
            this.Controls.Add(this.cmdLuu);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdSua);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNamSinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgNV);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QLNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.QLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton opt3;
        private System.Windows.Forms.RadioButton opt4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdLuu;
        private System.Windows.Forms.Button cmdKhong;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdALL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}