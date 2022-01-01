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

namespace DoAnWinform.QuanLiThongTin
{
    public partial class FormQLXe : Form
    {
        public FormQLXe()
        {
            InitializeComponent();
            hienthiqlxe();
            chao.Text = taikhoanDA.ten.ToString();
            loainv.Text =  taikhoanDA.loainv.ToString();
        }
        void hienthiqlxe()
        {
            this.pnaqlxe.Controls.Clear();
            FormDSXe d = new FormDSXe();
            d.TopLevel = false;
            this.pnaqlxe.Controls.Add(d);
            d.Show();
        }

        private void btdanhsachnhanvien_Click(object sender, EventArgs e)
        {
            this.pnaqlxe.Controls.Clear();
            FormDSXe d = new FormDSXe();
            d.TopLevel = false;
            this.pnaqlxe.Controls.Add(d);
            d.Show();
        }

        private void btquanlyve_Click(object sender, EventArgs e)
        {
            this.pnaqlxe.Controls.Clear();
            FormQLVe d = new FormQLVe();
            d.TopLevel = false;
            this.pnaqlxe.Controls.Add(d);
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pnaqlxe.Controls.Clear();
            FormBaiXe d = new FormBaiXe();
            d.TopLevel = false;
            this.pnaqlxe.Controls.Add(d);
            d.Show();
        }

   
    }
}
