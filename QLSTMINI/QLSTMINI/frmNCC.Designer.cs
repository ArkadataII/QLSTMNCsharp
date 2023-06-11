
namespace QLSTMINI
{
    partial class frmNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNCC));
            this.label1 = new System.Windows.Forms.Label();
            this.dgDanhMuc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtSdtNCC = new System.Windows.Forms.TextBox();
            this.txtDiaChiNCC = new System.Windows.Forms.TextBox();
            this.cmdThem = new System.Windows.Forms.Button();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdGhi = new System.Windows.Forms.Button();
            this.cmdKhong = new System.Windows.Forms.Button();
            this.cmdKetThuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            // 
            // dgDanhMuc
            // 
            this.dgDanhMuc.AllowUserToAddRows = false;
            this.dgDanhMuc.AllowUserToDeleteRows = false;
            this.dgDanhMuc.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgDanhMuc.Location = new System.Drawing.Point(8, 64);
            this.dgDanhMuc.Name = "dgDanhMuc";
            this.dgDanhMuc.ReadOnly = true;
            this.dgDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDanhMuc.Size = new System.Drawing.Size(1064, 320);
            this.dgDanhMuc.TabIndex = 1;
            this.dgDanhMuc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDanhMuc_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNCC";
            this.Column1.HeaderText = "Mã NCC";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNCC";
            this.Column2.HeaderText = "Tên Nhà Cung Cấp";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 310;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiaChiNCC";
            this.Column3.HeaderText = "Địa Chỉ Nhà Cung Cấp";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 420;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SdtNCC";
            this.Column4.HeaderText = "SĐT Nhà Cung Cấp";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 190;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã NCC :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên NCC :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa Chỉ NCC :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số ĐT NCC :";
            // 
            // lblThongBao
            // 
            this.lblThongBao.Location = new System.Drawing.Point(792, 392);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(266, 18);
            this.lblThongBao.TabIndex = 6;
            this.lblThongBao.Text = ".";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(144, 424);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(112, 32);
            this.txtMaNCC.TabIndex = 7;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(144, 464);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(304, 32);
            this.txtTenNCC.TabIndex = 8;
            // 
            // txtSdtNCC
            // 
            this.txtSdtNCC.Location = new System.Drawing.Point(624, 424);
            this.txtSdtNCC.Name = "txtSdtNCC";
            this.txtSdtNCC.Size = new System.Drawing.Size(216, 32);
            this.txtSdtNCC.TabIndex = 9;
            // 
            // txtDiaChiNCC
            // 
            this.txtDiaChiNCC.Location = new System.Drawing.Point(624, 464);
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.Size = new System.Drawing.Size(448, 32);
            this.txtDiaChiNCC.TabIndex = 10;
            // 
            // cmdThem
            // 
            this.cmdThem.Image = ((System.Drawing.Image)(resources.GetObject("cmdThem.Image")));
            this.cmdThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdThem.Location = new System.Drawing.Point(32, 544);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(128, 48);
            this.cmdThem.TabIndex = 11;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.Image = ((System.Drawing.Image)(resources.GetObject("cmdSua.Image")));
            this.cmdSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSua.Location = new System.Drawing.Point(208, 544);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(128, 48);
            this.cmdSua.TabIndex = 12;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Image = ((System.Drawing.Image)(resources.GetObject("cmdXoa.Image")));
            this.cmdXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdXoa.Location = new System.Drawing.Point(384, 544);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(128, 48);
            this.cmdXoa.TabIndex = 13;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdGhi
            // 
            this.cmdGhi.Image = ((System.Drawing.Image)(resources.GetObject("cmdGhi.Image")));
            this.cmdGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGhi.Location = new System.Drawing.Point(560, 544);
            this.cmdGhi.Name = "cmdGhi";
            this.cmdGhi.Size = new System.Drawing.Size(128, 48);
            this.cmdGhi.TabIndex = 14;
            this.cmdGhi.Text = "Lưu";
            this.cmdGhi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGhi.UseVisualStyleBackColor = true;
            this.cmdGhi.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // cmdKhong
            // 
            this.cmdKhong.Image = ((System.Drawing.Image)(resources.GetObject("cmdKhong.Image")));
            this.cmdKhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdKhong.Location = new System.Drawing.Point(736, 544);
            this.cmdKhong.Name = "cmdKhong";
            this.cmdKhong.Size = new System.Drawing.Size(128, 48);
            this.cmdKhong.TabIndex = 15;
            this.cmdKhong.Text = "Không";
            this.cmdKhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdKhong.UseVisualStyleBackColor = true;
            this.cmdKhong.Click += new System.EventHandler(this.cmdKhong_Click);
            // 
            // cmdKetThuc
            // 
            this.cmdKetThuc.Image = ((System.Drawing.Image)(resources.GetObject("cmdKetThuc.Image")));
            this.cmdKetThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdKetThuc.Location = new System.Drawing.Point(920, 544);
            this.cmdKetThuc.Name = "cmdKetThuc";
            this.cmdKetThuc.Size = new System.Drawing.Size(136, 48);
            this.cmdKetThuc.TabIndex = 16;
            this.cmdKetThuc.Text = "Kết Thúc";
            this.cmdKetThuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdKetThuc.UseVisualStyleBackColor = true;
            this.cmdKetThuc.Click += new System.EventHandler(this.cmdKetThuc_Click);
            // 
            // frmNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 623);
            this.Controls.Add(this.cmdKetThuc);
            this.Controls.Add(this.cmdKhong);
            this.Controls.Add(this.cmdGhi);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdSua);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.txtDiaChiNCC);
            this.Controls.Add(this.txtSdtNCC);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgDanhMuc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDanhMuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtSdtNCC;
        private System.Windows.Forms.TextBox txtDiaChiNCC;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdGhi;
        private System.Windows.Forms.Button cmdKhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button cmdKetThuc;
    }
}

