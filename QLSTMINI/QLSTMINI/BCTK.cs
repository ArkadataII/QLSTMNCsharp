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
    public partial class BCTK : Form
    {
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        SqlConnection conn;
        string sql="",manv="";
        float tong;
        public BCTK()
        {
            InitializeComponent();
        }

        private void BCTK_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
            LayNguonPN();
            LayNguonPX();
            TongTien();
            LayNguonNV();
        }
        public void LayNguonPN()
        {
            if (manv == "")
                sql = "Select * from PhieuNhap";
            else
                sql = "Select * from PhieuNhap Where MaNV = N'" + manv + "'";
            dgNhap.DataSource = KetNoi.getData(sql);
            lbl1.Text = "Có " + dgNhap.RowCount.ToString() + " phiếu";
        }
        public void LayNguonPX()
        {
            if (manv == "")
                sql = "Select * from PhieuXuat";
            else
                sql = "Select * from PhieuXuat Where MaNV = N'" + manv + "'";
            dgXuat.DataSource = KetNoi.getData(sql);
            lbl2.Text = "Có " + dgXuat.RowCount.ToString() + " phiếu";
        }

        public void LayNguonNV()
        {
            sql = "Select * from NhanVien where ChucVu = 0";
            cboNhanVien.DataSource = KetNoi.getData(sql);
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "MaNV";
            sql = "Select * from NhanVien where ChucVu = 1";
            cbo2.DataSource = KetNoi.getData(sql);
            cbo2.DisplayMember = "TenNV";
            cbo2.ValueMember = "MaNV";
        }

        private void cmdThongKe_Click(object sender, EventArgs e)
        {
            if (dtt1.Value > dtt2.Value)
            {
                MessageBox.Show("Bạn phải nhập ngày bắt đàu nhỏ hơn ngày kết thúc", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sql = "Select * from PhieuNhap where NgayNhap >= '" + dtt1.Value.ToString() + "' and NgayNhap <= '" + dtt2.Value.ToString() + "'";
                dgNhap.DataSource = KetNoi.getData(sql);
                sql = "Select * from PhieuXuat where NgayXuat >= '" + dtt1.Value.ToString() + "' and NgayXuat <= '" + dtt2.Value.ToString() + "'";
                dgXuat.DataSource = KetNoi.getData(sql);
            }
            TongTien();
            lbl1.Text = "Có " + dgNhap.RowCount.ToString() + " phiếu";
            lbl2.Text = "Có " + dgXuat.RowCount.ToString() + " phiếu";
        }

        public void TongTien()
        {
            tong = 0;
            if (dgNhap.Rows.Count >= 0)
            {
                for (int i = 0; i < dgNhap.Rows.Count; i++) tong = tong + float.Parse(dgNhap.Rows[i].Cells[4].Value.ToString());
                lblTongNhap.Text = tong.ToString("#,##0");
            }
            tong = 0;
            if (dgXuat.Rows.Count >= 0)
            {
                for (int i = 0; i < dgXuat.Rows.Count; i++) tong = tong + float.Parse(dgXuat.Rows[i].Cells[3].Value.ToString());
                lblTongXuat.Text = tong.ToString("#,##0");
            }
        }

        private void cmdALL_Click(object sender, EventArgs e)
        {
            manv = "";
            LayNguonPN();
            LayNguonPX();
            TongTien();
        }

        private void cbo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            manv = cbo2.SelectedValue.ToString();
            LayNguonPX();
            TongTien();
        }

        private void cmdXuat_Click(object sender, EventArgs e)
        {
            if (radio1.Checked == true)
            {
                if(MessageBox.Show("Thống kê nhập hàng!","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                        KetNoi.ToExcel(dgNhap, saveFileDialog1.FileName, "Thống Kê Nhập Hàng", "E");
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Thống kê xuất hàng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                        KetNoi.ToExcel(dgXuat, saveFileDialog1.FileName, "Thống Kê Xuất Hàng", "D");
                    }
                }
            }
        }

        private void dgNhap_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            KetNoi.s = dgNhap.Rows[e.RowIndex].Cells[0].Value.ToString();
            CTPN frm = new CTPN();
            frm.ShowDialog();
        }

        private void dgXuat_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            KetNoi.s = dgXuat.Rows[e.RowIndex].Cells[0].Value.ToString();
            CTPX frm = new CTPX();
            frm.ShowDialog();
        }

        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            manv = cboNhanVien.SelectedValue.ToString();
            LayNguonPN();
            TongTien();
        }
    }
}
