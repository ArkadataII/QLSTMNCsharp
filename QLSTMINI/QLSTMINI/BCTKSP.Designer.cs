namespace QLSTMINI
{
    partial class BCTKSP
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtt2 = new System.Windows.Forms.DateTimePicker();
            this.dtt1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgNhap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.dgXuat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdXuat = new System.Windows.Forms.Button();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgXuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.SkyBlue;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(8, 321);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Nhập";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(616, 399);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.SkyBlue;
            chartArea2.Name = "ChartArea2";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(632, 320);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea2";
            series2.Legend = "Legend1";
            series2.Name = "Xuất";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(616, 400);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            this.chart2.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // dtt2
            // 
            this.dtt2.CustomFormat = "dd/MM/yyyy";
            this.dtt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtt2.Location = new System.Drawing.Point(296, 128);
            this.dtt2.Name = "dtt2";
            this.dtt2.Size = new System.Drawing.Size(176, 32);
            this.dtt2.TabIndex = 2;
            this.dtt2.Value = new System.DateTime(2022, 4, 23, 0, 0, 0, 0);
            // 
            // dtt1
            // 
            this.dtt1.CustomFormat = "dd/MM/yyyy";
            this.dtt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtt1.Location = new System.Drawing.Point(8, 128);
            this.dtt1.Name = "dtt1";
            this.dtt1.Size = new System.Drawing.Size(176, 32);
            this.dtt1.TabIndex = 3;
            this.dtt1.Value = new System.DateTime(2022, 4, 23, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1240, 9);
            this.label2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(624, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 400);
            this.label1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(511, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "BÁO CÁO THỐNG KÊ SẢN PHẨM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "ALL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "-►";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "3HD-MART";
            // 
            // dgNhap
            // 
            this.dgNhap.AllowUserToAddRows = false;
            this.dgNhap.AllowUserToDeleteRows = false;
            this.dgNhap.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgNhap.Location = new System.Drawing.Point(8, 168);
            this.dgNhap.Name = "dgNhap";
            this.dgNhap.ReadOnly = true;
            this.dgNhap.RowTemplate.Height = 24;
            this.dgNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNhap.Size = new System.Drawing.Size(616, 136);
            this.dgNhap.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenHH";
            this.Column1.HeaderText = "Hàng hóa";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 270;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SoLuong";
            dataGridViewCellStyle1.Format = "#,##0";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Số lượng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 270;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(624, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(8, 136);
            this.label6.TabIndex = 14;
            // 
            // dgXuat
            // 
            this.dgXuat.AllowUserToAddRows = false;
            this.dgXuat.AllowUserToDeleteRows = false;
            this.dgXuat.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgXuat.Location = new System.Drawing.Point(632, 168);
            this.dgXuat.Name = "dgXuat";
            this.dgXuat.ReadOnly = true;
            this.dgXuat.RowTemplate.Height = 24;
            this.dgXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgXuat.Size = new System.Drawing.Size(616, 136);
            this.dgXuat.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenHH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Hàng hóa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 270;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SoLuong";
            dataGridViewCellStyle2.Format = "#,##0";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 270;
            // 
            // cmdXuat
            // 
            this.cmdXuat.Location = new System.Drawing.Point(936, 128);
            this.cmdXuat.Name = "cmdXuat";
            this.cmdXuat.Size = new System.Drawing.Size(200, 32);
            this.cmdXuat.TabIndex = 16;
            this.cmdXuat.Text = "Xuất dữ liệu";
            this.cmdXuat.UseVisualStyleBackColor = true;
            this.cmdXuat.Click += new System.EventHandler(this.cmdXuat_Click);
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Checked = true;
            this.radio1.Location = new System.Drawing.Point(8, 24);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(85, 29);
            this.radio1.TabIndex = 17;
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
            this.radio2.TabIndex = 18;
            this.radio2.TabStop = true;
            this.radio2.Text = "Xuất";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio2);
            this.groupBox1.Controls.Add(this.radio1);
            this.groupBox1.Location = new System.Drawing.Point(1144, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 88);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // BCTKSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 723);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdXuat);
            this.Controls.Add(this.dgXuat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtt1);
            this.Controls.Add(this.dtt2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BCTKSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theo sản phẩm";
            this.Load += new System.EventHandler(this.BCTKSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgXuat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DateTimePicker dtt2;
        private System.Windows.Forms.DateTimePicker dtt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button cmdXuat;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}