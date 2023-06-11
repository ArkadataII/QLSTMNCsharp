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
    public partial class TLTK : Form
    {
        SqlConnection conn;
        SqlDataAdapter daTK;
        DataTable dtTK;
        string sql = "";
        DataGridViewCellMouseEventArgs vt;
        string mkcu = "";

        public TLTK()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void laynguonTK()
        {
            sql = "Select * From Login";
            daTK = new SqlDataAdapter(sql, conn);
            dtTK = new DataTable();
            daTK.Fill(dtTK);
            dgTK.DataSource = dtTK;
            lb1.Text = "CHỈ CÓ " + dgTK.RowCount.ToString() + " TÀI KHOẢN";

        }

        private void TLTK_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
            laynguonTK();
            KhoaMo(true);
        }

        private void dgTK_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgTK.RowCount > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        KhoaMo(true);
                        vt = e;
                        DataGridViewRow row = dgTK.Rows[e.RowIndex];
                        txtTDN.Text = row.Cells[0].Value.ToString();
                        txtMK.Text = row.Cells[1].Value.ToString();
                        if (txtTDN.Text.Equals("Seller") == true) lb1.Text = "BÁN HÀNG";
                        if (txtTDN.Text.Equals("Importer") == true) lb1.Text = "NHẬP HÀNG";
                        if (txtTDN.Text.Equals("Manager") == true) lb1.Text = "QUẢN LÝ";
                        mkcu = txtMK.Text;
                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi: " + ev.Message, "Thông báo"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void KhoaMo(bool b)
        {
            txtMK.ReadOnly = b;
            cmdLuu.Enabled = !b;
            button1.Enabled = b;
        }

        public void XoaTrang()
        {
            txtTDN.Text = "";
            txtMK.Text = "";
            lb1.Text = "CHỈ CÓ " + dgTK.RowCount.ToString() + " TÀI KHOẢN";
        }

        private void cmdLuu_Click(object sender, EventArgs e)
        {
            if (txtMK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Mật Khẩu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTDN.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn thay đổi mật khẩu không ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtMK.Text != mkcu)
                {
                    sql = "Update Login set MatKhau = '" + txtMK.Text + "' Where TaiKhoan= N'" + txtTDN.Text + "'";
                    if (conn.State != ConnectionState.Open) conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    laynguonTK();
                    if (txtTDN.Text == "Manager") Application.Exit();
                    XoaTrang();
                }
                else dgTK_CellMouseClick(sender, vt);
            }
            else dgTK_CellMouseClick(sender, vt);
        }

        private void txtMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTDN.Text == "") return;
            KhoaMo(false);
            txtMK.Focus();
        }
    }
}
