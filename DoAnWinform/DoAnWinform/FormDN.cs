
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
