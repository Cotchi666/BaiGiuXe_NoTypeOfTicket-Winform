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
           
                
            dataGridViewve.Columns[0].HeaderText = "Loại xe";
            dataGridViewve.Columns[1].HeaderText = "Tổng số chỗ";
            dataGridViewve.Columns[2].HeaderText = "Số chỗ trống";
            //trong
            ottrong.Text = baixeDA.Instance.tongxeCongtrong().ToString();
            xmtrog.Text = baixeDA.Instance.tongxebuyttrong().ToString();
            xttrog.Text = baixeDA.Instance.tongxetaitrong().ToString();
            contaitrog.Text = baixeDA.Instance.tongxeCongtrong().ToString();
            //tong
            ottong.Text = baixeDA.Instance.tongxecon().ToString();
            xmtong.Text = baixeDA.Instance.tongxebuyt().ToString();
            xttong.Text = baixeDA.Instance.tongxetai().ToString();
            contaitong.Text = baixeDA.Instance.tongxeCong().ToString();

        }
        void hienthi()
        {
            dataGridViewve.DataSource = baixeDA.Instance.hienthi();
        }

    }
}
