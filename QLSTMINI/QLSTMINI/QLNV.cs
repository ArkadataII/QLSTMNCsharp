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
    public partial class QLNV : Form
    {
        SqlConnection conn;
        string sql = "";
        int chucvu = -1;
        DataGridViewCellMouseEventArgs vt;
        Boolean ktThem;
        string macu = "";

        public QLNV()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
            laynguonNV();
            KhoaMo(true);
        }

        public void KhoaMo(bool b)
        {
            dgNV.Enabled = b;
            cmdThem.Enabled = b; cmdSua.Enabled = b; cmdXoa.Enabled = b;

            txtHoTen.ReadOnly = b; txtNamSinh.ReadOnly = b;
            txtDiaChi.ReadOnly = b; txtSdt.ReadOnly = b;
            cboCV.Enabled = b;
            opt1.Enabled = !b; opt2.Enabled = !b;
            opt3.Enabled = !b; opt4.Enabled = !b;

            cmdLuu.Enabled = !b;
            cmdKhong.Enabled = !b;
        }
        public void XoaTrang()
        {
            txtDiaChi.Text = ""; txtHoTen.Text = ""; txtMaNV.Text = "";
            txtNamSinh.Text = ""; txtSdt.Text = "";
            opt1.Checked = false;
            opt2.Checked = false;
            opt3.Checked = false;
            opt4.Checked = false;
        }

        //1. Lấy nguồn cho DataGridView Nhân Viên
        public void laynguonNV()
        {
            if (chucvu <0)
                sql = "Select MaNV, TenNV, (Case When ChucVu='true' Then N'Seller' Else N'Importer' end) As ChucVu, (Case When GioiTinh='true' Then N'Nam' Else N'Nữ' end) As GioiTinh, NamSinh, SdtNV, DiaChiNV from NhanVien  ";
            else
                sql = "Select MaNV, TenNV, (Case When ChucVu='true' Then N'Seller' Else N'Importer' end) As ChucVu, (Case When GioiTinh='true' Then N'Nam' Else N'Nữ' end) As GioiTinh, NamSinh, SdtNV, DiaChiNV from NhanVien Where ChucVu = " + chucvu + "";
            dgNV.DataSource = KetNoi.getData(sql);
            lbSL.Text = "Có " + dgNV.RowCount + " nhân viên ";
        }
        //2. Hiển thị nhân viên khi chọn chức vụ
        private void cboCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            chucvu = cboCV.SelectedIndex;
            laynguonNV();
        }
        //3. Hiển thị toàn bộ nhân viên khi ấn vào button ALL
        private void cmdALL_Click(object sender, EventArgs e)
        {
            chucvu =-1;
            laynguonNV();
        }
        //4. Khi click chuột vào dg thì hiển thị dữ liệu ra chi tiết
        private void dgNV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if(dgNV.RowCount > 0)// RowCount là số lượng nên sẽ đếm từ 1
                {
                    if(e.RowIndex >= 0)// RowIndex là chỉ số thì sẽ tính từ 0
                    {
                        DataGridViewRow row = dgNV.Rows[e.RowIndex];
                        vt = e;
                        txtMaNV.Text = row.Cells[0].Value.ToString();
                        txtHoTen.Text = row.Cells[1].Value.ToString();
                        if (row.Cells[2].Value.ToString().Equals("Seller")==true)
                            opt1.Checked = true;
                        else
                            opt2.Checked = true;
                        if (row.Cells[3].Value.ToString().Equals("Nam") == true)
                            opt3.Checked = true;
                        else
                            opt4.Checked = true;
                        txtNamSinh.Text = row.Cells[4].Value.ToString();
                        txtSdt.Text = row.Cells[5].Value.ToString();
                        txtDiaChi.Text = row.Cells[6].Value.ToString();
                    }
                }
            }
            catch 
            {

            }
        }
        //5. Thêm
        private void cmdThem_Click(object sender, EventArgs e)
        {
            XoaTrang();
            txtMaNV.Text = KetNoi.TuTaoMa("NhanVien", txtMaNV.Text, "N");
            ktThem = true;
            KhoaMo(false);
            txtHoTen.Focus();
        }
        //6. Sửa
        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "") return;
            macu = txtMaNV.Text;
            ktThem = false;
            KhoaMo(false);
            txtHoTen.Focus();
        }
        //7. Không Lưu
        private void cmdKhong_Click(object sender, EventArgs e)
        {
            try
            {
                XoaTrang();
                KhoaMo(true);
                dgNV_CellMouseClick(sender, vt);//đưa con trỏ quay trở về vị trí vừa click
                return;
            }
            catch(Exception ev)
            {
                MessageBox.Show("Lỗi: " + ev.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //8. Lưu
        private void cmdLuu_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu hợp lệ
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Họ Tên", "Thông báo"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus(); return;
            }
            if (opt1.Checked==false && opt2.Checked==false)
            {
                MessageBox.Show("Bạn chưa chọn Chức Vụ", "Thông báo"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox2.Focus(); return;
            }
            if (txtNamSinh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Năm Sinh", "Thông báo"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNamSinh.Focus(); return;
            }
            if (opt3.Checked == false && opt4.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn Giới Tính", "Thông báo"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Focus(); return;
            }
            if (txtSdt.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Số Điện Thoại", "Thông báo"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSdt.Focus(); return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Địa Chỉ", "Thông báo"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus(); return;
            }
            if (KetNoi.ktTrungMa("NhanVien", "MaNV", ktThem, txtMaNV.Text, macu) == true)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại", "Thông báo"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus(); return;
            }
            // " + t + "
            if (ktThem == true)
                sql = "Insert into NhanVien(MaNV,TenNV,ChucVu,GioiTinh,NamSinh,SdtNV,DiaChiNV) values(N'" +
                    txtMaNV.Text + "',N'" + txtHoTen.Text + "'," + (opt1.Checked == true ? 1 : 0) + ","
                    + (opt3.Checked == true ? 1 : 0) + ",'" + txtNamSinh.Text + "',N'" + txtSdt.Text + "',N'"
                    + txtDiaChi.Text + "')";
            else
                sql = "Update NhanVien set MaNV = N'" + txtMaNV.Text + "',TenNv = N'" + txtHoTen.Text
                    + "',ChucVu = " + (opt1.Checked == true ? 1 : 0) + ",GioiTinh = "
                    + (opt1.Checked == true ? 1 : 0) + ",NamSinh = N'" + txtNamSinh.Text + "',SdtNV = N'"
                    + txtSdt.Text + "',DiaChiNV = N'" + txtDiaChi.Text + "' Where MaNV = N'" + macu + "'";
            if (conn.State != ConnectionState.Open) conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            KhoaMo(true);
            XoaTrang();
            laynguonNV();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "") return;
            if(MessageBox.Show("Bạn có muốn xóa nhân viên "+ txtHoTen.Text+" không?","Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete From NhanVien Where MaNV = N'" + txtMaNV.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                XoaTrang();
                laynguonNV();
            }
        }
    }
}
