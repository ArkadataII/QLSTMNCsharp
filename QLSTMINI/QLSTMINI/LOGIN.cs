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
    public partial class LOGIN : Form
    {
        SqlConnection conn;
        DataTable dt;
        string sql;
        public LOGIN()
        {
            InitializeComponent();
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdDangNhap_Click(object sender, EventArgs e)
        {
            string un = comboBox1.Text;
            string pw = txtMK.Text;
            sql = "select * from login where taikhoan='"+ un +"' and matkhau='"+ pw +"'";
            dt = KetNoi.getData(sql);
            if (dt.Rows.Count > 0)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        frmChitietpieuxuat frm1 = new frmChitietpieuxuat();
                        frm1.Show(); this.Hide();
                        return;
                    case 1:
                        NhanVienNhap frm = new NhanVienNhap();
                        frm.Show(); this.Hide();
                        return;
                    case 2:
                        Manager frm2 = new Manager();
                        frm2.Show(); this.Hide();
                        return;

                }
            }
            else
                MessageBox.Show("Mật khẩu không chính xác!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
            comboBox1.SelectedIndex = 0;
        }

        private void txtMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void LOGIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMK.Text = "";
        }
    }
}
