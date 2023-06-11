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
    public partial class QLHH : Form
    {
        DataTable dt;
        SqlConnection conn;
        string sql = "";
        DataGridViewCellMouseEventArgs vt;
        string mahang,macu;
        bool ktThem;

        private void QLHH_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
            LayNguonNH();
            LayNguonNH1();
            LayNguonNCC();
            KhoaMo(true);
            mahang = "";
            LayNguonHH();
            XoaTrang();
        }

        public QLHH()
        {
            InitializeComponent();
        }

        private void dgHH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgHH.RowCount > 0)//Kiểm tra xem trong bảng có dữ liệu không
                {
                    if (e.RowIndex >= 0)// kiểm tra xem ng dùng có chọn hàng nào không
                    {
                        DataGridViewRow row = dgHH.Rows[e.RowIndex];
                        vt = e;
                        txtMaHang.Text = row.Cells[0].Value.ToString();
                        txtTenHang.Text = row.Cells[3].Value.ToString();
                        cbo3.SelectedValue = row.Cells[2].Value.ToString();
                        cbo2.SelectedValue = row.Cells[1].Value.ToString();
                        txtGiaNhap.Text = row.Cells[4].Value.ToString();
                        txtDonGia.Text = row.Cells[5].Value.ToString();
                        txtTonKho.Text = row.Cells[6].Value.ToString();
                    }
                }
            }
            catch(Exception ev)
            {
                MessageBox.Show("Lỗi: " + ev.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mahang = cbo1.SelectedValue.ToString();
            LayNguonHH();
        }

        private void cmdALL_Click(object sender, EventArgs e)
        {
            mahang = "";
            LayNguonHH();
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            XoaTrang();
            ktThem = true;
            KhoaMo(false);
            Taoma();
            txtMaHang.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "") return;
            macu = txtMaHang.Text;
            ktThem = false;
            KhoaMo(false);
            txtMaHang.ReadOnly = true;
            txtTenHang.Focus();
        }

        private void cmdKhong_Click(object sender, EventArgs e)
        {
            dgHH.Enabled = true;
            try
            {
                KhoaMo(true);
                dgHH_CellMouseClick(sender, vt);
            }
            catch(Exception ev)
            {
                MessageBox.Show("Lỗi: " + ev.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdLuu_Click(object sender, EventArgs e)
        {
            if (txtTenHang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập TÊN HÀNG", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ĐƠN GIÁ", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            if (txtTonKho.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập TỒN KHO", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            if (KetNoi.ktTrungMa("HangHoa", "MaHH", ktThem, txtMaHang.Text, macu) == true)
            {
                MessageBox.Show("Mã hàng hóa đã tồn tại", "Thông báo"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaHang.Focus(); return;
            }
            if (ktThem == true)//" + GT + "
                sql = "insert into HangHoa(MaHH, MaNCC, MaNH, TenHH, GiaNhap, GiaXuat, TonKho) values(N'"
                    + txtMaHang.Text + "', N'" + cbo2.SelectedValue.ToString() + "', N'"
                    + cbo3.SelectedValue.ToString() + "', N'"
                    + txtTenHang.Text + "', " + float.Parse(txtGiaNhap.Text) + ", " + float.Parse(txtDonGia.Text) + ", " + float.Parse(txtTonKho.Text) + ")";
            else
                sql = "Update HangHoa set MaHH = N'" + txtMaHang.Text + "', MaNCC = N'"
                    + cbo2.SelectedValue.ToString() + "', MaNH = N'" + cbo3.SelectedValue.ToString() + "', TenHH = N'"
                    + txtTenHang.Text + "', GiaNhap = " + float.Parse(txtGiaNhap.Text) + ", GiaXuat = " + float.Parse(txtDonGia.Text) + ", TonKho = " + float.Parse(txtTonKho.Text) 
                    + " Where MaHH = N'" + macu + "'";
            if (conn.State != ConnectionState.Open) conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();//thực hiện lưu
            KhoaMo(true);
            XoaTrang();
            LayNguonHH();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "") return;
            if(MessageBox.Show("Bạn có muốn xóa mặt hàng : "+ txtTenHang.Text+ " không ?","Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete from HangHoa Where MaHH = N'" + txtMaHang.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                XoaTrang();
                LayNguonHH();
            }
        }

        public void XoaTrang()
        {
            txtDonGia.Text = "";
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtTonKho.Text = "";
            txtGiaNhap.Text = "";
        }

        public void KhoaMo(bool b)
        {
            txtDonGia.ReadOnly = b; txtTenHang.ReadOnly = b;
            txtTonKho.ReadOnly = b; cbo2.Enabled = !b; cbo3.Enabled = !b;

            cmdThem.Enabled = b; cmdSua.Enabled = b;
            cmdXoa.Enabled = b; cmdLuu.Enabled = !b; cmdKhong.Enabled = !b;
        }

        public void LayNguonHH()
        {
            try
            {
                if (mahang == "")
                    sql = "Select * from HangHoa";
                else
                    sql = "Select * from HangHoa Where MaNH = N'" + mahang + "'";
                dgHH.DataSource = KetNoi.getData(sql);
                lbl2.Text = "SL: " + dgHH.RowCount.ToString();
            }
            catch(Exception ev)
            {
                MessageBox.Show("Lỗi: " + ev.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LayNguonNH()
        {
            sql = "Select * from NhomHang";
            cbo1.DataSource = KetNoi.getData(sql);
            cbo1.DisplayMember = "TenNhomHang";
            cbo1.ValueMember = "MaNH";
        }

        private void cbo3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void LayNguonNH1()
        {
            sql = "Select * from NhomHang";
            cbo3.DataSource = KetNoi.getData(sql);
            cbo3.DisplayMember = "TenNhomHang";
            cbo3.ValueMember = "MaNH";
        }

        public void LayNguonNCC()
        {
            sql = "Select * from NhaCungCap";
            cbo2.DataSource = KetNoi.getData(sql);
            cbo2.DisplayMember = "TenNCC";
            cbo2.ValueMember = "MaNCC";
        }
        public void Taoma()
        {
            //tự động tạo 1 mã nhân viên mới mỗi khi thêm phiếu
            sql = "Select top 1 MaHH From HangHoa order by mahh desc";
            dt = KetNoi.getData(sql);
            long num = 1;
            if (dt.Rows.Count > 0) // Kiểm tra xem trong csdl co dữ liệu chưa
            {// có rồi
                num = long.Parse(dt.Rows[0]["MaHH"].ToString()) + 1;
                
            }
            txtMaHang.Text = num.ToString("0000000000");
        }
    }
}
