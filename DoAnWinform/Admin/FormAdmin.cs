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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        { 
                InitializeComponent();
                hienthidanhsachad();
                chao.Text = "Chào " + taikhoanDA.ten.ToString();
                loainv.Text = "Chức vụ: " + taikhoanDA.loainv.ToString();
            }
            void hienthidanhsachad()
            {
                this.pnadmin.Controls.Clear();
                FormDSAD dsad = new FormDSAD();
                dsad.TopLevel = false;
                this.pnadmin.Controls.Add(dsad);
                dsad.Show();
            }


            private void btdanhsachnhanvien_Click(object sender, EventArgs e)
            {
                this.pnadmin.Controls.Clear();
                FormDSAD dsad = new FormDSAD();
                dsad.TopLevel = false;
                this.pnadmin.Controls.Add(dsad);
                dsad.Show();
            }

        private void pnadmin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
