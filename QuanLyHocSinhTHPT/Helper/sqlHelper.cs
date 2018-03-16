using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyHocSinhTHPT.Helper
{
    class sqlHelper
    {
        public static DataTable Query(string str, params SqlParameter[] sp)
        {
            SqlConnection myConnect = new SqlConnection(Helper.ThamSoKetNoi.StringConnect);
            myConnect.Open();
            SqlDataAdapter da = null;
            SqlCommand sc = null;
            if (str.Contains(" "))
            {
                da = new SqlDataAdapter(str, myConnect);

            }
            else
            {
                sc = new SqlCommand(str, myConnect);
                sc.CommandType = CommandType.StoredProcedure;

                if (sp.Length > 0)
                {
                    foreach (SqlParameter p in sp)
                    {
                        sc.Parameters.Add(p);
                    }
                }
                da = new SqlDataAdapter(sc);
            }
            DataTable dt = new DataTable();
            da.Fill(dt);
            myConnect.Close();
            return dt;
        }
        public static bool NonQuery(string str, params SqlParameter[] sp)
        {
            try
            {
                SqlConnection myConnect = new SqlConnection(Helper.ThamSoKetNoi.StringConnect);
                myConnect.Open();
                SqlCommand sc = new SqlCommand(str, myConnect);
                if (str.Contains(" "))
                {
                    sc.CommandType = CommandType.Text;
                }
                else
                {
                    sc.CommandType = CommandType.StoredProcedure;
                    if (sp.Length > 0)
                    {
                        foreach (SqlParameter p in sp)
                        {
                            sc.Parameters.Add(p);
                        }
                    }
                }
                sc.ExecuteNonQuery();
                myConnect.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
