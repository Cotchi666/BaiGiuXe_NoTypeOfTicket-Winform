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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            hienthi();
            chao.Text = "Chào " + taikhoanDA.ten.ToString();
            loainv.Text = "Chức vụ: " + taikhoanDA.loainv.ToString();
        }
        void hienthi()
        {
            this.pnthongke.Controls.Clear();
            FormXeDaGui x = new FormXeDaGui();
            x.TopLevel = false;
            this.pnthongke.Controls.Add(x);
            x.Show();

        }
        private void btdanhsachnhanvien_Click(object sender, EventArgs e)
        {
            this.pnthongke.Controls.Clear();
            FormHT h = new FormHT();
            h.TopLevel = false;
            this.pnthongke.Controls.Add(h);
            h.Show();
        }

        private void btdsxedagui_Click(object sender, EventArgs e)
        {
            this.pnthongke.Controls.Clear();
            FormXeDaGui x = new FormXeDaGui();
            x.TopLevel = false;
            this.pnthongke.Controls.Add(x);
            x.Show();
        }

    }
}
