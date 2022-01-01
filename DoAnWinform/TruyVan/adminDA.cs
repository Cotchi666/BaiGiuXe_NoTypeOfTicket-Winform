using DoAnWinform.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform.TruyXuatDA
{
    class adminDA
    {
        private static adminDA instance;

        public static adminDA Instance
        {
            get
            {
                if (instance == null)
                    instance = new adminDA();
                return adminDA.instance;
            }

            private set
            {
                instance = value;
            }
        }

        //hiển thị danh sách admin
        public List<admin> hienthiadmin()
        {
            String Query = "select * from NHANVIEN";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            List<admin> listadmin = new List<admin>();
            foreach (DataRow item in data.Rows)
            {
                admin dt = new admin(item);
                dt.Matkhau = "******";
                listadmin.Add(dt);
            }
            return listadmin;
        }
        //tìm kiếm theo mã
        public List<admin> timkiem(string ma)
        {
            String Query = "select * from NHANVIEN where manv like'%" + ma + "%'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            List<admin> listadmin = new List<admin>();
            foreach (DataRow item in data.Rows)
            {
                admin dt = new admin(item);
                dt.Matkhau = "******";
                listadmin.Add(dt);
            }
            return listadmin;
        }
        //thêm
        public Boolean them(string ma, string tenht, string loai, DateTime ngaysinh, string gt, string dc, int sdt, string mk)
        {
            String Query = "insert into NHANVIEN values(N'" + ma + "',N'" + tenht + "',N'" + loai + "','" + ngaysinh + "',N'" + gt + "',N'" + dc + "','" + sdt + "',N'" + mk + "')";


            return (0 < dataprovider.Instance.ExcuteNonQuery(Query));
        }
        //sửa
        public Boolean sua(string ma, string tenht, string loai, DateTime ngaysinh, string gt, string dc, string sdt, string mk)
        {
            String Query = "update NHANVIEN set tenHienThi=N'" + tenht + "', loaiNV=N'" + loai + "',ngaySinh='" + ngaysinh + "', gt=N'" + gt + "', diaChi=N'" + dc + "', sdt=N'" + sdt + "', matKhau=N'" + mk + "' where maNV='" + ma + "'";
            return (0 < dataprovider.Instance.ExcuteNonQuery(Query));
        }
        //xóa
        public Boolean xoa(string ma)
        {
            string query = "delete from NHANVIEN where maNV='" + ma + "'";
            return dataprovider.Instance.ExcuteNonQuery(query) > 0;
        }
        //kiểm tra sự tồn tại của 1 tài khoản
        public Boolean tontai(string ma)
        {
            string query = "select * from NHANVIEN where maNV='" + ma + "'";
            return dataprovider.Instance.ExcuteQuery(query).Rows.Count > 0;
        }


    }
}
