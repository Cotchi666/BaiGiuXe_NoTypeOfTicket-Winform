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
    public partial class FormBaiXe : Form
    {
       public FormBaiXe()
        {
            InitializeComponent();
            hienthi();
            if (!taikhoanDA.quyenadmin)
                this.button2.Enabled = false;
            dataGridViewve.Columns[0].HeaderText = "Loại xe";
            dataGridViewve.Columns[1].HeaderText = "Tổng số chỗ";
            dataGridViewve.Columns[2].HeaderText = "Số chỗ trống";
            ottrong.Text = baixeDA.Instance.tongototrong().ToString();
            xmtrog.Text = baixeDA.Instance.tongxemaytrong().ToString();
            ottong.Text = baixeDA.Instance.tongoto().ToString();
            xmtong.Text = baixeDA.Instance.tongxemay().ToString();
        }
        void hienthi()
        {
            dataGridViewve.DataSource = baixeDA.Instance.hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormChangeBaiXe f = new FormChangeBaiXe();
            f.ShowDialog();
        }

    }
}
