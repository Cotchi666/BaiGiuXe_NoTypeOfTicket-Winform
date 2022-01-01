using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform.TruyXuatDA
{
    class xeDaGuiDA
    {
        private static xeDaGuiDA instance;
        public static int tongtien = 0;
        internal static xeDaGuiDA Instance
        {
            get
            {
                if (instance == null)
                    instance = new xeDaGuiDA();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public List<thongke> hienthi()
        {
            String Query = "select * from THONGKE ";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            List<thongke> listadmin = new List<thongke>();
            foreach (DataRow item in data.Rows)
            {
                thongke dt = new thongke(item);
                listadmin.Add(dt);
            }
            return listadmin;
        }
        //kiểm tra tổng số xe đã gửi từ trước đến giờ
        public int tongxe()
        {
            String Query = "select * from THONGKE ";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        //kiểm tra tổng số xe ô tô đã gửi từ trước đến giờ
        public int tongxeoto()
        {
            String Query = "select * from THONGKE where loaiXe='Ô tô'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        //kiểm tra tổng số xe ô tô đã gửi từ trước đến giờ
        public int tongxemay()
        {
            String Query = "select * from THONGKE where loaiXe='Xe máy'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        //reset thống kê
        public void datlai()
        {
            String Query = "delete from THONGKE";
            string querytien = "update BAIXE set soTienThuVe=0";
            string datlai = "DBCC CHECKIDENT('THONGKE',RESEED,0)";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            dataprovider.Instance.ExcuteNonQuery(querytien);
            //dataprovider.Instance.ExcuteNonQuery(Query2);
            data = dataprovider.Instance.ExcuteQuery(datlai);

        }
        //lấy ra ngày bắt đầu thống kê
        public DateTime ngaybatdau()
        {
            DateTime ngay = DateTime.Now;
            String Query = "select * from THONGKE where id=1";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                thongke b = new thongke(item);
                ngay = b.Tgvaoben;
            }
            return ngay;
        }
        //tìm xe
        public List<thongke> timkiem(string ma)
        {
            String Query = "select * from THONGKE where bienSo like'%" + ma + "%'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            List<thongke> listadmin = new List<thongke>();
            foreach (DataRow item in data.Rows)
            {
                thongke dt = new thongke(item);
                listadmin.Add(dt);
            }
            return listadmin;
        }
        ////tổng số lượt xe gửi theo lượt
        //public int tongxeguitheoluot()
        //{
        //    String Query = "select * from THONGKE where loaiVe=N'Vé lượt'";
        //    DataTable data = new DataTable();
        //    data = dataprovider.Instance.ExcuteQuery(Query);
        //    return data.Rows.Count;
        //}
        ////tổng số lượt xe gửi thheo tháng
        //public int tongxeguitheothang()
        //{
        //    String Query = "select * from THONGKE where loaiVe=N'Vé tháng' and maSoVe!='Vé tháng'";
        //    DataTable data = new DataTable();
        //    data = dataprovider.Instance.ExcuteQuery(Query);
        //    return data.Rows.Count;
        //}
        ////số xe máy gửi theo lượt
        //public int soxemayguitheoluot()
        //{
        //    String Query = "select * from THONGKE where loaiXe=N'Xe máy' and loaiVe=N'Vé lượt'";
        //    DataTable data = new DataTable();
        //    data = dataprovider.Instance.ExcuteQuery(Query);
        //    return data.Rows.Count;
        //}
        ////số ô tô gửi theo lượt
        //public int sootoguitheoluot()
        //{
        //    String Query = "select * from THONGKE where loaiXe=N'Ô tô' and loaiVe=N'Vé lượt'";
        //    DataTable data = new DataTable();
        //    data = dataprovider.Instance.ExcuteQuery(Query);
        //    return data.Rows.Count;
        //}
        ////tổng xe máy gửi theo tháng
        //public int soxemayguitheothang()
        //{
        //    String Query = "select * from THONGKE where loaiXe=N'Xe máy' and loaiVe=N'Vé tháng' and maSoVe!='Vé tháng'";
        //    DataTable data = new DataTable();
        //    data = dataprovider.Instance.ExcuteQuery(Query);
        //    return data.Rows.Count;
        //}
        ////tổng ô tô gửi theo thang
        //public int sootoguitheothang()
        //{
        //    String Query = "select * from THONGKE where loaiXe='Ô tô' and loaiVe='Vé tháng' and maSoVe!='Vé tháng'";
        //    DataTable data = new DataTable();
        //    data = dataprovider.Instance.ExcuteQuery(Query);
        //    return data.Rows.Count;
        //}
    }
}
