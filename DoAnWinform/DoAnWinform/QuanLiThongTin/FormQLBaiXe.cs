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
     

            //trong
            tongxetaitrong.Text = baixeDA.Instance.tongxetaitrong().ToString();
            tongxeCongTrong.Text = baixeDA.Instance.tongxeCongtrong().ToString();
            tongxebuyttrong.Text = baixeDA.Instance.tongxebuyttrong().ToString();
            tongototrong.Text = baixeDA.Instance.tongcontrong().ToString();
            tongtong.Text = (baixeDA.Instance.tongcontrong() + baixeDA.Instance.tongxebuyttrong() + baixeDA.Instance.tongxeCongtrong() + baixeDA.Instance.tongxetaitrong()).ToString();
            label12.Text = tongtong.Text;
            //tong xe cu the ht
            tongsoxeconght.Text = xeDA.Instance.tongxeContainer().ToString();
            tongsoxetaiht.Text = xeDA.Instance.tongxetai().ToString();
            tongxebuytht.Text = xeDA.Instance.tongxebuyt().ToString();
            tongotoht.Text = xeDA.Instance.tongxecon().ToString();
            //tong xe hien tai
            tongxeht.Text = (xeDA.Instance.tongxecon() + xeDA.Instance.tongxebuyt() + xeDA.Instance.tongxeContainer() + xeDA.Instance.tongxetai()).ToString();
            label6.Text = tongxeht.Text;


        }
      

        private void tongsoxeconght_Click(object sender, EventArgs e)
        {

        }
    }
}
