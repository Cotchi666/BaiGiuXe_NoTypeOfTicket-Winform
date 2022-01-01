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
        public static bool quyenadmin = false;
        public static bool quyenddangnhap = false;
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
                admin b = new admin(item);
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
                admin b = new admin(item);
                loai = b.Loainv;
            }
            return loai;
        }
        public static Boolean mahoaso(string so)
        {
            string Rules = @"^\d{1,7}$";
            Regex Myregex = new Regex(Rules);
            return Myregex.IsMatch(so);
        }
        public static Boolean mahoasodt(string so)
        {
            string Rules = @"^\+?\d{1,3}?[- .]?\(?(?:\d{2,3})\)?[- .]?\d\d\d[- .]?\d\d\d\d$";
            Regex Myregex = new Regex(Rules);
            return Myregex.IsMatch(so);
        }
    }
}
