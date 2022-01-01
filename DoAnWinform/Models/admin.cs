using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform.Models
{
    class admin
    {
        private string manv;
        private string tenht;
        private string loainv;
        private DateTime ngaysinh;
        private string gioitinh;
        private string diachi;
        private string dienthoai;
        private string matkhau;

        public string Manv
        {
            get
            {
                return manv;
            }

            set
            {
                manv = value;
            }
        }
        public string Tenht
        {
            get
            {
                return tenht;
            }

            set
            {
                tenht = value;
            }
        }

        public string Loainv
        {
            get
            {
                return loainv;
            }

            set
            {
                loainv = value;
            }
        }

        public DateTime Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Dienthoai
        {
            get
            {
                return dienthoai;
            }

            set
            {
                dienthoai = value;
            }
        }

        public string Matkhau
        {
            get
            {
                return matkhau;
            }

            set
            {
                matkhau = value;
            }
        }

        public admin(DataRow row)
        {
            this.Manv = row["maNV"].ToString();
            this.Tenht = row["tenHienthi"].ToString();
            this.Loainv = row["loaiNV"].ToString();
            this.Ngaysinh = DateTime.Parse(row["ngaySinh"].ToString());
            this.Gioitinh = row["gt"].ToString();
            this.Diachi = row["diaChi"].ToString();
            this.Dienthoai = row["sdt"].ToString();
            this.Matkhau = row["matKhau"].ToString();

        }
    }
}
