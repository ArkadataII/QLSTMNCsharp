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
    public partial class frmNCC : Form
    {
        SqlConnection conn;
        SqlDataAdapter daNhaCungCap,da;
        DataTable dtNhaCungCap,dt;
        string Sql = "";
        DataGridViewCellMouseEventArgs vt;
        bool ktThem = true;
        string macu = "";

        public frmNCC()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
            KhoaMo(true);
            laynguonDG();
        }

        public void KhoaMo(bool b)
        {
            dgDanhMuc.Enabled = b;
            txtMaNCC.ReadOnly = b;
            txtTenNCC.ReadOnly = b;
            txtDiaChiNCC.ReadOnly = b;
            txtSdtNCC.ReadOnly = b;
            cmdThem.Enabled = b;
            cmdSua.Enabled = b;
            cmdXoa.Enabled = b;

            cmdGhi.Enabled = !b;
            cmdKhong.Enabled = !b;


        }

        public void laynguonDG()
        {
            Sql = "Select * from nhacungcap";
            daNhaCungCap = new SqlDataAdapter(Sql, conn);
            dtNhaCungCap = new DataTable();
            daNhaCungCap.Fill(dtNhaCungCap);

            dgDanhMuc.DataSource = dtNhaCungCap;
            lblThongBao.Text = "Có " + dgDanhMuc.RowCount + " nhà cung cấp.";
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
                        txtMaNCC.Text = row.Cells[0].Value.ToString();
                        txtTenNCC.Text = row.Cells[1].Value.ToString();
                        txtDiaChiNCC.Text = row.Cells[2].Value.ToString();
                        txtSdtNCC.Text = row.Cells[3].Value.ToString();

                    }
                }

            }catch(Exception ev)
            {
               // MessageBox.Show("Lỗi : " + ev.Message,"Thông Báo",
                 //   MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void xoatrang()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSdtNCC.Text = "";
            txtDiaChiNCC.Text = "";
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            xoatrang();
            ktThem = true;
            KhoaMo(false);
            txtMaNCC.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "") return;
            macu = txtMaNCC.Text;
            ktThem = false;
            KhoaMo(false);
            txtMaNCC.Focus();
        }

        private void cmdKhong_Click(object sender, EventArgs e)
        {
            try
            {
                xoatrang();
                KhoaMo(true);
                dgDanhMuc_CellMouseClick(sender, vt);
            }catch(Exception ev) { }

        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "") return;
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa " + txtTenNCC + " không? ", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(kq == DialogResult.Yes)
            {
                Sql = "Delete from nhacungcap where MaNCC = N'" + txtMaNCC.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(Sql, conn);
                cmd.ExecuteNonQuery();
                xoatrang();
                laynguonDG();
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if(txtMaNCC.Text == "")
            {
                MessageBox.Show("Chưa nhập mã.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaNCC.Focus();
                return;
            }
            if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Chưa nhập mã.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaNCC.Focus();
                return;
            }
            if (txtSdtNCC.Text == "")
            {
                MessageBox.Show("Chưa nhập mã.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaNCC.Focus();
                return;
            }
            if (txtDiaChiNCC.Text == "")
            {
                MessageBox.Show("Chưa nhập mã.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaNCC.Focus();
                return;
            }
            if(ktThem == true)
            {
                if(ktTrungThem(txtMaNCC.Text) == true)
                {
                    MessageBox.Show("Nhập trùng mã thêm.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaNCC.Focus();
                    return;
                }
            }
            else
            {
                if (ktTrungSua(txtMaNCC.Text) == true)
                {
                    MessageBox.Show("Nhập trùng mã cập nhật.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaNCC.Focus();
                    return;
                }
            }
            if (ktThem == true)
                Sql = "Insert Into nhacungcap(mancc,tenncc,sdtncc,diachincc) values(N'" + txtMaNCC.Text + "',N'" + txtTenNCC.Text + "',N'" + txtSdtNCC.Text + "',N'" + txtDiaChiNCC.Text + "')";
            else
                Sql = "Update nhacungcap set mancc=N'" + txtMaNCC.Text + "',tenncc=N'" + txtTenNCC.Text + "',sdtncc=N'"+ txtSdtNCC.Text + "',diachincc=N'" + txtDiaChiNCC.Text + "' where mancc = N'" + macu + "'";
            if (conn.State != ConnectionState.Open) conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            cmd.ExecuteNonQuery();
            KhoaMo(true);
            laynguonDG();
        }

        private void cmdKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ktTrungThem(string manhap)
        {
            Sql = "Select * from nhacungcap where mancc=N'" + manhap + "'";
            da = new SqlDataAdapter(Sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool ktTrungSua(string manhap)
        {
            Sql = "Select * from nhacungcap where mancc=N'" + manhap + "' and mancc<>N'" + macu + "'";
            da = new SqlDataAdapter(Sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
