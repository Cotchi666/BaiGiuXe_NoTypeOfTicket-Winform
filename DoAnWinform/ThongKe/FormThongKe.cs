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
            FormHT x = new FormHT();
            x.TopLevel = false;
            this.pnthongke.Controls.Add(x);
            x.Show();

        }
    }
}
