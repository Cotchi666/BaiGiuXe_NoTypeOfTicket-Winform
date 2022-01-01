using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform.TruyXuatDA
{
    class xe
    {
        private string tenxe;
        private string looaixe;
        private string masove;
        private string bienso;
        private string loaixe;
        private string mauxe;
        private string loaive;
        private DateTime tgvaoben;
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
        public string Looaixe
        {
            get
            {
                return looaixe;
            }

            set
            {
                looaixe = value;
            }
        }

       

        public xe(DataRow row)
        {
            this.Loaixe = row["loaiXe"].ToString();
            this.Tenxe = row["tenxe"].ToString();
            this.Mauxe = row["mauxe"].ToString();
            this.Loaive = row["loaiVe"].ToString();
            this.Tgvaoben = DateTime.Parse(row["tgvaoben"].ToString());
            this.Masove = row["maSoVe"].ToString();
            this.Looaixe = row["loaiXe"].ToString();
            this.Bienso = row["bienSo"].ToString();
        }
    }
}
