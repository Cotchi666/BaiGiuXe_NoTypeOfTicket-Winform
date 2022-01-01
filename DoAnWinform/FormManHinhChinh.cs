using DoAnWinform.Models;
using DoAnWinform.QuanLiThongTin;
using DoAnWinform.TruyXuatDA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinform
{
    public partial class FormManHinhChinh : Form
    {
        public FormManHinhChinh()
        {
            InitializeComponent();
            hienthi();
            if (!taikhoanDA.quyenddangnhap)
            {
                this.Enabled = false;
            }
        }
        void hienthi()
        {
            this.pnmain.Controls.Clear();
            FormAdmin ad = new FormAdmin();
            ad.TopLevel = false;
            this.pnmain.Controls.Add(ad);
            ad.Show();
        }
        private void btadmin_Click(object sender, EventArgs e)
        {
            this.pnmain.Controls.Clear();
            FormAdmin ad = new FormAdmin();
            ad.TopLevel = false;
            this.pnmain.Controls.Add(ad);
            ad.Show();
        }



        private void bttrogiup_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/cot.toxicff/");
        }

        private void btquanlyxe_Click_1(object sender, EventArgs e)
        {
            this.pnmain.Controls.Clear();
            FormQLXe q = new FormQLXe();
            q.TopLevel = false;
            this.pnmain.Controls.Add(q);
            q.Show();
        }

        private void btthongke_Click_1(object sender, EventArgs e)
        {
            this.pnmain.Controls.Clear();
            FormThongKe t = new FormThongKe();
            t.TopLevel = false;
            this.pnmain.Controls.Add(t);
            t.Show();
        }
    }
}

