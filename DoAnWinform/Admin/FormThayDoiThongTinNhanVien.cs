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
    public partial class FormThayDoiThongTinNhanVien : Form
    {
        public FormThayDoiThongTinNhanVien()
        {
            InitializeComponent();
            if (taikhoanDA.loainv == "Nhân viên quản lý")
            {
                txtloainv.Text = "Nhân viên quản lý";
            }
            if (taikhoanDA.loainv == "Nhân viên thường")
            {
                txtloainv.Text = "Nhân viên thường";
            }
            txtma.Text = taikhoanDA.tk;
            if (!taikhoanDA.quyenadmin)
            {
                this.txtma.Enabled = false;
                this.txtloainv.Enabled = false;
            }
            if (!taikhoanDA.quyenddangnhap)
                this.Enabled = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbdc.Text = ""; lbdt.Text = ""; lbgt.Text = ""; lbloainv.Text = ""; lbma.Text = ""; lbmk.Text = ""; lbten.Text = "";
            Boolean Tgt = false;
            Boolean Tloai = false;
            string loainv = "";
            string gt = "";
            if (txtloainv.Text == "Nhân viên quản lý")
            {
                loainv = "Nhân viên quản lý";
                Tloai = true;
            }
            if (txtloainv.Text == "Nhân viên thường")
            {
                loainv = "Nhân viên thường";
                Tloai = true;
            }
            if (txtgt.Text == "Nam")
            {
                gt = "Nam";
                Tgt = true;
            }
            if (txtgt.Text == "Nữ")
            {
                gt = "Nữ";
                Tgt = true;
            }

            //kiểm tra xem các textbox có đúng hay không

            lbdc.Text = ""; lbdt.Text = ""; lbgt.Text = ""; lbloainv.Text = ""; lbma.Text = ""; lbmk.Text = ""; lbten.Text = "";
            if (!taikhoanDA.mahoasodt(txtdt.Text) || !adminDA.Instance.tontai(txtma.Text) || txtmk.Text.Length > 30 || txtmkl.Text.Length > 30 || txtma.Text.Length > 20 || txtdc.Text.Length > 200 || txtten.Text.Length > 100 || txtten.Text.Length > 100 || txtma.Text == "" || txtten.Text == "" || txtdc.Text == "" || txtdt.Text == "" || txtmk.Text == "" || Tgt == false || Tloai == false)
            {
                if (txtma.Text == "")
                    lbma.Text = "Mã không được để trống!";
                if (txtten.Text == "")
                    lbten.Text = "Tên không được để trống!";
                if (txtdc.Text == "")
                    lbdc.Text = "Địa chỉ không được để trống!";
                if (Tgt == false)
                    lbgt.Text = "Chọn giới tính là nam hoặc nữ!";
                if (Tloai == false)
                    lbloainv.Text = "chọn loại nhân viên là nhân viên thường hoặc quản lý!";
                if (txtdt.Text == "")
                    lbdt.Text = "Điện thoại không được để trống!";
                if (!taikhoanDA.mahoasodt(txtdt.Text))
                    lbdt.Text = "số điện thoại chưa chính xác.";
                if (txtmk.Text == "")
                    lbmk.Text = "Mật khẩu không được để trống!";
                if (txtma.Text.Length > 20)
                    lbma.Text = "Mã không vượt quá 20 ký tự.";
                if (txtten.Text.Length > 100)
                    lbten.Text = "tên không đc vượt quá 100 ký tự.";
                if (txtdc.Text.Length > 200)
                    lbdc.Text = "tên không đc vượt quá 200 ký tự.";
                if (txtmk.Text.Length > 30)
                    lbmk.Text = "mất khẩu không được quá 30 ký tự";
                if (txtmkl.Text.Length > 30)
                    lbmkl.Text = "mất khẩu không được quá 30 ký tự";
                if (!adminDA.Instance.tontai(txtma.Text))
                    lbma.Text = "mã không tồn tại.";
                return;
            }
            if (txtmk.Text != txtmkl.Text)
            {
                lbmkl.Text = "Mật khẩu không khớp!";
                return;
            }
            //try
            ///{

            if (adminDA.Instance.sua(txtma.Text, txtten.Text, loainv, txtngay.Value, gt, txtdc.Text, txtdt.Text, txtmk.Text))
            {
                MessageBox.Show("Sửa thành công  " + txtten.Text + " với mã NV: " + txtma.Text + ".");
            }
            //}
            //catch
            //{
            //  MessageBox.Show("không thể sửa!");
            //}
        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbmk_Click(object sender, EventArgs e)
        {

        }

        private void lbten_Click(object sender, EventArgs e)
        {

        }

        private void lbgt_Click(object sender, EventArgs e)
        {

        }

        private void lbloainv_Click(object sender, EventArgs e)
        {

        }

        private void lbdc_Click(object sender, EventArgs e)
        {

        }

        private void lbdt_Click(object sender, EventArgs e)
        {

        }

        private void lbma_Click(object sender, EventArgs e)
        {

        }

        private void txtngay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtmk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtloainv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtma_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Thaydoithongtin_Load(object sender, EventArgs e)
        {

        }
    }
}
