namespace QLSTMINI
{
    partial class TLTK
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
            this.dgTK = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTDN = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdLuu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTK)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTK
            // 
            this.dgTK.AllowUserToAddRows = false;
            this.dgTK.AllowUserToDeleteRows = false;
            this.dgTK.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgTK.Location = new System.Drawing.Point(8, 16);
            this.dgTK.Name = "dgTK";
            this.dgTK.ReadOnly = true;
            this.dgTK.RowTemplate.Height = 24;
            this.dgTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTK.Size = new System.Drawing.Size(568, 128);
            this.dgTK.TabIndex = 0;
            this.dgTK.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgTK_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TaiKhoan";
            this.Column1.HeaderText = "Tên đăng nhập";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MatKhau";
            this.Column2.HeaderText = "Mật khẩu";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 220;
            // 
            // lb1
            // 
            this.lb1.Location = new System.Drawing.Point(8, 152);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(568, 32);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Trần Duy Hải";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập :";
            // 
            // txtTDN
            // 
            this.txtTDN.Location = new System.Drawing.Point(200, 192);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.ReadOnly = true;
            this.txtTDN.Size = new System.Drawing.Size(360, 32);
            this.txtTDN.TabIndex = 3;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(200, 232);
            this.txtMK.MaxLength = 10;
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(360, 32);
            this.txtMK.TabIndex = 5;
            this.txtMK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMK_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu : ";
            // 
            // cmdLuu
            // 
            this.cmdLuu.Location = new System.Drawing.Point(200, 272);
            this.cmdLuu.Name = "cmdLuu";
            this.cmdLuu.Size = new System.Drawing.Size(176, 56);
            this.cmdLuu.TabIndex = 7;
            this.cmdLuu.Text = "Lưu";
            this.cmdLuu.UseVisualStyleBackColor = true;
            this.cmdLuu.Click += new System.EventHandler(this.cmdLuu_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(384, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 56);
            this.button3.TabIndex = 8;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Đổi mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmdLuu);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTDN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.dgTK);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TLTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập tài khoản";
            this.Load += new System.EventHandler(this.TLTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTK;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdLuu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}