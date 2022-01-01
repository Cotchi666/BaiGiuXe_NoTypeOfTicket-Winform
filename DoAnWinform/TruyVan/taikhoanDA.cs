using DoAnWinform.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DoAnWinform.TruyXuatDA
{
    class taikhoanDA
    {
       
        public static string tk = "";
        public static string ten = "";
        public static string loainv = "";
        public static string layten(string ma)
        {
            string ten = "";
            String Query = "select * from NHANVIEN where maNV='" + ma + "'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                taikhoan b = new taikhoan(item);
                ten = b.Tenht;
            }
            return ten;
        }
        public static string layloainv(string ma)
        {
            string loai = "";
            String Query = "select * from NHANVIEN where maNV='" + ma + "'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                taikhoan b = new taikhoan(item);
                loai = b.Loainv;
            }
            return loai;
        }

    }
}
