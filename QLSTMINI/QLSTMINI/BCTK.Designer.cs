namespace QLSTMINI
{
    partial class BCTK
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgNhap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgXuat = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtt1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtt2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdThongKe = new System.Windows.Forms.Button();
            this.lblTongNhap = new System.Windows.Forms.Label();
            this.lblTongXuat = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.cmdALL = new System.Windows.Forms.Button();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo2 = new System.Windows.Forms.ComboBox();
            this.cmdXuat = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgXuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgNhap
            // 
            this.dgNhap.AllowUserToAddRows = false;
            this.dgNhap.AllowUserToDeleteRows = false;
            this.dgNhap.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgNhap.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgNhap.Location = new System.Drawing.Point(8, 312);
            this.dgNhap.Name = "dgNhap";
            this.dgNhap.ReadOnly = true;
            this.dgNhap.RowTemplate.Height = 24;
            this.dgNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNhap.Size = new System.Drawing.Size(712, 296);
            this.dgNhap.TabIndex = 0;
            this.dgNhap.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgNhap_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNhap";
            this.Column1.HeaderText = "Mã nhập";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaNCC";
            this.Column2.HeaderText = "Mã NCC";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaNV";
            this.Column3.HeaderText = "Mã NV";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayNhap";
            dataGridViewCellStyle13.Format = "dd/MM/yyyy";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column4.HeaderText = "Ngày nhập";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TongTien";
            dataGridViewCellStyle14.Format = "#,##0";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column5.HeaderText = "Tổng tiền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // dgXuat
            // 
            this.dgXuat.AllowUserToAddRows = false;
            this.dgXuat.AllowUserToDeleteRows = false;
            this.dgXuat.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgXuat.Location = new System.Drawing.Point(744, 312);
            this.dgXuat.Name = "dgXuat";
            this.dgXuat.ReadOnly = true;
            this.dgXuat.RowTemplate.Height = 24;
            this.dgXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgXuat.Size = new System.Drawing.Size(712, 296);
            this.dgXuat.TabIndex = 1;
            this.dgXuat.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgXuat_CellMouseDoubleClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaXuat";
            this.Column6.HeaderText = "Mã xuất";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 160;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaNV";
            this.Column7.HeaderText = "Mã NV";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 160;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NgayXuat";
            dataGridViewCellStyle15.Format = "dd/MM/yyyy";
            this.Column8.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column8.HeaderText = "Ngày Xuất";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 170;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TongTien";
            dataGridViewCellStyle16.Format = "#,##0";
            this.Column9.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column9.HeaderText = "Tổng tiền";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 170;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(728, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 344);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1448, 8);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập hàng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(744, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Xuất hàng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtt1
            // 
            this.dtt1.CustomFormat = "dd/MM/yyyy";
            this.dtt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtt1.Location = new System.Drawing.Point(8, 24);
            this.dtt1.Name = "dtt1";
            this.dtt1.Size = new System.Drawing.Size(184, 32);
            this.dtt1.TabIndex = 6;
            this.dtt1.Value = new System.DateTime(2022, 4, 23, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtt1);
            this.groupBox1.Location = new System.Drawing.Point(216, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 56);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bắt đầu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtt2);
            this.groupBox2.Location = new System.Drawing.Point(424, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 56);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết thúc";
            // 
            // dtt2
            // 
            this.dtt2.CustomFormat = "dd/MM/yyyy";
            this.dtt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtt2.Location = new System.Drawing.Point(8, 24);
            this.dtt2.Name = "dtt2";
            this.dtt2.Size = new System.Drawing.Size(184, 32);
            this.dtt2.TabIndex = 6;
            this.dtt2.Value = new System.DateTime(2022, 4, 23, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(528, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(546, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "BÁO CÁO THỐNG KÊ ĐƠN HÀNG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(688, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "3HD - MART";
            // 
            // cmdThongKe
            // 
            this.cmdThongKe.Location = new System.Drawing.Point(80, 136);
            this.cmdThongKe.Name = "cmdThongKe";
            this.cmdThongKe.Size = new System.Drawing.Size(120, 40);
            this.cmdThongKe.TabIndex = 12;
            this.cmdThongKe.Text = "Thống kê";
            this.cmdThongKe.UseVisualStyleBackColor = true;
            this.cmdThongKe.Click += new System.EventHandler(this.cmdThongKe_Click);
            // 
            // lblTongNhap
            // 
            this.lblTongNhap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTongNhap.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongNhap.ForeColor = System.Drawing.Color.Red;
            this.lblTongNhap.Location = new System.Drawing.Point(488, 272);
            this.lblTongNhap.Name = "lblTongNhap";
            this.lblTongNhap.Size = new System.Drawing.Size(232, 32);
            this.lblTongNhap.TabIndex = 16;
            this.lblTongNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongXuat
            // 
            this.lblTongXuat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTongXuat.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongXuat.ForeColor = System.Drawing.Color.Red;
            this.lblTongXuat.Location = new System.Drawing.Point(1224, 272);
            this.lblTongXuat.Name = "lblTongXuat";
            this.lblTongXuat.Size = new System.Drawing.Size(232, 32);
            this.lblTongXuat.TabIndex = 17;
            this.lblTongXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(344, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tổng nhập: ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label.Location = new System.Drawing.Point(1080, 272);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(144, 32);
            this.label.TabIndex = 19;
            this.label.Text = "Tổng xuất: ";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdALL
            // 
            this.cmdALL.Location = new System.Drawing.Point(16, 136);
            this.cmdALL.Name = "cmdALL";
            this.cmdALL.Size = new System.Drawing.Size(56, 40);
            this.cmdALL.TabIndex = 20;
            this.cmdALL.Text = "ALL";
            this.cmdALL.UseVisualStyleBackColor = true;
            this.cmdALL.Click += new System.EventHandler(this.cmdALL_Click);
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(200, 208);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(240, 33);
            this.cboNhanVien.TabIndex = 21;
            this.cboNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboNhanVien_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nhân viên nhập: ";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(8, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1448, 8);
            this.label8.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(752, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Nhân viên xuất: ";
            // 
            // cbo2
            // 
            this.cbo2.FormattingEnabled = true;
            this.cbo2.Location = new System.Drawing.Point(936, 208);
            this.cbo2.Name = "cbo2";
            this.cbo2.Size = new System.Drawing.Size(240, 33);
            this.cbo2.TabIndex = 24;
            this.cbo2.SelectedIndexChanged += new System.EventHandler(this.cbo2_SelectedIndexChanged);
            // 
            // cmdXuat
            // 
            this.cmdXuat.Location = new System.Drawing.Point(1160, 136);
            this.cmdXuat.Name = "cmdXuat";
            this.cmdXuat.Size = new System.Drawing.Size(184, 40);
            this.cmdXuat.TabIndex = 26;
            this.cmdXuat.Text = "Xuất dữ liệu";
            this.cmdXuat.UseVisualStyleBackColor = true;
            this.cmdXuat.Click += new System.EventHandler(this.cmdXuat_Click);
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(440, 208);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(280, 32);
            this.lbl1.TabIndex = 27;
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(1176, 208);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(280, 32);
            this.lbl2.TabIndex = 28;
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Checked = true;
            this.radio1.Location = new System.Drawing.Point(8, 24);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(85, 29);
            this.radio1.TabIndex = 29;
            this.radio1.TabStop = true;
            this.radio1.Text = "Nhập";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(8, 56);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(80, 29);
            this.radio2.TabIndex = 30;
            this.radio2.TabStop = true;
            this.radio2.Text = "Xuất";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radio2);
            this.groupBox3.Controls.Add(this.radio1);
            this.groupBox3.Location = new System.Drawing.Point(1352, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(104, 88);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // BCTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 617);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cmdXuat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbo2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboNhanVien);
            this.Controls.Add(this.cmdALL);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTongXuat);
            this.Controls.Add(this.lblTongNhap);
            this.Controls.Add(this.cmdThongKe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgXuat);
            this.Controls.Add(this.dgNhap);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BCTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theo đơn hàng";
            this.Load += new System.EventHandler(this.BCTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgXuat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgNhap;
        private System.Windows.Forms.DataGridView dgXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtt1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtt2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdThongKe;
        private System.Windows.Forms.Label lblTongNhap;
        private System.Windows.Forms.Label lblTongXuat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button cmdALL;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbo2;
        private System.Windows.Forms.Button cmdXuat;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}