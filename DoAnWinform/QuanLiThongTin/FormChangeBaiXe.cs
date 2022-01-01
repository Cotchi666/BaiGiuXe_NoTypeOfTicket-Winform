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
    public partial class FormChangeBaiXe : Form
    {
        public FormChangeBaiXe()
        {
            InitializeComponent();
            lboto.Text = "";
            lbxemay.Text = "";
            txtoto.Text = xeDA.Instance.tongoto().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lboto.Text = "";
            lbxemay.Text = "";
            if (!taikhoanDA.mahoaso(txtoto.Text) || !taikhoanDA.mahoaso(txtxemay.Text) || txtoto.Text == "" || txtoto.Text.Length > 7 || txtxemay.Text == "" || txtxemay.Text.Length > 7)
            {
                if (!taikhoanDA.mahoaso(txtoto.Text) || txtoto.Text == "" || txtoto.Text.Length > 7)
                    lboto.Text = "phài là số nguyên lớn hơn 0 và nhỏ hơn 10000000";
                if (!taikhoanDA.mahoaso(txtxemay.Text) || txtxemay.Text == "" || txtxemay.Text.Length > 7)
                    lbxemay.Text = "phải là số nguyên lớn hơn 0 và nhỏ hơn 10000000";
                return;
            }
            if (xeDA.Instance.tongoto() > int.Parse(txtoto.Text) || xeDA.Instance.tongxemay() > int.Parse(txtxemay.Text))
            {
                if (xeDA.Instance.tongoto() > int.Parse(txtoto.Text))
                    lboto.Text = "phải lớn hơn hoặc bằng số ô tô đang trong bến.";
                if (xeDA.Instance.tongxemay() > int.Parse(txtxemay.Text))
                    lbxemay.Text = "phải lớn hơn hoặc bằng số xe máy đang trong bến.";
                return;
            }

            try
            {

                baixeDA.Instance.thaydoiben(int.Parse(txtoto.Text), int.Parse(txtxemay.Text));
                MessageBox.Show("thay đổi thành công bến hiện tại có thể chứa " + txtoto.Text + " xe ô tô và " + txtxemay.Text + " xe máy.");
            }
            catch
            {
                MessageBox.Show("Lỗi! \n Không thể tahy đổi!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}