using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSTMINI
{
    
    public partial class NhanVienNhap : Form
    {
        SqlConnection conn;
        DataTable dtNV;
        string sql;
        public NhanVienNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "Select * from NhanVien where MaNV = N'" + textBox1.Text + "' and ChucVu = 0";
            dtNV = KetNoi.getData(sql);
            if(dtNV.Rows.Count <= 0)
            {
                MessageBox.Show("Không tồn tại nhân viên nhập hàng trên ","Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            } 
            else
            {
                KetNoi.s = textBox1.Text;
                this.Hide();
                PhieuNhap frm = new PhieuNhap();
                frm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               button1_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
