using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform.TruyXuatDA
{
    class thongke
    {
        private string masove;
        private string bienso;
        private string loaixe;
        private string tenxe;
        private string mauxe;
        private string loaive;
        private string giave;
        private DateTime tgvaoben;
        private DateTime tgxuatben;


        public string Masove
        {
            get
            {
                return masove;
            }

            set
            {
                masove = value;
            }
        }

        public string Bienso
        {
            get
            {
                return bienso;
            }

            set
            {
                bienso = value;
            }
        }

        public string Loaixe
        {
            get
            {
                return loaixe;
            }

            set
            {
                loaixe = value;
            }
        }

        public string Tenxe
        {
            get
            {
                return tenxe;
            }

            set
            {
                tenxe = value;
            }
        }

        public string Mauxe
        {
            get
            {
                return mauxe;
            }

            set
            {
                mauxe = value;
            }
        }

        public string Loaive
        {
            get
            {
                return loaive;
            }

            set
            {
                loaive = value;
            }
        }

        public string Giave
        {
            get
            {
                return giave;
            }

            set
            {
                giave = value;
            }
        }

        public DateTime Tgvaoben
        {
            get
            {
                return tgvaoben;
            }

            set
            {
                tgvaoben = value;
            }
        }

        public DateTime Tgxuatben
        {
            get
            {
                return tgxuatben;
            }

            set
            {
                tgxuatben = value;
            }
        }

        public thongke(DataRow row)
        {
            this.Masove = row["maSoVe"].ToString();
            this.Bienso = row["bienSo"].ToString();
            this.Loaixe = row["loaiXe"].ToString();
            this.Tenxe = row["tenxe"].ToString();
            this.Mauxe = row["mauxe"].ToString();
            this.Loaive = row["loaiVe"].ToString();
            this.Giave = row["giaVe"].ToString();
            this.Tgvaoben = DateTime.Parse(row["tgvaoben"].ToString());
            this.Tgxuatben = DateTime.Parse(row["tgxuatben"].ToString());
        }
    }
}
