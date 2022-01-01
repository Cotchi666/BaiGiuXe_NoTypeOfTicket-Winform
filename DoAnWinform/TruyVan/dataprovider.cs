using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform.TruyXuatDA
{
    public class dataprovider
    {
        private static dataprovider instance;
        private string strconn = @"Data Source=DESKTOP-SCBOTSE;Initial Catalog=QuanLyXeOK;Integrated Security=True";

        public static dataprovider Instance
        {
            get
            {
                if (instance == null)
                    instance = new dataprovider();
                return dataprovider.instance;
            }
            private set { instance = value; }
        }
        private dataprovider() { }

        public DataTable ExcuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
            }
            return data;

        }

        public int ExcuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                data = command.ExecuteNonQuery();
                conn.Close();
            }

            return data;

        }

    }

}
