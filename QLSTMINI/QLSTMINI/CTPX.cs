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
    public partial class CTPX : Form
    {
        SqlConnection conn;
        public CTPX()
        {
            InitializeComponent();
        }

        private void CTPX_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
            dgXuat.DataSource = KetNoi.getData("Select ChiTietPhieuXuat.MaHH,HangHoa.TenHH,HangHoa.GiaXuat,SoLuong,ThanhTien from ChiTietPhieuXuat,HangHoa where ChiTietPhieuXuat.MaHH=HangHoa.MaHH and ChiTietPhieuXuat.MaXuat='" + KetNoi.s + "'");
        }
    }
}
