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
    public partial class frmChitietpieuxuat : Form
    {
        SqlConnection conn;
        SqlDataAdapter daPhieuxuat, daHangHoa, da;
        DataTable dtPhieuxuat, dtHangHoa, dt;
        DataGridViewCellMouseEventArgs vtHangHoa;
        double soluong;
        int i = 0;
        string sql = "", ktn, s, sDK, sql1 = "", sql4 = "";
        public frmChitietpieuxuat()
        {
            InitializeComponent();
        }
        private void frmChitietpieuxuat_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
            TaoMaPhieuXuat();
            sql = "Select TenNV,MaNV From NhanVien where chucvu = 1";
            daHangHoa = new SqlDataAdapter(sql, conn);
            dtHangHoa = new DataTable();
            daHangHoa.Fill(dtHangHoa);
            cboNhanVien.DataSource = dtHangHoa;
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "MaNV";
            cboNhanVien.Focus();
            KhoaDong(true);
        }
        public void KhoaMo(bool b)
        {
            cmdLuu.Enabled = b;
            cmdThanhtoan.Enabled = b;
            cmdXoatrang.Enabled = b;
        }
        public void KhoaDong(bool b)
        {
            dgHangHoa.Enabled = !b;
            dgPhieuxuat.Enabled = !b;
            txtTienkhach.ReadOnly = b;
            txtSoluong.ReadOnly = b;
            cmdLuu.Enabled = !b;
            cmdThanhtoan.Enabled = !b;
            cmdXoatrang.Enabled = !b;
            cmdXoa.Enabled = !b;
            cmdSua.Enabled = !b;
            cmdThem.Enabled = !b;
        }
        public void KhoaCoDL(bool b)
        {
            if (dgPhieuxuat.Rows.Count >= 0)
            {
                cmdXoatrang.Enabled = b;
                cmdThanhtoan.Enabled = b;
            }
            else
            {
                cmdSua.Enabled = !b;
                cmdXoa.Enabled = !b;
                cmdThanhtoan.Enabled = !b;
                cmdLuu.Enabled = !b;
            }
        }
        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void dgHangHoa_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmdThem.Enabled = true;
            txtSoluong.ReadOnly = false;
            dgPhieuxuat.Enabled = true;
            try
            {
                if (dgHangHoa.Rows.Count > 0)
                    if (e.RowIndex >= 0)
                    {
                        vtHangHoa = e;
                        DataGridViewRow dr = dgHangHoa.Rows[e.RowIndex];
                        txtMahang.Text = dr.Cells[0].Value.ToString();
                        txtTenhang.Text = dr.Cells[1].Value.ToString();
                        txtDongia.Text = dr.Cells[2].Value.ToString();
                        string ktsl = "Select tonkho  From HangHoa where MaHH = N'" + txtMahang.Text + "'";
                        da = new SqlDataAdapter(ktsl, conn);// dùng để đưa câu lệnh truy vấn ktsl vào sql 
                        dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            soluong = Double.Parse(dt.Rows[0]["TonKho"].ToString());
                        }
                    }
                cmdSua.Enabled = false;
                cmdXoa.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void dgPhieuxuat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            cmdSua.Enabled = true;
            cmdThem.Enabled = false;
            cmdLuu.Enabled = true;
            dgPhieuxuat.Enabled = true;
            try
            {
                if (dgPhieuxuat.Rows.Count > 0)
                    if (e.RowIndex >= 0)
                    {
                        vtHangHoa = e;
                        DataGridViewRow dr = dgPhieuxuat.Rows[e.RowIndex];
                        txtMahang.Text = dr.Cells[0].Value.ToString();
                        txtDongia.Text = dr.Cells[2].Value.ToString();
                        txtTenhang.Text = dr.Cells[1].Value.ToString();
                        txtSoluong.Text = dr.Cells[3].Value.ToString();
                        string ktsl = "Select *  From HangHoa where MaHH = N'" + txtMahang.Text + "'";
                        da = new SqlDataAdapter(ktsl, conn);// dùng để đưa câu lệnh truy vấn ktsl vào sql 
                        dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            soluong = Double.Parse(dt.Rows[0]["TonKho"].ToString());
                        }
                    }
                cmdSua.Enabled = true;
                cmdXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
        private void txtTimhang_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dgHangHoa.DataSource = null;
                sDK = txtTimhang.Text;
                sql = " Select MaHH,TenHH,DonGia,TonKho From HangHoa Where (MaHH Like N'%" + sDK + "%') OR (MaNH Like N'%" + sDK + "%') OR (TenHH Like N'%" + sDK + "%') ";
                daHangHoa = new SqlDataAdapter(sql, conn);
                dtHangHoa = new DataTable();
                daHangHoa.Fill(dtHangHoa);

                dgHangHoa.DataSource = dtHangHoa;
                cmdThem.Enabled = true;
                dgHangHoa.Enabled = true;   
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienToanBo.Checked == true)
            {
                LayNguonHangHoa();
            }
            else dgHangHoa.DataSource = null;
            txtTimhang.Text = "";

            cmdThem.Enabled = true;
            dgHangHoa.Enabled = true;
        }
        private void cmdThem_Click(object sender, EventArgs e)
        {
            KhoaMo(true);
            try
            {
                bool ktThemhang = false;
                string mahang = txtMahang.Text;
                if (txtMahang.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn hàng cần cho mua", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ktThemhang = false;
                    txtMahang.Focus();
                    return;
                }
                if (txtSoluong.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập số lượng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ktThemhang = false;
                    txtSoluong.Focus();
                    return;
                }
                if (double.Parse(txtSoluong.Text) > soluong)
                {
                    MessageBox.Show("Số lượng xuất không thể lớn hơn số lượng tồn kho", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoluong.Focus();
                    return;
                }
                if (txtMahang.Text != "" && soluong <= 0)
                {
                    MessageBox.Show("Hiện tại kho đã hết mặt hàng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ktThemhang = false;
                    txtMahang.Focus();
                    return;
                }

                foreach (DataGridViewRow dgvRow in dgPhieuxuat.Rows)
                {
                    foreach (DataGridViewCell dgvCell in dgvRow.Cells)
                    {
                        if (Convert.ToString(dgvCell.Value) == txtMahang.Text)
                        {
                            MessageBox.Show("Mặt hàng này đã có trong hóa đơn !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ktThemhang = true;
                        }

                    }
                }
                if (i < soluong && soluong > 0)
                {
                    if (ktThemhang == false)
                    {
                        i++;
                        dgPhieuxuat.Rows.Add(txtMahang.Text, txtTenhang.Text, txtDongia.Text, txtSoluong.Text, double.Parse(txtSoluong.Text) * double.Parse(txtDongia.Text));
                        txtMahang.Text = "";
                    }
                }
                else if (i == soluong)
                {
                    MessageBox.Show("Chỉ được mua tối đa " + soluong + " mặt hàng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (soluong == 0)
                {
                    MessageBox.Show("Mặt hàng này đã được bán hết", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            txtTienkhach.ReadOnly = false;
            double tongtien = 0;
            for (i = 0; i < dgPhieuxuat.Rows.Count; i++)
            {
                tongtien += double.Parse(dgPhieuxuat.Rows[i].Cells[4].Value.ToString());
            }
            txtTongthanhtien.Text = tongtien.ToString("#,##0");
            KhoaCoDL(true);
            txtMahang.Text = "";
            txtTenhang.Text = "";
            txtDongia.Text = "";
            txtSoluong.Text = "";
        }
        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtTenhang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mặt hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSoluong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSoluong.Focus();
                return;
            }
            if (double.Parse(txtSoluong.Text) > soluong)
            {
                MessageBox.Show("Số lượng xuất không thể lớn hơn số lượng tồn kho", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoluong.Focus();
                return;
            }
            if (txtMahang.Text != "" && soluong <= 0)
            {
                MessageBox.Show("Hiện tại kho đã hết mặt hàng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMahang.Focus();
                return;
            }
            for (i = 0; i < dgPhieuxuat.Rows.Count; i++)
            {
                if (txtMahang.Text == dgPhieuxuat.Rows[i].Cells[0].Value.ToString())
                {
                    dgPhieuxuat.Rows.RemoveAt(i);
                }
            }
            dgPhieuxuat.Rows.Add(txtMahang.Text, txtTenhang.Text, txtDongia.Text, txtSoluong.Text, double.Parse(txtSoluong.Text) * double.Parse(txtDongia.Text));           
        }

        private void frmChitietpieuxuat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtTenhang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mặt hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            for (i = 0; i < dgPhieuxuat.Rows.Count; i++)
            {
                if (txtMahang.Text == dgPhieuxuat.Rows[i].Cells[0].Value.ToString())
                {
                    dgPhieuxuat.Rows.RemoveAt(i);
                }
            }
            txtMahang.Text = "";
            txtTenhang.Text = "";
            txtDongia.Text = "";
            txtSoluong.Text = "";
        }
        private void cmdLuu_Click(object sender, EventArgs e)
        {
            if (txtTienthua.Text != "")
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn lưu hóa đơn  " + txtMahoadon.Text + " không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    sql = "insert into PhieuXuat(MaXuat,MaNV,NgayXuat,TongTien) values(@maxuat,@manv,@ngayxuat,@tongtien)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@tongtien", SqlDbType.Float).Value = txtTongthanhtien.Text;
                    cmd.Parameters.Add("@maxuat", SqlDbType.NVarChar).Value = txtMahoadon.Text;
                    cmd.Parameters.Add("@ngayxuat", SqlDbType.Date).Value = dtpNgayxuat.Value;
                    cmd.Parameters.Add("@manv", SqlDbType.NVarChar).Value = cboNhanVien.SelectedValue;
                    if (conn.State != ConnectionState.Open) conn.Open();
                    cmd.ExecuteNonQuery();
                    for (int j = 0; j < dgPhieuxuat.Rows.Count; j++)
                    {
                        string mahang = dgPhieuxuat.Rows[j].Cells[0].Value.ToString();
                        float thanhtien = float.Parse(dgPhieuxuat.Rows[j].Cells[4].Value.ToString());
                        sql1 = "insert into ChiTietPhieuXuat (MaXuat,MaHH,GiaXuat,SoLuong,ThanhTien) values(@maxuat,@mahang,@giaxuat,@soluong,@thanhtien)";
                        SqlCommand cmd1 = new SqlCommand(sql1, conn);
                        cmd1.Parameters.Add("@mahang", SqlDbType.NVarChar).Value = mahang;
                        cmd1.Parameters.Add("@maxuat", SqlDbType.NVarChar).Value = txtMahoadon.Text;
                        cmd1.Parameters.Add("@giaxuat", SqlDbType.Float).Value = dgPhieuxuat.Rows[j].Cells[2].Value.ToString();
                        cmd1.Parameters.Add("@soluong", SqlDbType.Float).Value = dgPhieuxuat.Rows[j].Cells[3].Value.ToString();
                        cmd1.Parameters.Add("@thanhtien", SqlDbType.Float).Value = dgPhieuxuat.Rows[j].Cells[4].Value.ToString();

                        if (conn.State != ConnectionState.Open) conn.Open();
                        cmd1.ExecuteNonQuery();

                    }
                    for (int j = 0; j < dgPhieuxuat.Rows.Count; j++)
                    {
                        string mahang = dgPhieuxuat.Rows[j].Cells[0].Value.ToString();
                        double soluongban = double.Parse(dgPhieuxuat.Rows[j].Cells[3].Value.ToString());
                        sql = "select TonKho from HangHoa where MaHH=N'" + mahang + "'";
                        daHangHoa = new SqlDataAdapter(sql, conn);
                        dtHangHoa = new DataTable();
                        daHangHoa.Fill(dtHangHoa);
                        double soluong = int.Parse(dtHangHoa.Rows[0]["TonKho"].ToString());

                        sql4 = "update HangHoa set TonKho=@sl where  MaHH=@mahang";
                        SqlCommand cmd4 = new SqlCommand(sql4, conn);
                        cmd4.Parameters.Add("@mahang", SqlDbType.NVarChar).Value = mahang;

                        cmd4.Parameters.Add("@sl", SqlDbType.Float).Value = double.Parse((soluong - soluongban).ToString());
                        if (conn.State != ConnectionState.Open) conn.Open();
                        cmd4.ExecuteNonQuery();
                    }
                    dgHangHoa.DataSource = null;
                    cmdXoatrang_Click(sender, e);
                    MessageBox.Show("Luu Thanh Cong");
                    KhoaMo(false);
                    TaoMaPhieuXuat();
                }
                else
                {
                    sql1 = "Delete from ChiTietPhieuXuat where MaXuat=N'" + txtMahoadon.Text + "'";
                    sql = "Delete from PhieuXuat where MaXuat=N'" + txtMahoadon.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlCommand cmd1 = new SqlCommand(sql1, conn);
                    if (conn.State != ConnectionState.Open) conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        }
        public void TinhThanhTien()
        {
            txtTienkhach.ReadOnly = false;
            double tongtien = 0;
            for (i = 0; i < dgPhieuxuat.Rows.Count; i++)
            {
                tongtien += double.Parse(dgPhieuxuat.Rows[i].Cells[4].Value.ToString());
            }
            txtTongthanhtien.Text = tongtien.ToString("#,##0");
        }
        private void cmdThanhtoan_Click(object sender, EventArgs e)
        {
            double tienthua = double.Parse(txtTienkhach.Text) - double.Parse(txtTongthanhtien.Text);
            if (tienthua < 0)
                MessageBox.Show("Khách đưa thiếu tiền !!!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                txtTienthua.Text = tienthua.ToString("#,##0");
            }
            if(tienthua > 0) cmdLuu.Enabled = true;  
        }
        private void cmdXoatrang_Click(object sender, EventArgs e)
        {
            dgPhieuxuat.Rows.Clear();
            txtDongia.Text = "";
            cboNhanVien.Text = "";
            txtTenhang.Text = "";
            txtTienkhach.Text = "";
            txtTienthua.Text = "";
            txtTimhang.Text = "";
            txtTongthanhtien.Text = "";
            txtSoluong.Text = "";
            txtMahang.Text = "";
        }
        private void txtTienkhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                double tienthua = double.Parse(txtTienkhach.Text) - double.Parse(txtTongthanhtien.Text);
                if (tienthua < 0)
                    MessageBox.Show("Khách đưa thiếu tiền !!!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    txtTienthua.Text = tienthua.ToString("#,##0");
                }
                if (tienthua > 0) cmdLuu.Enabled = true;
            }
        }
        public void TaoMaPhieuXuat()
        {
            //tự động tạo 1 mã phiếu mượn mới mỗi khi thêm phiếu
            sql = "Select * From PhieuXuat";
            daPhieuxuat = new SqlDataAdapter(sql, conn);
            dtPhieuxuat = new DataTable();
            daPhieuxuat.Fill(dtPhieuxuat);
            if (dtPhieuxuat.Rows.Count <= 0) // Kiểm tra xem trong csdl co dữ liệu chưa
            // nếu chưa có
            {
                int n = dtPhieuxuat.Rows.Count + 1;
                string s = n.ToString();
                if (n < 9)
                {
                    txtMahoadon.Text = "MX" + "0" + s;
                }
                else
                {
                    txtMahoadon.Text = "MX" + s;
                }
            }
            else
            {// có rồi
                for (int i = 0; i <= dtPhieuxuat.Rows.Count; i++)
                {
                    s = (i + 1).ToString();
                    if (i == dtPhieuxuat.Rows.Count)

                    {
                        if (i < 9)
                        {
                            ktn = "MX" + "0" + (i + 1).ToString();
                        }
                        else
                        {
                            ktn = "MX" + (i + 1).ToString(); ;
                        }
                        txtMahoadon.Text = ktn;
                    }
                    else
                    {
                        if (i < 9)
                        {
                            ktn = "MX" + "0" + s;
                        }
                        else
                        {
                            ktn = "MX" + s;
                        }
                        try
                        {
                            if (ktn != (dtPhieuxuat.Rows[i][0].ToString()))
                            {
                                txtMahoadon.Text = ktn;
                                break;
                            }
                        }
                        catch { }
                    }
                }
            }
        }      
        public void LayNguonDanhMuc()
        {
            sql = "select HangHoa.MaHH, TenHH, GiaXuat from HangHoa inner join ChiTietPhieuXuat on HangHoa.MaHH = ChiTietPhieuXuat.MaHH ";
            daPhieuxuat = new SqlDataAdapter(sql, conn);
            dtPhieuxuat = new DataTable();
            daPhieuxuat.Fill(dtPhieuxuat);
            dgHangHoa.DataSource = dtPhieuxuat;

        }
        public void LayNguonHangHoa()
        {
            sql = " Select MaHH,TenHH,GiaXuat,TonKho from HangHoa ";
            daHangHoa = new SqlDataAdapter(sql, conn);
            dtHangHoa = new DataTable();
            daHangHoa.Fill(dtHangHoa);

            dgHangHoa.DataSource = dtHangHoa;
        }

    }

}
        
    

