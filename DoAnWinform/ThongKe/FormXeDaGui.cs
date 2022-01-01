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
    public partial class FormXeDaGui : Form
    {
        public FormXeDaGui()
        {
            InitializeComponent();
            if (!taikhoanDA.quyenadmin)
                button4.Enabled = false;
            if (!taikhoanDA.quyenddangnhap)
                this.Enabled = false;
            tinh();
            hienthi();
            dataGridViewtk.Columns[0].HeaderText = "Mã số";
            dataGridViewtk.Columns[1].HeaderText = "Biển số";
            dataGridViewtk.Columns[2].HeaderText = "Loại xe";
            dataGridViewtk.Columns[3].HeaderText = "Tên xe";
            dataGridViewtk.Columns[4].HeaderText = "Màu xe";
            dataGridViewtk.Columns[5].HeaderText = "Loại vé";
            dataGridViewtk.Columns[6].HeaderText = "Giá vé";
            dataGridViewtk.Columns[7].HeaderText = "TG vào bến";
            dataGridViewtk.Columns[8].HeaderText = "TG xuất bến";


        }
        public void tinh()
        {
            tbtongtien.Text = (baixeDA.Instance.tienveoto() + baixeDA.Instance.tienvexemay()).ToString();
            tienoto.Text = baixeDA.Instance.tienveoto().ToString();
            tienxm.Text = baixeDA.Instance.tienvexemay().ToString();
            //tongtienveluot.Text = (xeDaGuiDA.Instance.soxemayguitheoluot() * 5000 + xeDaGuiDA.Instance.sootoguitheoluot() * 50000).ToString();
            //tienotoveluot.Text = (xeDaGuiDA.Instance.sootoguitheoluot() * 50000).ToString();
            //tienxemayveluot.Text = (xeDaGuiDA.Instance.soxemayguitheoluot() * 5000).ToString();
            //tongtienvethang.Text = (xeDaGuiDA.Instance.sootoguitheothang() * 1200000 + xeDaGuiDA.Instance.soxemayguitheothang() * 120000).ToString();
            //tienotovethang.Text = (xeDaGuiDA.Instance.sootoguitheothang() * 1200000).ToString();
            //tienxemaycethang.Text = (xeDaGuiDA.Instance.soxemayguitheothang() * 120000).ToString();
            tongxe.Text = xeDaGuiDA.Instance.tongxe().ToString();
            tongoto.Text = xeDaGuiDA.Instance.tongxeoto().ToString();
            tongxemay.Text = xeDaGuiDA.Instance.tongxemay().ToString();
            //tongluot.Text = xeDaGuiDA.Instance.tongxeguitheoluot().ToString();
            //otoluot.Text = xeDaGuiDA.Instance.sootoguitheoluot().ToString();
            //xemayluot.Text = xeDaGuiDA.Instance.soxemayguitheoluot().ToString();
            //tongthang.Text = xeDaGuiDA.Instance.tongxeguitheothang().ToString();
            //otothang.Text = xeDaGuiDA.Instance.sootoguitheothang().ToString();
            //xemaythang.Text = xeDaGuiDA.Instance.soxemayguitheothang().ToString();
            batdau.Text = xeDaGuiDA.Instance.ngaybatdau().ToString();
            nay.Text = DateTime.Now.ToString();
        }
        public void hienthi()
        {
            dataGridViewtk.DataSource = xeDaGuiDA.Instance.hienthi();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                xeDaGuiDA.Instance.datlai();
                xeDaGuiDA.tongtien = 0;
                MessageBox.Show("bạn đã đặt lại thành công!");
                tinh();
                hienthi();
            }
            catch
            {
                MessageBox.Show("Không thành công!")
;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewtk.DataSource = xeDaGuiDA.Instance.timkiem(txttimkiemadmim.Text);
        }


    }
}
