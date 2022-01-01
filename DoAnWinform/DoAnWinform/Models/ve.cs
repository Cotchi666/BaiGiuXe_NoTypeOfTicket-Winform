using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform.Models
{
    class ve
    {
        private string looaixe;
        private string masove;
        private string bienso;

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

        public ve(DataRow row)
        {
            this.Masove = row["maSoVe"].ToString();
            this.Looaixe = row["loaiXe"].ToString();
            this.Bienso = row["bienSo"].ToString();
        }
    }
}
