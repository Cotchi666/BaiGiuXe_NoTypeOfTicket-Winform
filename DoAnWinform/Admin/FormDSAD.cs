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
    public partial class FormDSAD : Form
    {
        public static Boolean loaitest = false;
        public static Boolean oto = false;
        public static Boolean xemay = false;
        public static string bien = "";
        public static string mave = "";
        public static string loaixe = "";
        public static string tenxe = "";
        public static string mauxe = "";
        public FormDSAD()
        {
            InitializeComponent();
            hienthi();
            if (!taikhoanDA.quyenadmin)
            {
                this.btthem.Enabled = false;
                this.btxoa.Enabled = false;
            }
            dataGridViewadmin.Columns[0].HeaderText = "Mã NV";
            dataGridViewadmin.Columns[1].HeaderText = "Họ và tên";
            dataGridViewadmin.Columns[2].HeaderText = "Loại nhân viên";
            dataGridViewadmin.Columns[3].HeaderText = "Ngày sinh";
            dataGridViewadmin.Columns[4].HeaderText = "Giới tính";
            dataGridViewadmin.Columns[5].HeaderText = "Địa chỉ";
            dataGridViewadmin.Columns[6].HeaderText = "Điện thoại";
            dataGridViewadmin.Columns[7].HeaderText = "Mật Khẩu";



        }
        public void hienthi()
        {
            dataGridViewadmin.DataSource = adminDA.Instance.hienthiadmin();
        }

 

        private void btthem_Click(object sender, EventArgs e)
        {
            Boolean Tgt = false;
            Boolean Tloai = false;
            if (txtloainv.Text == "Nhân viên quản lý")
            {
                Tloai = true;
            }
            if (txtloainv.Text == "Nhân viên thường")
            {
                Tloai = true;
            }
            if (txtgt.Text == "Nam")
            {
                Tgt = true;
            }
            if (txtgt.Text == "Nữ")
            {
                Tgt = true;
            }
            lbdc.Text = ""; lbdt.Text = ""; lbgt.Text = ""; lbloainv.Text = ""; lbma.Text = ""; lbmk.Text = ""; lbten.Text = "";
            //kiểm tra xem các textbox có đúng hay không
            lbdc.Text = ""; lbdt.Text = ""; lbgt.Text = ""; lbloainv.Text = ""; lbma.Text = ""; lbmk.Text = ""; lbten.Text = "";
            if (!taikhoanDA.mahoasodt(txtdt.Text) || txtma.Text.Length > 20 || txtdc.Text.Length > 200 || txtten.Text.Length > 100 || txtten.Text.Length > 100 || adminDA.Instance.tontai(txtma.Text) || txtma.Text == "" || txtten.Text == "" || txtdc.Text == "" || txtdt.Text == "" || txtmk.Text == "" || Tgt == false || Tloai == false)
            {
                if (adminDA.Instance.tontai(txtma.Text))
                    lbma.Text = "nhân viên có mã " + txtma.Text + " đã tồn tại";
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
                    lbdt.Text = "số điện thoại không đúng.";
                if (txtmk.Text == "")
                    lbmk.Text = "Mật khẩu không được để trống!";
                if (txtma.Text.Length > 20)
                    lbma.Text = "Mã không vượt quá 20 ký tự.";
                if (txtten.Text.Length > 100)
                    lbten.Text = "tên không đc vượt quá 100 ký tự.";
                if (txtdc.Text.Length > 200)
                    lbdc.Text = "tên không đc vượt quá 200 ký tự.";
                return;
            }


            try
            {

                if (adminDA.Instance.them(txtma.Text, txtten.Text, txtloainv.Text, txtngay.Value, txtgt.Text, txtdc.Text, int.Parse(txtdt.Text), txtmk.Text))
                {
                    MessageBox.Show("thêm thành công nhân viên " + txtten.Text + " với mã NV: " + txtma.Text + ".");
                    hienthi();
                }
            }
            catch
            {
                MessageBox.Show("không thể thêm!");
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {

            lbdc.Text = ""; lbdt.Text = ""; lbgt.Text = ""; lbloainv.Text = ""; lbma.Text = ""; lbmk.Text = ""; lbten.Text = "";
            try
            {
                if (txtma.Text == "")
                {
                    lbma.Text = "Vui lòng nhập mã nhân viên cần xóa";
                    return;
                }
                if (adminDA.Instance.xoa(txtma.Text))
                {
                    MessageBox.Show("Xóa thành công nhân viên có mã " + txtma.Text + ".");
                    hienthi();
                }
            }
            catch
            {
                MessageBox.Show("Không thế xóa nhân viên có mã " + txtma.Text + ".");
            }
        }

        private void btthaydoithongtin_Click(object sender, EventArgs e)
        {
            FormThayDoiThongTinNhanVien f = new FormThayDoiThongTinNhanVien();
            f.ShowDialog();
        }

        private void buttonbttimkiemtheoma_Click(object sender, EventArgs e)
        {

            string a = txttimkiemadmim.Text;
            dataGridViewadmin.DataSource = adminDA.Instance.timkiem(a);

            dataGridViewadmin.Columns[0].HeaderText = "Mã NV";
            dataGridViewadmin.Columns[1].HeaderText = "Họ và tên";
            dataGridViewadmin.Columns[2].HeaderText = "Loại nhân viên";
            dataGridViewadmin.Columns[3].HeaderText = "Ngày sinh";
            dataGridViewadmin.Columns[4].HeaderText = "Giới tính";
            dataGridViewadmin.Columns[5].HeaderText = "Địa chỉ";
            dataGridViewadmin.Columns[6].HeaderText = "Điện thoại";
            dataGridViewadmin.Columns[7].HeaderText = "Mật Khẩu";
        }

        private void dataGridViewadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = dataGridViewadmin.CurrentRow.Index;
            txtma.Text = dataGridViewadmin.Rows[index].Cells[0].Value.ToString();
            txtten.Text = dataGridViewadmin.Rows[index].Cells[1].Value.ToString();
            if (dataGridViewadmin.Rows[index].Cells[2].Value.ToString() == "Nhân viên thường")
                txtloainv.SelectedIndex = 0;
            else if (dataGridViewadmin.Rows[index].Cells[2].Value.ToString() == "Nhân viên quản lý")
                txtloainv.SelectedIndex = 1;
            txtngay.Value = (DateTime.Parse(dataGridViewadmin.Rows[index].Cells[3].Value.ToString())).Date;
            if (dataGridViewadmin.Rows[index].Cells[4].Value.ToString() == "Nam")
                txtgt.SelectedIndex = 0;
            else if (dataGridViewadmin.Rows[index].Cells[4].Value.ToString() == "Nữ")
                txtgt.SelectedIndex = 1;
            txtdc.Text = dataGridViewadmin.Rows[index].Cells[5].Value.ToString();
            txtdt.Text = dataGridViewadmin.Rows[index].Cells[6].Value.ToString();



        }
    }
}
