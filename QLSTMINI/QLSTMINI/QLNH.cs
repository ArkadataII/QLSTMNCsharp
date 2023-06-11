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
    public partial class QLNH : Form
    {
        SqlConnection conn;
        SqlDataAdapter daNhomHang,da;
        DataTable dtNhomHang,dt;
        string sql = "";
        string sDK = "";
        DataGridViewCellMouseEventArgs vt;
        bool ktThem = true;
        string macu;
        public QLNH()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtMaNH.Text == "") return;
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa nhóm hàng " + txtTenNH.Text + " không?","Thông Báo",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(kq == DialogResult.Yes)
            {
                sql = "Delete from nhomhang where MaNH = N'" + txtMaNH.Text + "'";
                sql = "Delete from hanghoa where MaNH = N'" + txtMaNH.Text + "'";
                LayNguonNH();
                //sql = "Delete from hanghoa where exists (Select * from nhomhang where nhomhang.MaNH = hanghoa.MaNH)";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                xoatrang();
                LayNguonNH();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                xoatrang();
                KhoaMo(true);
                dgDanhMuc_CellMouseClick(sender, vt);
            }catch (Exception ev) { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QLNH_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
            KhoaMo(true);
            LayNguonNH();
        }

        public void KhoaMo(bool b)
        {
            dgDanhMuc.Enabled = b;
            txtTenNH.ReadOnly = b;
            cmdThem.Enabled = b;
            cmdSua.Enabled = b;
            cmdXoa.Enabled = b;

            cmdLuu.Enabled = !b;
            cmdKhong.Enabled = !b;
        }

        public void LayNguonNH()
        {
            sql = "Select * from nhomhang";
            daNhomHang = new SqlDataAdapter(sql, conn);
            dtNhomHang = new DataTable();
            daNhomHang.Fill(dtNhomHang);

            dgDanhMuc.DataSource = dtNhomHang;
            lblThongBao.Text = "Có " + dgDanhMuc.RowCount + " nhóm hàng.";
        }

        private void dgDanhMuc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if(dgDanhMuc.RowCount > 0)
                {
                    if(e.RowIndex >= 0)
                    {
                        vt = e;
                        DataGridViewRow row = dgDanhMuc.Rows[e.RowIndex];
                        txtMaNH.Text = row.Cells[0].Value.ToString();
                        txtTenNH.Text = row.Cells[1].Value.ToString();
                    }
                }
            }catch (Exception ev)
            { }
        }

        public void xoatrang()
        {
            txtMaNH.Text = "";
            txtTenNH.Text = "";
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            xoatrang();
            txtMaNH.Text = KetNoi.TuTaoMa("NhomHang", txtMaNH.Text, "NH");
            ktThem = true;
            KhoaMo(false);
            txtTenNH.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaNH.Text == "") return;
            macu = txtMaNH.Text;
            ktThem = false;
            KhoaMo(false);
        }

        private void cmdLuu_Click(object sender, EventArgs e)
        {
            if(txtMaNH.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhóm hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaNH.Focus();
                return;
            }
            if (txtTenNH.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhóm hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenNH.Focus();
                return;
            }
            if(ktThem == true)
            {
                if(ktTrungThem(txtMaNH.Text) == true)
                {
                    MessageBox.Show("Nhập trùng mã thêm ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaNH.Focus();
                    return;
                }
            }
            else
            {
                if (ktTrungSua(txtMaNH.Text) == true)
                {
                    MessageBox.Show("Nhập trùng mã cập nhật ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTenNH.Focus();
                    return;
                }
            }
            if (ktThem == true)
                sql = "Insert Into nhomhang(manh,tennhomhang) values(N'" + txtMaNH.Text + "',N'" + txtTenNH.Text +  "')";
            else
                sql = "Update nhomhang set manh= N'" + txtMaNH.Text + "',tennhomhang=N'" + txtTenNH.Text + "' where manh = N'" + macu + "'";
            if (conn.State != ConnectionState.Open) conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            KhoaMo(true);
            LayNguonNH();
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                dgDanhMuc.DataSource = null;
                sDK = txtTimKiem.Text;
                sql = "Select * From nhomhang where (manh Like N'%" + txtTimKiem.Text + "%') OR(tennhomhang Like N'%" + txtTimKiem.Text + "%')";
                da = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                da.Fill(dt);
                dgDanhMuc.DataSource = dt;
            }
        }

        private void chkHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThi.Checked == true)
            {
                LayNguonNH();
            }
            else dgDanhMuc.DataSource = null;
        }

        public bool ktTrungThem(string manhap)
        {
            sql = "Select * from nhomhang where manh = N'" + manhap + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool ktTrungSua(string manhap)
        {
            sql = "Select * from nhomhang where manh = N'" + manhap + "' and manh<>N'" + macu + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
