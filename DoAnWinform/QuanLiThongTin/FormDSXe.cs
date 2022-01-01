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
            dataGridViewxe.Columns[0].HeaderText = "mã số";
            dataGridViewxe.Columns[1].HeaderText = "biển số";
            dataGridViewxe.Columns[2].HeaderText = "loại xe";
            dataGridViewxe.Columns[3].HeaderText = "tên xe";
            dataGridViewxe.Columns[4].HeaderText = "màu xe";
            dataGridViewxe.Columns[5].HeaderText = "Loại vé";
            dataGridViewxe.Columns[6].HeaderText = "TG vào bến";
        }
        public void hienthi()
        {
            dataGridViewxe.DataSource = xeDA.Instance.hienthixeluot();
        }

        private void dataGridViewxe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            if (txtloaixe.Text == "Ô tô")
            {
                loaitest = true;
                loaixe = "Ô tô";
            }
            if (txtloaixe.Text == "Xe máy")
            {
                loaitest = true;
                loaixe = "Xe máy";
            }
            lbbienso.Text = ""; lbmasove.Text = ""; lbloaixe.Text = "";
            if (loaitest == false || !xeDA.Instance.tontaixe(txtbien.Text) || !xeDA.Instance.tontaive(txtmasove.Text) || txtbien.Text.Length > 20 || txtmasove.Text.Length > 10 || txttenxe.Text.Length > 100 || txtmauxe.Text.Length > 20 || txtbien.Text == "" || txtmasove.Text == "")
            {
                if (loaitest == false)
                    lbloaixe.Text = "Chọn loại xe là Ô tô hoặc Xe máy!";
                if (txtbien.Text == "")
                    lbbienso.Text = "Biển số không được để trống!";
                if (txtmasove.Text == "")
                    lbmasove.Text = "Mã số vé không được để trống!";
                if (!xeDA.Instance.tontaixe(txtbien.Text))
                    lbbienso.Text = "không thể sửa vì xe chưa có trong bến!";
                if (!xeDA.Instance.tontaive(txtmasove.Text))
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

        private void btdkvethang_Click(object sender, EventArgs e)
        {
            lbbienso.Text = ""; lbmasove.Text = "";
            lbtenxe.Text = ""; lbmauxe.Text = "";
            lbloaixe.Text = "";
            if (txtloaixe.Text == "Ô tô")
            {
                loaitest = true;
                loaixe = "Ô tô";
                oto = true;
            }
            if (txtloaixe.Text == "Xe máy")
            {
                loaitest = true;
                loaixe = "Xe máy";
                xemay = true;
            }
            if (xeDA.Instance.vethang(txtbien.Text) || txtbien.Text.Length > 20 || txtmasove.Text.Length > 10 || txttenxe.Text.Length > 100 || txtmauxe.Text.Length > 20 || txtbien.Text == "" || txttenxe.Text == "" || loaitest == false || txtmauxe.Text == "")
            {
                if (xeDA.Instance.vethang(txtbien.Text))
                    lbbienso.Text = "Xe đã được đăng ký vé tháng rồi.";
                if (txtbien.Text == "")
                    lbbienso.Text = "Biển số không được để trống!";
                if (txtmauxe.Text == "")
                    lbmauxe.Text = "Màu xe không được để trống";
                if (txttenxe.Text == "")
                    lbtenxe.Text = "Tên xe không được để trống";
                if (loaitest == false)
                    lbloaixe.Text = "Chọn loại xe là Ô tô hoặc Xe máy";
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
            ////try
            ////{
            //bien = txtbien.Text;
            //mave = txtmasove.Text;
            //loaixe = txtloaixe.Text;
            //tenxe = txttenxe.Text;
            //mauxe = txtmauxe.Text;
            //dangkyvethang f = new dangkyvethang();
            //f.ShowDialog();
            //if (dangkyvethang.vethangok)
            //{
            //    xeDA.Instance.dangkyvethang(mave, loaixe, bien, tenxe, mauxe, DateTime.Now);
            //    MessageBox.Show("Xe có biển " + txtbien.Text + " đã đăng ký vé tháng thành công");
            //}
            //MessageBox.Show("Để tiếp tục gửi xe vui lòng nhập Mã vé.");
            //if (!xeDA.Instance.tontaive(txtmasove.Text) || xeDA.Instance.tontaixe(txtbien.Text) || xeDA.Instance.tontaive(txtmasove.Text))
            //{
            //    if (xeDA.Instance.tontaixe(txtbien.Text))
            //        lbbienso.Text = "không thể thêm vì xe đã có trong bến!";
            //    if (xeDA.Instance.tontaive(txtmasove.Text))
            //        lbmasove.Text = "không thể thêm vì vé đã được xuất ra!";
            //    if (!xeDA.Instance.tontaive(txtmasove.Text))
            //        lbmasove.Text = "vé không tồn tại!";
            //    return;
            //}
            //if (baixeDA.Instance.fullben(txtloaixe.Text))
            //{
            //    MessageBox.Show("Không thể thêm vì bến đã đầy!");
            //    return;
            //}
            //DateTime vao;
            //vao = DateTime.Now;
            //xeDA.Instance.vaoben(mave, loaixe, bien, tenxe, mauxe, vao);
            //MessageBox.Show("Thêm thành công xe có biển số " + txtbien.Text + " với vé có mã " + txtmasove.Text + ".");
            hienthi();
            //}
            //catch
            //{
            // MessageBox.Show("lỗi!");
            //}
        }
    }

        //private void dataGridViewxe_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    try
        //    {
        //        int index = dataGridViewxe.CurrentRow.Index;
        //        txtmasove.Text = dataGridViewxe.Rows[index].Cells[0].Value.ToString();
        //        txtbien.Text = dataGridViewxe.Rows[index].Cells[1].Value.ToString();
        //        if (dataGridViewxe.Rows[index].Cells[2].Value.ToString() == "Xe máy")
        //            txtloaixe.SelectedIndex = 0;
        //        else if (dataGridViewxe.Rows[index].Cells[2].Value.ToString() == "Ô tô")
        //            txtloaixe.SelectedIndex = 1;
        //        txttenxe.Text = dataGridViewxe.Rows[index].Cells[3].Value.ToString();
        //        txtmauxe.Text = dataGridViewxe.Rows[index].Cells[4].Value.ToString();
        //        //txtmauxe.Text = (DateTime.Now - DateTime.Parse(dataGridViewxe.Rows[index].Cells[5].Value.ToString())).Hours.ToString();
        //        txttgvaoben.Value = DateTime.Parse(dataGridViewxe.Rows[index].Cells[5].Value.ToString());
        //        txtngayvaoben.Value = DateTime.Parse(dataGridViewxe.Rows[index].Cells[5].Value.ToString());
        //    }
        //    catch { }
        //}
        ////nút sửa thoong tin xe
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (txtloaixe.Text == "Ô tô")
        //    {
        //        loaitest = true;
        //        loaixe = "Ô tô";
        //    }
        //    if (txtloaixe.Text == "Xe máy")
        //    {
        //        loaitest = true;
        //        loaixe = "Xe máy";
        //    }
        //    lbbienso.Text = ""; lbmasove.Text = ""; lbloaixe.Text = "";
        //    if (loaitest == false || !xeDA.Instance.tontaixe(txtbien.Text) || !veDA.Instance.tontaive(txtmasove.Text) || txtbien.Text.Length > 20 || txtmasove.Text.Length > 10 || txttenxe.Text.Length > 100 || txtmauxe.Text.Length > 20 || txtbien.Text == "" || txtmasove.Text == "")
        //    {
        //        if (loaitest == false)
        //            lbloaixe.Text = "Chọn loại xe là Ô tô hoặc Xe máy!";
        //        if (txtbien.Text == "")
        //            lbbienso.Text = "Biển số không được để trống!";
        //        if (txtmasove.Text == "")
        //            lbmasove.Text = "Mã số vé không được để trống!";
        //        if (!xeDA.Instance.tontaixe(txtbien.Text))
        //            lbbienso.Text = "không thể sửa vì xe chưa có trong bến!";
        //        if (!xeDA.Instance.tontaive(txtmasove.Text))
        //            lbmasove.Text = "vé không tồn tại!";
        //        if (txtmasove.Text.Length > 10)
        //            lbmasove.Text = "mã số vé không được quá 10 ký tự.";
        //        if (txtbien.Text.Length > 20)
        //            lbbienso.Text = "biển số không được quá 20 ký tự.";
        //        if (txttenxe.Text.Length > 100)
        //            lbtenxe.Text = "tên xe không được quá 100 ký tự.";
        //        if (txtmauxe.Text.Length > 20)
        //            lbmauxe.Text = "màu xe không được quá 20 ký tự.";
        //        return;
        //    }
        //    if (xeDA.Instance.tontaive(txtmasove.Text))
        //    {
        //        if (!xeDA.Instance.khopvexe(txtbien.Text, txtmasove.Text))
        //        {
        //            lbmasove.Text = "không thể sửa vì vé đã được xuất ra!";
        //            return;
        //        }
        //    }
        //    try
        //    {
        //        if (xeDA.Instance.sua(txtmasove.Text, txtloaixe.Text, txtbien.Text, txttenxe.Text, txtmauxe.Text))
        //        {
        //            MessageBox.Show("Sửa thành công!");
        //            hienthi();
        //        }
        //        else
        //            MessageBox.Show("không thể sửa!");
        //    }
        //    catch
        //    {
        //        MessageBox.Show("không thể sửa!");
        //    }
        //}
        ////thêm 
        //private void button3_Click(object sender, EventArgs e)
        //{

        //    if (txtloaixe.Text == "Ô tô")
        //    {
        //        loaitest = true;
        //        loaixe = "Ô tô";
        //    }
        //    if (txtloaixe.Text == "Xe máy")
        //    {
        //        loaitest = true;
        //        loaixe = "Xe máy";
        //    }
        //    lbloaixe.Text = ""; lbbienso.Text = ""; lbmasove.Text = "";
        //    if (loaitest == false || txtbien.Text.Length > 20 || txtmasove.Text.Length > 10 || txttenxe.Text.Length > 100 || txtmauxe.Text.Length > 20 || txtbien.Text == "" || txtmasove.Text == "" || xeDA.Instance.tontaixe(txtbien.Text) || xeDA.Instance.tontaive(txtmasove.Text) || !veDA.Instance.tontaive(txtmasove.Text))
        //    {
        //        if (loaitest == false)
        //            lbloaixe.Text = "Chọn loại xe là  Ô tô hoặc xe máy";
        //        if (txtbien.Text == "")
        //            lbbienso.Text = "Biển số không được để trống!";
        //        if (txtmasove.Text == "")
        //            lbmasove.Text = "Mã số vé không được để trống!";
        //        if (xeDA.Instance.tontaixe(txtbien.Text))
        //            lbbienso.Text = "không thể thêm vì xe đã có trong bến!";
        //        if (xeDA.Instance.tontaive(txtmasove.Text))
        //            lbmasove.Text = "không thể thêm vì vé đã được xuất ra!";
        //        if (!veDA.Instance.tontaive(txtmasove.Text))
        //            lbmasove.Text = "vé không tồn tại!";
        //        if (txtmasove.Text.Length > 10)
        //            lbmasove.Text = "mã số vé không được quá 10 ký tự.";
        //        if (txtbien.Text.Length > 20)
        //            lbbienso.Text = "biển số không được quá 20 ký tự.";
        //        if (txttenxe.Text.Length > 100)
        //            lbtenxe.Text = "tên xe không được quá 10 ký tự.";
        //        if (txtmauxe.Text.Length > 20)
        //            lbmauxe.Text = "màu xe không được quá 20 ký tự.";
        //        return;
        //    }
        //    if (baixeDA.Instance.fullben(txtloaixe.Text))
        //    {
        //        MessageBox.Show("Không thể thêm vì bến đã đầy!");
        //        return;
        //    }
        //    //try
        //    //{
        //    DateTime vao;
        //    vao = DateTime.Now;
        //    xeDA.Instance.vaoben(txtmasove.Text, txtloaixe.Text, txtbien.Text, txttenxe.Text, txtmauxe.Text, vao);
        //    MessageBox.Show("Thêm thành công xe có biển số " + txtbien.Text + " với vé có mã " + txtmasove.Text + ".");
        //    hienthi();
        //    //}
        //    //catch
        //    //{
        //    //  MessageBox.Show("không thành công!");
        //    //}
        //}
        //// nút xuất bến
        //private void button5_Click(object sender, EventArgs e)
        //{

        //    lbbienso.Text = ""; lbmasove.Text = "";
        //    if (txtbien.Text.Length > 20 || txtmasove.Text.Length > 10 || txttenxe.Text.Length > 100 || txtmauxe.Text.Length > 20 || txtbien.Text == "" || txtmasove.Text == "" || !xeDA.Instance.tontaixe(txtbien.Text) || !xeDA.Instance.tontaive(txtmasove.Text) || !veDA.Instance.tontaive(txtmasove.Text))
        //    {
        //        if (txtbien.Text == "")
        //            lbbienso.Text = "Biển số không được để trống!";
        //        if (txtmasove.Text == "")
        //            lbmasove.Text = "Mã số vé không được để trống!";
        //        if (!xeDA.Instance.tontaixe(txtbien.Text))
        //            lbbienso.Text = "không thể xuất bến vì xe chưa có trong bến!";
        //        if (!xeDA.Instance.tontaive(txtmasove.Text))
        //            lbmasove.Text = "không thể thêm vì vé chưa được xuất ra!";
        //        if (!veDA.Instance.tontaive(txtmasove.Text))
        //            lbmasove.Text = "vé không tồn tại!";
        //        if (txtmasove.Text.Length > 10)
        //            lbmasove.Text = "mã số vé không được quá 10 ký tự.";
        //        if (txtbien.Text.Length > 20)
        //            lbbienso.Text = "biển số không được quá 20 ký tự.";
        //        if (txttenxe.Text.Length > 100)
        //            lbtenxe.Text = "tên xe không được quá 100 ký tự.";
        //        if (txtmauxe.Text.Length > 20)
        //            lbmauxe.Text = "màu xe không được quá 20 ký tự.";
        //        return;
        //    }
        //    //if (!xeDA.Instance.khopvexe(txtbien.Text, txtmasove.Text))
        //    //{
        //    //    MessageBox.Show("không thể thêm! \n Vé có mã " + txtmasove.Text + " không khớp với xe có biển số " + txtbien.Text);
        //    //    return;
        //    //}
        //    ////try
        //    ////{
        //    //bien = txtbien.Text;
        //    //mave = txtmasove.Text;
        //    //thanhtoan f = new thanhtoan();
        //    //f.ShowDialog();
        //    //if (thanhtoan.ok)
        //    //{
        //    //    quanlyxeDAO.Instance.xuatben(txtbien.Text, txtmasove.Text, DateTime.Now);
        //    //    MessageBox.Show("Xe có biển " + txtbien.Text + " đã xuất bến!");
        //    //}
        //    //else
        //    //    MessageBox.Show("Xe có biển " + txtbien.Text + " chưa được xuất bến do không được xác nhận!");
        //    hienthi();
        //    //}
        //    //catch
        //    //{
        //    //   MessageBox.Show("lỗi!");
        //    //}
        //}

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    dataGridViewxe.DataSource = xeDA.Instance.timkiemtheoma(txttimkiemxe.Text);
        //}


        //private void button4_Click(object sender, EventArgs e)
        //{
        //    dataGridViewxe.DataSource = xeDA.Instance.timkiemtheobien(txttkbien.Text);
        //}


        ////đăng ký vé tháng
        //private void btdkvethang_Click(object sender, EventArgs e)
        //{
        //    lbbienso.Text = ""; lbmasove.Text = "";
        //    lbtenxe.Text = ""; lbmauxe.Text = "";
        //    lbloaixe.Text = "";
        //    if (txtloaixe.Text == "Ô tô")
        //    {
        //        loaitest = true;
        //        loaixe = "Ô tô";
        //        oto = true;
        //    }
        //    if (txtloaixe.Text == "Xe máy")
        //    {
        //        loaitest = true;
        //        loaixe = "Xe máy";
        //        xemay = true;
        //    }
        //    if (xeDA.Instance.vethang(txtbien.Text) || txtbien.Text.Length > 20 || txtmasove.Text.Length > 10 || txttenxe.Text.Length > 100 || txtmauxe.Text.Length > 20 || txtbien.Text == "" || txttenxe.Text == "" || loaitest == false || txtmauxe.Text == "")
        //    {
        //        if (xeDA.Instance.vethang(txtbien.Text))
        //            lbbienso.Text = "Xe đã được đăng ký vé tháng rồi.";
        //        if (txtbien.Text == "")
        //            lbbienso.Text = "Biển số không được để trống!";
        //        if (txtmauxe.Text == "")
        //            lbmauxe.Text = "Màu xe không được để trống";
        //        if (txttenxe.Text == "")
        //            lbtenxe.Text = "Tên xe không được để trống";
        //        if (loaitest == false)
        //            lbloaixe.Text = "Chọn loại xe là Ô tô hoặc Xe máy";
        //        if (txtmasove.Text.Length > 10)
        //            lbmasove.Text = "mã số vé không được quá 10 ký tự.";
        //        if (txtbien.Text.Length > 20)
        //            lbbienso.Text = "biển số không được quá 20 ký tự.";
        //        if (txttenxe.Text.Length > 100)
        //            lbtenxe.Text = "tên xe không được quá 10 ký tự.";
        //        if (txtmauxe.Text.Length > 20)
        //            lbmauxe.Text = "màu xe không được quá 20 ký tự.";
        //        return;
        //    }
        //    //try
        //    //{
        //    bien = txtbien.Text;
        //    mave = txtmasove.Text;
        //    loaixe = txtloaixe.Text;
        //    tenxe = txttenxe.Text;
        //    mauxe = txtmauxe.Text;
        //    ////dangkyvethang f = new dangkyvethang();
        //    ////f.ShowDialog();
        //    ////if (dangkyvethang.vethangok)
        //    ////{
        //    ////    quanlyxeDAO.Instance.dangkyvethang(mave, loaixe, bien, tenxe, mauxe, DateTime.Now);
        //    ////    MessageBox.Show("Xe có biển " + txtbien.Text + " đã đăng ký vé tháng thành công");
        //    ////}
        //    //MessageBox.Show("Để tiếp tục gửi xe vui lòng nhập Mã vé.");
        //    //if (!quanlyveDAO.Instance.tontaive(txtmasove.Text) || quanlyxeDAO.Instance.tontaixe(txtbien.Text) || quanlyxeDAO.Instance.tontaive(txtmasove.Text))
        //    //{
        //    //    if (quanlyxeDAO.Instance.tontaixe(txtbien.Text))
        //    //        lbbienso.Text = "không thể thêm vì xe đã có trong bến!";
        //    //    if (quanlyxeDAO.Instance.tontaive(txtmasove.Text))
        //    //        lbmasove.Text = "không thể thêm vì vé đã được xuất ra!";
        //    //    if (!quanlyveDAO.Instance.tontaive(txtmasove.Text))
        //    //        lbmasove.Text = "vé không tồn tại!";
        //    //    return;
        //    //}
        //    //if (baixeDAO.Instance.fullben(txtloaixe.Text))
        //    //{
        //    //    MessageBox.Show("Không thể thêm vì bến đã đầy!");
        //    //    return;
        //    //}
        //    //DateTime vao;
        //    //vao = DateTime.Now;
        //    //quanlyxeDAO.Instance.vaoben(mave, loaixe, bien, tenxe, mauxe, vao);
        //    //MessageBox.Show("Thêm thành công xe có biển số " + txtbien.Text + " với vé có mã " + txtmasove.Text + ".");
        //    hienthi();
        //    //}
        //    //catch
        //    //{
        //    // MessageBox.Show("lỗi!");
        //    //}
        //}
    }
