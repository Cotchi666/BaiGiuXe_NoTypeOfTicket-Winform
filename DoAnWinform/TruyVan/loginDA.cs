using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform.TruyXuatDA
{
    class loginDA
    {
        private static loginDA instance;

        public static loginDA Instance
        {
            get { if (instance == null) instance = new loginDA(); return instance; }
            set { instance = value; }

        }
        private loginDA() { }
        public bool quyenquanly(String username, String pass)
        {
            DataTable data = dataprovider.Instance.ExcuteQuery("select * from nhanvien where maNV='" + username + "' and matKhau='" + pass + "' and loaiNV=N'" + "Nhân viên quản lý" + "'");
            return data.Rows.Count > 0;

        }
        public bool quyenADMIN(String username, String pass)
        {
            DataTable data = dataprovider.Instance.ExcuteQuery("select * from nhanvien where maNV='" + username + "' and matKhau='" + pass + "'");
            return data.Rows.Count > 0;
        }

    }
}
