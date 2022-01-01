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
             
                chao.Text = "Chào " + taikhoanDA.ten.ToString();
                loainv.Text = "Chức vụ: " + taikhoanDA.loainv.ToString();
            }

    }
}
