using DoAnWinform.TruyXuatDA;
using System;
using System.Windows.Forms;

namespace DoAnWinform.QuanLiThongTin
{
    public partial class FormDSXe : Form
    {
        public static Boolean loaitest = false;
        public static Boolean oto = false;
        public static Boolean xemay = false;
        public static string bien = "";
        public static string mave = "";
        public static string loaixe = "";
        public static string tenxe = "";
        public static string mauxe = "";
        public FormDSXe()
        {
            InitializeComponent();
            hienthi();

            dataGridViewxe.Columns[0].HeaderText = "Mã số";
            dataGridViewxe.Columns[1].HeaderText = "Biển số";
            dataGridViewxe.Columns[2].HeaderText = "Loại xe";
            dataGridViewxe.Columns[3].HeaderText = "Tên xe";
            dataGridViewxe.Columns[4].HeaderText = "Màu xe";
            dataGridViewxe.Columns[5].Visible = false;
            dataGridViewxe.Columns[6].HeaderText = "TG vào bến";
            dataGridViewxe.Columns[7].Visible = false;
        }
        public void hienthi()
        {
            dataGridViewxe.DataSource = xeDA.Instance.hienthixeluot();
        }

        private void dataGridViewxe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int index = dataGridViewxe.CurrentRow.Index;
                txtmasove.Text = dataGridViewxe.Rows[index].Cells[0].Value.ToString();
                txtbien.Text = dataGridViewxe.Rows[index].Cells[1].Value.ToString();
                if (dataGridViewxe.Rows[index].Cells[2].Value.ToString() == "Xe máy")
                    txtloaixe.SelectedIndex = 0;
                else if (dataGridViewxe.Rows[index].Cells[2].Value.ToString() == "Ô tô")
                    txtloaixe.SelectedIndex = 1;
                txttenxe.Text = dataGridViewxe.Rows[index].Cells[3].Value.ToString();
                txtmauxe.Text = dataGridViewxe.Rows[index].Cells[4].Value.ToString();
                //txtmauxe.Text = (DateTime.Now - DateTime.Parse(dataGridViewxe.Rows[index].Cells[5].Value.ToString())).Hours.ToString();
                txttgvaoben.Value = DateTime.Parse(dataGridViewxe.Rows[index].Cells[5].Value.ToString());
                txtngayvaoben.Value = DateTime.Parse(dataGridViewxe.Rows[index].Cells[5].Value.ToString());
            }
            catch { }
        }

        private void bttimkiemtheove_Click(object sender, EventArgs e)
        {

            dataGridViewxe.DataSource = xeDA.Instance.timkiemtheoma(txttimkiemxe.Text);
        }

        private void bttimkiemtheobien_Click(object sender, EventArgs e)
        {
            dataGridViewxe.DataSource = xeDA.Instance.timkiemtheobien(txttkbien.Text);
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (txtloaixe.Text == "Xe con")
            {
                loaitest = true;
                loaixe = "Xe con";
            }
            if (txtloaixe.Text == "Xe buýt")
            {
                loaitest = true;
                loaixe = "Xe buýt";
            }
            if (txtloaixe.Text == "Xe tải")
            {
                loaitest = true;
                loaixe = "Xe tải";
            }
            if (txtloaixe.Text == "Xe Container")
            {
                loaitest = true;
                loaixe = "Xe Container";
            }
            lbbienso.Text = ""; lbmasove.Text = ""; lbloaixe.Text = "";
            if (loaitest == false || !xeDA.Instance.tontaixe(txtbien.Text) || !veDA.Instance.tontaive(txtmasove.Text) || txtbien.Text.Length > 20 || txtmasove.Text.Length > 10 || txttenxe.Text.Length > 100 || txtmauxe.Text.Length > 20 || txtbien.Text == "" || txtmasove.Text == "")
            {
                if (loaitest == false)
                    lbloaixe.Text = "Chọn loại xe trong box!";
                if (txtbien.Text == "")
                    lbbienso.Text = "Biển số không được để trống!";
                if (txtmasove.Text == "")
                    lbmasove.Text = "Mã số vé không được để trống!";
                if (!xeDA.Instance.tontaixe(txtbien.Text))
                    lbbienso.Text = "không thể sửa vì xe chưa có trong bến!";
                if (!veDA.Instance.tontaive(txtmasove.Text))
                    lbmasove.Text = "vé không tồn tại!";
                if (txtmasove.Text.Length > 10)
                    lbmasove.Text = "mã số vé không được quá 10 ký tự.";
                if (txtbien.Text.Length > 20)
                    lbbienso.Text = "biển số không được quá 20 ký tự.";
                if (txttenxe.Text.Length > 100)
                    lbtenxe.Text = "tên xe không được quá 100 ký tự.";
                if (txtmauxe.Text.Length > 20)
                    lbmauxe.Text = "màu xe không được quá 20 ký tự.";
                return;
            }
            if (xeDA.Instance.tontaive(txtmasove.Text))
            {
                if (!xeDA.Instance.khopvexe(txtbien.Text, txtmasove.Text))
                {
                    lbmasove.Text = "không thể sửa vì vé đã được xuất ra!";
                    return;
                }
            }
            try
            {
                if (xeDA.Instance.sua(txtmasove.Text, txtloaixe.Text, txtbien.Text, txttenxe.Text, txtmauxe.Text))
                {
                    MessageBox.Show("Sửa thành công!");
                    hienthi();
                }
                else
                    MessageBox.Show("không thể sửa!");
            }
            catch
            {
                MessageBox.Show("không thể sửa!");
            }
        }

        private void btvaoben_Click(object sender, EventArgs e)
        {
            if (txtloaixe.Text == "Xe con")
            {
                loaitest = true;
                loaixe = "Xe con";
            }
            if (txtloaixe.Text == "Xe buýt")
            {
                loaitest = true;
                loaixe = "Xe buýt";
            }
            if (txtloaixe.Text == "Xe tải")
            {
                loaitest = true;
                loaixe = "Xe tải";
            }
            if (txtloaixe.Text == "Xe Container")
            {
                loaitest = true;
                loaixe = "Xe Container";
            }
            lbloaixe.Text = ""; lbbienso.Text = ""; lbmasove.Text = "";
            if (loaitest == false || txtbien.Text.Length > 20 || txtmasove.Text.Length > 10 || txttenxe.Text.Length > 100 || txtmauxe.Text.Length > 20 || txtbien.Text == "" || txtmasove.Text == "" || xeDA.Instance.tontaixe(txtbien.Text) || xeDA.Instance.tontaive(txtmasove.Text) || !veDA.Instance.tontaive(txtmasove.Text))
            {
                if (loaitest == false)
                    lbloaixe.Text = "Chọn loại xe lại như trong box";
                if (txtbien.Text == "")
                    lbbienso.Text = "Biển số không được để trống!";
                if (txtmasove.Text == "")
                    lbmasove.Text = "Mã số vé không được để trống!";
                if (xeDA.Instance.tontaixe(txtbien.Text))
                    lbbienso.Text = "không thể thêm vì xe đã có trong bến!";
                if (xeDA.Instance.tontaive(txtmasove.Text))
                    lbmasove.Text = "không thể thêm vì vé đã được xuất ra!";
                if (!veDA.Instance.tontaive(txtmasove.Text))
                    lbmasove.Text = "vé không tồn tại!";
                if (txtmasove.Text.Length > 10)
                    lbmasove.Text = "mã số vé không được quá 10 ký tự.";
                if (txtbien.Text.Length > 20)
                    lbbienso.Text = "biển số không được quá 20 ký tự.";
                if (txttenxe.Text.Length > 100)
                    lbtenxe.Text = "tên xe không được quá 10 ký tự.";
                if (txtmauxe.Text.Length > 20)
                    lbmauxe.Text = "màu xe không được quá 20 ký tự.";
                return;
            }
            if (baixeDA.Instance.fullben(txtloaixe.Text))
            {
                MessageBox.Show("Không thể thêm vì bến đã đầy!");
                return;
            }
            //try
            //{
            DateTime vao;
            vao = DateTime.Now;
            xeDA.Instance.vaoben(txtmasove.Text, txtloaixe.Text, txtbien.Text, txttenxe.Text, txtmauxe.Text, vao);
            MessageBox.Show("Thêm thành công xe có biển số " + txtbien.Text + " với vé có mã " + txtmasove.Text + ".");
            hienthi();

        }

        private void btxuatben_Click(object sender, EventArgs e)
        {

            lbbienso.Text = ""; lbmasove.Text = "";
            if (txtbien.Text.Length > 20 || txtmasove.Text.Length > 10 || txttenxe.Text.Length > 100 || txtmauxe.Text.Length > 20 || txtbien.Text == "" || txtmasove.Text == "" || !xeDA.Instance.tontaixe(txtbien.Text) || !xeDA.Instance.tontaive(txtmasove.Text) || !veDA.Instance.tontaive(txtmasove.Text))
            {
                if (txtbien.Text == "")
                    lbbienso.Text = "Biển số không được để trống!";
                if (txtmasove.Text == "")
                    lbmasove.Text = "Mã số vé không được để trống!";
                if (!xeDA.Instance.tontaixe(txtbien.Text))
                    lbbienso.Text = "không thể xuất bến vì xe chưa có trong bến!";
                if (!xeDA.Instance.tontaive(txtmasove.Text))
                    lbmasove.Text = "không thể thêm vì vé chưa được xuất ra!";
                if (!veDA.Instance.tontaive(txtmasove.Text))
                    lbmasove.Text = "vé không tồn tại!";
                if (txtmasove.Text.Length > 10)
                    lbmasove.Text = "mã số vé không được quá 10 ký tự.";
                if (txtbien.Text.Length > 20)
                    lbbienso.Text = "biển số không được quá 20 ký tự.";
                if (txttenxe.Text.Length > 100)
                    lbtenxe.Text = "tên xe không được quá 100 ký tự.";
                if (txtmauxe.Text.Length > 20)
                    lbmauxe.Text = "màu xe không được quá 20 ký tự.";
                return;
            }
            if (!xeDA.Instance.khopvexe(txtbien.Text, txtmasove.Text))
            {
                MessageBox.Show("không thể thêm! \n Vé có mã " + txtmasove.Text + " không khớp với xe có biển số " + txtbien.Text);
                return;
            }
            else
            {
                xeDA.Instance.xuatben(txtbien.Text, txtmasove.Text, DateTime.Now);
                MessageBox.Show("Xe có biển " + txtbien.Text + " đã xuất bến!");
            }
            hienthi();
        }

        
    }
}