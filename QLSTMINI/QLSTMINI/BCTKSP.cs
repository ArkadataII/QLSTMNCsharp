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
    public partial class BCTKSP : Form
    {
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        SqlConnection conn;
        public BCTKSP()
        {
            InitializeComponent();
        }

        private void BCTKSP_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
            LayNguon("Select TenHH,SUM(SoLuong) AS SoLuong from ChiTietPhieuNhap inner join HangHoa on ChiTietPhieuNhap.MaHH = HangHoa.MaHH group by TenHH", true);
            LayNguon("Select TenHH,SUM(SoLuong) AS SoLuong from ChiTietPhieuXuat inner join HangHoa on ChiTietPhieuXuat.MaHH = HangHoa.MaHH group by TenHH", false);
            LayNguonDG();
        }

        public void LayNguonDG()
        {
            dgNhap.DataSource = chart1.DataSource;
            dgXuat.DataSource = chart2.DataSource;
        }

        public void LayNguon(string s,bool b)
        {
            if(b==true && s != "")
            {
                chart1.DataSource = KetNoi.getData(s);
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Hàng hóa";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";

                chart1.Series["Nhập"].XValueMember = "TenHH";
                chart1.Series["Nhập"].YValueMembers = "SoLuong";
            }
            else if(b==false && s != "")
            {
                chart2.DataSource = KetNoi.getData(s);
                chart2.ChartAreas["ChartArea2"].AxisX.Title = "Hàng hóa";
                chart2.ChartAreas["ChartArea2"].AxisY.Title = "Số lượng";

                chart2.Series["Xuất"].XValueMember = "TenHH";
                chart2.Series["Xuất"].YValueMembers = "SoLuong";
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtt1.Value > dtt2.Value)
            {
                MessageBox.Show("Bạn phải nhập ngày bắt đàu nhỏ hơn ngày kết thúc", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LayNguon("Select TenHH,SUM(SoLuong) AS SoLuong from ChiTietPhieuNhap inner join HangHoa on ChiTietPhieuNhap.MaHH = HangHoa.MaHH inner join PhieuNhap on ChiTietPhieuNhap.MaNhap=PhieuNhap.MaNhap where NgayNhap >= '"
                    + dtt1.Value.ToString() + "' and NgayNhap <= '" + dtt2.Value.ToString() + "' group by TenHH", true);
                LayNguon("Select TenHH,SUM(SoLuong) AS SoLuong from ChiTietPhieuXuat inner join HangHoa on ChiTietPhieuXuat.MaHH = HangHoa.MaHH inner join PhieuXuat on ChiTietPhieuXuat.MaXuat=PhieuXuat.MaXuat where NgayXuat >= '"
                    + dtt1.Value.ToString() + "' and NgayXuat <= '" + dtt2.Value.ToString() + "' group by TenHH", false);
            }
            LayNguonDG();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LayNguon("Select TenHH,SUM(SoLuong) AS SoLuong from ChiTietPhieuNhap inner join HangHoa on ChiTietPhieuNhap.MaHH = HangHoa.MaHH group by TenHH", true);
            LayNguon("Select TenHH,SUM(SoLuong) AS SoLuong from ChiTietPhieuXuat inner join HangHoa on ChiTietPhieuXuat.MaHH = HangHoa.MaHH group by TenHH", false);
            LayNguonDG();
        }

        private void cmdXuat_Click(object sender, EventArgs e)
        {
                if (radio1.Checked == true)
                {
                    if (MessageBox.Show("Thống kê nhập hàng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                            KetNoi.ToExcel(dgNhap, saveFileDialog1.FileName, "Thống Kê Số Lượng Sản Phẩm Xuất", "B");
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
                            KetNoi.ToExcel(dgXuat, saveFileDialog1.FileName, "Thống Kê Số Lượng Sản Phẩm Nhập", "B");
                        }
                    }
                }
        }

    }
}
