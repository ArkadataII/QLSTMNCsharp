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
    public partial class PhieuNhap : Form
    {
        SqlConnection conn;
        SqlDataAdapter daNhaCC, daHangHoa,daPhieuNhap,daNhanVien, daCTPhieuNhap;
        DataTable dtNhaCC,dtHangHoa, dtPhieuNhap,dtNhanVien, dtCTPhieuNhap;
        DataGridViewCellMouseEventArgs vtNCC,vtHangHoa,vtCTPhieuNhap;
        string sql = "",sql1="",sql2="",sql3="",sql4="";
        string sDK ;
        string s, ktn;
        bool ktThem;
        double sl, dg, tt;

            public PhieuNhap()
        {
            InitializeComponent();
        }
        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dgNhaCC.DataSource = null;
                sDK = txtTim.Text;
                sql = " Select * From NhaCungCap Where (MaNCC Like N'%" + sDK + "%') OR (TenNCC Like N'%" + sDK + "%') OR (DiaChiNCC Like N'%" + sDK + "%') OR (SdtNCC like N'%" + sDK + "%')";
                daNhaCC = new SqlDataAdapter(sql, conn);
                dtNhaCC = new DataTable();
                daNhaCC.Fill(dtNhaCC);

                dgNhaCC.DataSource = dtNhaCC;

            }
        }
        private void chkHienToanBo_CheckedChanged(object sender, EventArgs e)
        {
            txtTim.Text = "";
            if (chkHienToanBo.Checked == true)
            {
                LayNguonNhaCC();
            }
            else dgNhaCC.DataSource = null;

        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                sl = double.Parse(txtSoLuong.Text);
                dg = double.Parse(txtGiaNhap.Text);
                tt = sl * dg;
                txtThanhTien.Text = tt.ToString("#,##0");
            }
        }
        private void cmdThem_Click(object sender, EventArgs e)
        {
            cmdSua.Enabled = false;
            cmdXoa.Enabled = false;
            LayNguonCTPhieuNhap();
            if (dgChiTietPhieuNhap.Rows.Count <= 0) dgNhaCC.Enabled = true;
            if (dgChiTietPhieuNhap.Rows.Count > 0) dgNhaCC.Enabled = false;
            LayNguonNhaCC();
            LayNguonHangHoaBS();
            XoaTrang();
            ktThem = true;
            KhoaMo(false);
            TinhTongTien();          
        }
        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtTenHang.Text == "")
            {
                MessageBox.Show("Bạn có chưa chọn mắt hàng muốn sửa ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenHang.Text != "")
            {
                cmdSua.Enabled = false;
                cmdXoa.Enabled = false;
                LayNguonCTPhieuNhap();
                KhoaMo(false);
                ktThem = false;
                TinhTongTien();
            }
        }
        private void cmdXoa_Click(object sender, EventArgs e)
        {
            
            if (txtTenHang.Text == "")
            {
                MessageBox.Show("Bạn có chưa chọn mắt hàng muốn xóa ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenHang.Text != "")
            {
                
                DialogResult kq = MessageBox.Show("Bạn có muốn xóa mặt hàng " + txtTenHang.Text + " không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    sql1 = "Delete from ChiTietPhieuNhap where MaHH=N'" + txtMaHang.Text + "'";
                    if (conn.State != ConnectionState.Open) conn.Open();
                    SqlCommand cmd = new SqlCommand(sql1, conn);
                    cmd.ExecuteNonQuery();
                    XoaTrang();
                    LayNguonCTPhieuNhap();
                    LayNguonHangHoaBS();
                    TinhTongTien();
                }
                if (dgChiTietPhieuNhap.Rows.Count <= 0)
                {
                    sql2 = "Delete from PhieuNhap where MaNhap=N'" + txtMaNhap.Text + "'";
                    if (conn.State != ConnectionState.Open) conn.Open();
                    SqlCommand cmd = new SqlCommand(sql2, conn);
                    cmd.ExecuteNonQuery();
                    cmdSua.Enabled = false;
                    cmdXoa.Enabled = false;
                }                        
            }          
        }
        private void cmdGhi_Click(object sender, EventArgs e)
        {
            cmdSua.Enabled = false;
            cmdXoa.Enabled = false;
            TinhThanhTien();
            LayNguonCTPhieuNhap();
            if (txtNhaCC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);               
                return;
            }
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mặt hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSoLuong.Text == "" || txtSoLuong.Text == "0")
            {
                MessageBox.Show("Bạn chưa nhập số lượng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ktThem == true)
            {
                if (dgChiTietPhieuNhap.Rows.Count <= 0)
                {
                    cmdTaoPhieu.Enabled = false;
                    sql = "insert into PhieuNhap(MaNhap,MaNCC,MANV,NgayNhap,TongTien) values(@manhap,@mancc,@manv,@ngaylap,@tongtien)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@manhap", SqlDbType.NVarChar).Value = txtMaNhap.Text;
                    cmd.Parameters.Add("@mancc", SqlDbType.NVarChar).Value = txtMaNCC.Text;
                    cmd.Parameters.Add("@manv", SqlDbType.NVarChar).Value = txtMaNV.Text;
                    cmd.Parameters.Add("@ngaylap", SqlDbType.Date).Value = dtpNgayLap.Value;
                    cmd.Parameters.Add("@tongtien", SqlDbType.Float).Value = txtTongTien.Text;
                    if (conn.State != ConnectionState.Open) conn.Open();
                    cmd.ExecuteNonQuery();
                }
                sql1 = "insert into ChiTietPhieuNhap(MaHH,MaNhap,GiaNhap,SoLuong,ThanhTien) values(@mahang,@manhap1,@gianhap,@soluong,@thanhtien)";
            }
            else
            {
                sql1 = "update ChiTietPhieuNhap set SoLuong=@soluong,ThanhTien=@thanhtien where  MaHH=@mahang1";
            }         
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            if (ktThem == true)
            {
                cmd1.Parameters.Add("@mahang", SqlDbType.NVarChar).Value = txtMaHang.Text;
                cmd1.Parameters.Add("@manhap1", SqlDbType.NChar).Value = txtMaNhap.Text;
                cmd1.Parameters.Add("@gianhap", SqlDbType.Float).Value = txtGiaNhap.Text;
            }
            cmd1.Parameters.Add("@soluong", SqlDbType.Float).Value = txtSoLuong.Text;
            cmd1.Parameters.Add("@thanhtien", SqlDbType.Float).Value = txtThanhTien.Text;
            if (ktThem == false) 
                cmd1.Parameters.Add("@mahang1", SqlDbType.NVarChar).Value = txtMaHang.Text;
            if (conn.State != ConnectionState.Open) conn.Open();
            cmd1.ExecuteNonQuery();
            XoaTrang();
            KhoaMo(true);
            KhoaCoDL(true);
            LayNguonCTPhieuNhap();
            LayNguonHangHoaBS();
            TinhTongTien();
        }
        private void cmdKhongGhi_Click(object sender, EventArgs e)
        {
            try
            {
                KhoaCoDL(true);
                XoaTrang();
                KhoaMo(true);
                dgChiTietPhieuNhap_CellMouseClick(sender,vtCTPhieuNhap);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmdTaoPhieu_Click(object sender, EventArgs e)
        {
            dgNhaCC.DataSource = null;
            dgHangHoa.DataSource = null;
            dgChiTietPhieuNhap.DataSource = null;
            XoaTrangHet();
            TaoMaPhieuNhap();
            KhoaMo(true);
            cmdTaoPhieu.Enabled = false;      
        }

        private void PhieuNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmdLuuPhieu_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn lưu phiếu nhập " + txtMaNhap.Text + " không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "update PhieuNhap set TongTien=@tongtien where MaNhap=N'" + txtMaNhap.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@tongtien", SqlDbType.Float).Value = txtTongTien.Text;
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                for (int j = 0; j < dgChiTietPhieuNhap.Rows.Count; j++)
                {
                    string mahang = dgChiTietPhieuNhap.Rows[j].Cells[0].Value.ToString();
                    double soluongthem = double.Parse( dgChiTietPhieuNhap.Rows[j].Cells[3].Value.ToString());
                    sql = "select TonKho from HangHoa where MaHH=N'" + mahang + "'";
                    daHangHoa = new SqlDataAdapter(sql, conn);
                    dtHangHoa = new DataTable();
                    daHangHoa.Fill(dtHangHoa);
                    double soluong = int.Parse(dtHangHoa.Rows[0]["TonKho"].ToString());
                    
                    sql4 = "update HangHoa set TonKho=@sl where  MaHH=@mahang";
                    SqlCommand cmd4 = new SqlCommand(sql4, conn);
                    cmd4.Parameters.Add("@mahang", SqlDbType.NVarChar).Value = mahang;

                    cmd4.Parameters.Add("@sl", SqlDbType.Float).Value = double.Parse((soluong  + soluongthem).ToString());
                    if (conn.State != ConnectionState.Open) conn.Open();
                    cmd4.ExecuteNonQuery();
                }
            }
            else
            {
                sql1 = "Delete from ChiTietPhieuNhap where MaNhap=N'" + txtMaNhap.Text + "'";
                sql = "Delete from PhieuNhap where MaNhap=N'" + txtMaNhap.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                
            }
            txtMaNCC.Text = "";
            TaoMaPhieuNhap();
            KhoaCoDL(true);
            KhoaDong(true);
            XoaTrangHet();
        }        
        public void TinhTongTien()
        {
            double tongtien=0;
            for (int i = 0; i < dgChiTietPhieuNhap.Rows.Count; i++)
            {
                tongtien += Double.Parse(dgChiTietPhieuNhap.Rows[i].Cells[4].Value.ToString());
            }
            txtTongTien.Text = tongtien.ToString("#,##0");
        }
        public void TinhThanhTien()
        {
            double thanhtien = 0;
            sl = double.Parse(txtSoLuong.Text);
            dg = double.Parse(txtGiaNhap.Text);
            thanhtien = sl * dg;
            txtThanhTien.Text = thanhtien.ToString("#,##0");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
            sql = "Select TenNV from NhanVien Where MaNV= N'" + KetNoi.s + "'";
            daNhanVien = new SqlDataAdapter(sql, conn);
            dtNhanVien = new DataTable();
            daNhanVien.Fill(dtNhanVien);
            txtMaNV.Text = KetNoi.s;
            txtNguoiLap.Text = dtNhanVien.Rows[0]["TenNV"].ToString();
            KhoaDong(true);
            LayNguonCTPhieuNhap();
            cmdTaoPhieu.Focus();
        }
        private void PhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            sql1 = "Delete from ChiTietPhieuNhap where MaNhap=N'" + txtMaNhap.Text + "'";
            sql = "Delete from PhieuNhap where MaNhap=N'" + txtMaNhap.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            if (conn.State != ConnectionState.Open) conn.Open();
            cmd.ExecuteNonQuery();
        }
        private void dgNhaCC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgNhaCC.Rows.Count > 0)
                    if (e.RowIndex >= 0)
                    {
                        vtNCC = e;
                        DataGridViewRow dr = dgNhaCC.Rows[e.RowIndex];
                        txtMaNCC.Text = dr.Cells[0].Value.ToString();
                        txtNhaCC.Text = dr.Cells[1].Value.ToString();
                        txtDiaChi.Text = dr.Cells[2].Value.ToString();
                        txtSDT.Text = dr.Cells[3].Value.ToString();
                        LayNguonHangHoaBS();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void dgHangHoa_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgHangHoa.Rows.Count > 0)
                    if (e.RowIndex >= 0)
                    {
                        vtHangHoa = e;
                        DataGridViewRow dr = dgHangHoa.Rows[e.RowIndex];
                        txtMaHang.Text = dr.Cells[0].Value.ToString();
                        txtTenHang.Text = dr.Cells[1].Value.ToString();
                        txtGiaNhap.Text = dr.Cells[2].Value.ToString();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgChiTietPhieuNhap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgChiTietPhieuNhap.Rows.Count > 0)
                    if (e.RowIndex >= 0)
                    {
                        vtCTPhieuNhap = e;
                        DataGridViewRow dr = dgChiTietPhieuNhap.Rows[e.RowIndex];
                        txtMaHang.Text = dr.Cells[0].Value.ToString();
                        txtTenHang.Text = dr.Cells[1].Value.ToString();
                        txtGiaNhap.Text = dr.Cells[2].Value.ToString();
                        txtSoLuong.Text = dr.Cells[3].Value.ToString();
                        txtThanhTien.Text = dr.Cells[4].Value.ToString();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     
        public void LayNguonNhaCC()
        {
            sql = " Select * from NhaCungCap ";
            daNhaCC = new SqlDataAdapter(sql, conn);
            dtNhaCC = new DataTable();
            daNhaCC.Fill(dtNhaCC);

            dgNhaCC.DataSource = dtNhaCC;
        }
        public void LayNguonHangHoaBS()
        {  
            sql3 = "select MaHH,TenHH,GiaNhap from HangHoa where MaNCC = N'" + txtMaNCC.Text + "'and MaHH not in (select MaHH from chitietphieunhap where MaNhap=N'" + txtMaNhap.Text + "') ";
            
            daHangHoa = new SqlDataAdapter(sql3, conn);
            dtHangHoa = new DataTable();
            daHangHoa.Fill(dtHangHoa);
            
            dgHangHoa.DataSource = dtHangHoa;
        }
        public void LayNguonCTPhieuNhap()
        {
            sql1 = "Select HANGHOA.MaHH,TenHH,HangHoa.GiaNhap,SoLuong,ThanhTien from HangHoa inner join ChiTietPhieuNhap on HangHoa.MaHH = ChiTietPhieuNhap.MaHH where ChiTietPhieuNhap.MaNhap=N'" + txtMaNhap.Text + "'";
            daCTPhieuNhap = new SqlDataAdapter(sql1, conn);
            dtCTPhieuNhap = new DataTable();
            daCTPhieuNhap.Fill(dtCTPhieuNhap);

            dgChiTietPhieuNhap.DataSource = dtCTPhieuNhap;
        }
        public void TaoMaPhieuNhap()
        {
            //tự động tạo 1 mã mã nhập mới mỗi khi thêm phiếu
            sql2 = "Select * From PhieuNhap";
            daPhieuNhap = new SqlDataAdapter(sql2, conn);
            dtPhieuNhap = new DataTable();
            daPhieuNhap.Fill(dtPhieuNhap);
            if (dtPhieuNhap.Rows.Count <= 0) // Kiểm tra xem trong csdl co dữ liệu chưa
            // nếu chưa có
            {     
                    txtMaNhap.Text = "MN" + "01" ;
            }
            else
            {// có rồi
                for (int i = 0; i <= dtPhieuNhap.Rows.Count; i++)
                {
                    s = (i + 1).ToString();
                    if (i == dtPhieuNhap.Rows.Count)
                    {
                        if (i < 9)
                        {
                            ktn = "MN" + "0" + (i + 1).ToString();
                        }
                        else
                        {
                            ktn = "MN" + (i + 1).ToString(); ;
                        }
                        txtMaNhap.Text = ktn;
                    }
                }
            }
        }
        public void KhoaMo(bool b)
        {
            txtTim.ReadOnly = b; chkHienToanBo.Enabled = !b;
            dgHangHoa.Enabled = !b; dgChiTietPhieuNhap.Enabled = b;
            txtSoLuong.ReadOnly = b; cmdThem.Enabled = b;
            cmdGhi.Enabled = !b; cmdKhongGhi.Enabled = !b;
        }
        public void KhoaCoDL(bool b)
        {
            if (dgChiTietPhieuNhap.Rows.Count >= 0)
            {
                dgNhaCC.Enabled = !b;
                cmdSua.Enabled = b;
                cmdXoa.Enabled = b;
                cmdLuuPhieu.Enabled = b;
            }
            else
            {
                cmdSua.Enabled = !b;
                cmdXoa.Enabled = !b;
                cmdLuuPhieu.Enabled = !b;
            }
        }
        public void KhoaDong(bool b)
        {
            txtTim.ReadOnly = b; chkHienToanBo.Enabled = !b;
            dgNhaCC.Enabled = !b; dgHangHoa.Enabled = !b;
            dgChiTietPhieuNhap.Enabled = b; txtSoLuong.ReadOnly = b;
            cmdThem.Enabled = !b; cmdSua.Enabled = !b; cmdXoa.Enabled = !b;
            cmdGhi.Enabled = !b; cmdKhongGhi.Enabled = !b;
            cmdTaoPhieu.Enabled = b; cmdLuuPhieu.Enabled = !b;
        }
        public void XoaTrang()
        {
            txtTenHang.Text = "";
            txtSoLuong.Text = "0";txtGiaNhap.Text = "0";
            txtThanhTien.Text="0";txtTongTien.Text = "0";
        }
        public void XoaTrangHet()
        {
            dgNhaCC.DataSource = null;
            dgHangHoa.DataSource = null;
            dgChiTietPhieuNhap.DataSource = null;
            txtNhaCC.Text = "";txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtTenHang.Text = "";
            txtSoLuong.Text = "0"; txtGiaNhap.Text = "0";
            txtThanhTien.Text = "0"; txtTongTien.Text = "0";
        }
    }
}
