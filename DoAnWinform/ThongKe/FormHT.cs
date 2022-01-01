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
    public partial class FormHT : Form
    {
        public FormHT()
        {
            InitializeComponent();
            dataGridViewtkht.DataSource = xeDA.Instance.hienthixeluot();
            dataGridViewtkht.Columns[0].HeaderText = "Mã số";
            dataGridViewtkht.Columns[1].HeaderText = "Biển số";
            dataGridViewtkht.Columns[2].HeaderText = "Loại xe";
            dataGridViewtkht.Columns[3].HeaderText = "Tên xe";
            dataGridViewtkht.Columns[4].HeaderText = "Màu xe";
            dataGridViewtkht.Columns[5].HeaderText = "TG vào bến";
            dataGridViewtkht.Columns[6].HeaderText = "Loại vé";
            tongxemaytrong.Text = baixeDA.Instance.tongxemaytrong().ToString();
            tongototrong.Text = baixeDA.Instance.tongototrong().ToString();
            tongtong.Text = (baixeDA.Instance.tongototrong() + baixeDA.Instance.tongxemaytrong()).ToString();
            tongxemayht.Text = xeDA.Instance.tongxemay().ToString();
            tongotoht.Text = xeDA.Instance.tongoto().ToString();
            tongxeht.Text = (xeDA.Instance.tongoto() + xeDA.Instance.tongxemay()).ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewtkht.DataSource = xeDA.Instance.timkiemtheobien(txttimkiemadmim.Text);
        }


    }
}
