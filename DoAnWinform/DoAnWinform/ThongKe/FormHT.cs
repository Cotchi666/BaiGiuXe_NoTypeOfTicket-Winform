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
            dataGridViewtkht.Columns[5].Visible = false;
            dataGridViewtkht.Columns[6].HeaderText = "TG vào bến";
            dataGridViewtkht.Columns[7].Visible = false;

            //trong
            tongxetaitrong.Text = baixeDA.Instance.tongxetaitrong().ToString();
            tongxeCongTrong.Text = baixeDA.Instance.tongxeCongtrong().ToString();
            tongxebuyttrong.Text = baixeDA.Instance.tongxebuyttrong().ToString();
            tongototrong.Text = baixeDA.Instance.tongcontrong().ToString();
            tongtong.Text = (baixeDA.Instance.tongcontrong() + baixeDA.Instance.tongxebuyttrong()+ baixeDA.Instance.tongxeCongtrong()+ baixeDA.Instance.tongxetaitrong()).ToString();
            label12.Text = tongtong.Text;
            //tong xe cu the ht
            tongsoxeconght.Text= xeDA.Instance.tongxeContainer().ToString();
            tongsoxetaiht.Text = xeDA.Instance.tongxetai().ToString();
            tongxebuytht.Text = xeDA.Instance.tongxebuyt().ToString();
            tongotoht.Text = xeDA.Instance.tongxecon().ToString();
            //tong xe hien tai
            tongxeht.Text = (xeDA.Instance.tongxecon() + xeDA.Instance.tongxebuyt()+xeDA.Instance.tongxeContainer()+ xeDA.Instance.tongxetai()).ToString();
            label6.Text = tongxeht.Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewtkht.DataSource = xeDA.Instance.timkiemtheobien(txttimkiemadmim.Text);
        }


    }
}
