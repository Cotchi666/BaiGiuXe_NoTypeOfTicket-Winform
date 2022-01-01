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
    public partial class FormQLVe : Form
    {
        public FormQLVe()
        {
            InitializeComponent();
            
            dataGridViewve.DataSource = veDA.Instance.hienthi();
            tonsove.Text = (veDA.Instance.sovedangdung() + veDA.Instance.sovetrong() - 2).ToString();
            vetrong.Text = (veDA.Instance.sovetrong() - 2).ToString();
            dataGridViewve.Columns[0].HeaderText = "loại xe";
            dataGridViewve.Columns[1].HeaderText = "mã số vé";
            dataGridViewve.Columns[2].HeaderText = "Biển số";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAddTicket t = new FormAddTicket();
            t.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewve.DataSource = veDA.Instance.hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewve.DataSource = veDA.Instance.hienthivedangdung();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridViewve.DataSource = veDA.Instance.hienthivetrong();
        }

   
    }
}
