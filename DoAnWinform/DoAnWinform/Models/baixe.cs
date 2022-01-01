using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform.Models
{
    class baixe
    {
        private string khuvuc;
        private int tongsocho;
        private int sochotrong;
        private int tien;
        public string Khuvuc
        {
            get
            {
                return khuvuc;
            }

            set
            {
                khuvuc = value;
            }
        }


        public int Tongsocho
        {
            get
            {
                return tongsocho;
            }

            set
            {
                tongsocho = value;
            }
        }

        public int Sochotrong
        {
            get
            {
                return sochotrong;
            }

            set
            {
                sochotrong = value;
            }
        }

        public int Tien
        {
            get
            {
                return tien;
            }

            set
            {
                tien = value;
            }
        }

        public baixe(DataRow row)
        {
            this.Khuvuc = row["khuVuc"].ToString();
            this.Tongsocho = int.Parse(row["tongSoCho"].ToString());
            this.Sochotrong = int.Parse(row["soChoTrong"].ToString());
            this.Tien = int.Parse(row["soTienThuVe"].ToString());
        }
    }
}
