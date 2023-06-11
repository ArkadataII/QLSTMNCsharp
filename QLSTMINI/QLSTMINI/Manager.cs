using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QLSTMINI
{
    public partial class Manager : Form
    {
        bool kiemtraDangXuat = false;
        public Manager()
        {
            InitializeComponent();
        }

        private void mnuWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/groups/1195735031127186");
        }

        private void Management_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kiemtraDangXuat == false)
            {
                if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Management_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (kiemtraDangXuat == false) Application.Exit();
        }

        private void mnuQLNV_Click(object sender, EventArgs e)
        {
            QLNV frm = new QLNV();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            TLTK frm = new TLTK();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuQLHH_Click(object sender, EventArgs e)
        {
            QLHH frm = new QLHH();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                kiemtraDangXuat = true;
                this.Close();
                LOGIN frm = new LOGIN();
                frm.Show();
            }
        }

        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuQLNCC_Click(object sender, EventArgs e)
        {
            frmNCC frm = new frmNCC();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuQLNH_Click(object sender, EventArgs e)
        {
            QLNH frm = new QLNH();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuBCTK_Click(object sender, EventArgs e)
        {
        }

        private void mnuTDH_Click(object sender, EventArgs e)
        {
            BCTK frm = new BCTK();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuTSP_Click(object sender, EventArgs e)
        {
            BCTKSP frm = new BCTKSP();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
