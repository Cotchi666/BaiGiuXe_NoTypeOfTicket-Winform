
using DoAnWinform.TruyXuatDA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinform
{
    public partial class FormDN : Form
    {
      
        public FormDN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txttaikhoan.Text;
            string password = txtmatkhau.Text;

            if (loginDA.Instance.quyenADMIN(username, password))
            {
                taikhoanDA.ten = taikhoanDA.layten(txttaikhoan.Text);
                taikhoanDA.loainv = taikhoanDA.layloainv(txttaikhoan.Text);
                taikhoanDA.tk = username;
                taikhoanDA.quyenadmin = loginDA.Instance.quyenquanly(username, password);
                taikhoanDA.quyenddangnhap = loginDA.Instance.quyenADMIN(username, password);
                //if (taikhoan.loainv == "Nhân viên quản lý")
                //  MessageBox.Show("đăng nhập thành công với quyền của: NHÂN VIÊN QUẢN LÝ.");
                //if (taikhoan.loainv == "Nhân viên thường")
                //    MessageBox.Show("đăng nhập thành công với quyền của: NhÂN VIÊN THƯỜNG.");
                this.Hide();
                FormManHinhChinh fm = new FormManHinhChinh();
                fm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }

    }
}
