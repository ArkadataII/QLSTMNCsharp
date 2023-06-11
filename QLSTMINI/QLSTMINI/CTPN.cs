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
    public partial class CTPN : Form
    {
        SqlConnection conn;
        public CTPN()
        {
            InitializeComponent();
        }

        private void CTPN_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
            dgNhap.DataSource = KetNoi.getData("Select ChiTietPhieuNhap.MaHH,HangHoa.TenHH,HangHoa.GiaNhap,SoLuong,ThanhTien from ChiTietPhieuNhap,HangHoa where ChiTietPhieuNhap.MaHH=HangHoa.MaHH and ChiTietPhieuNhap.MaNhap='" + KetNoi.s + "'");
        }
    }
}
