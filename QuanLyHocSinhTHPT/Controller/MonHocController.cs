using QuanLyHocSinhTHPT.Helper;
using QuanLyHocSinhTHPT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinhTHPT.Controller
{
    internal class MonHocController
    {
        #region
        /*
        public MonHoc GetData(string id)
        {
            string sql = string.Format("select * from MonHoc where MaMon='{0}'", id);
            DataTable dt = sqlHelper.Query(sql);
            List<DataRow> list = dt.AsEnumerable().ToList();
            if (list.Count > 0)
            {
                MonHoc mh = new MonHoc();
                mh.MaMon = list[0].ItemArray[0].ToString();
                mh.TenMon = list[0].ItemArray[1].ToString();
                mh.HeSo = list[0].ItemArray[2].ToString();
                return mh;
            }
            return null;
        }
        public bool ThemMH(string _MaMon, string _TenMon, string _HeSo)
        {
            _HeSo = _HeSo.Replace(",", ".");
            string query = string.Format("INSERT INTO MonHoc values ('{0}',N'{1}', {2})",
                _MaMon, _TenMon, _HeSo);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

        public bool SuaMH(string _MaMon, string _TenMon, string _HeSo, string _MaMonID)
        {
            _HeSo= _HeSo.Replace(",", ".");
            string query = string.Format("update MonHoc set MaMon='{0}',TenMon=N'{1}',HeSo={2} where MaMon='{3}'",
                _MaMon, _TenMon, _HeSo, _MaMonID);

            //SqlParameter _MaMonParam = new SqlParameter("@mm", SqlDbType.VarChar);
            //_MaMonParam.Value = _MaMon;
            //SqlParameter _TenMonParam = new SqlParameter("@ten", SqlDbType.VarChar);
            //_MaMonParam.Value = _MaMon;
            //SqlParameter __HeSoParam = new SqlParameter("@heso", SqlDbType.Float);
            //_MaMonParam.Value = _MaMon;

            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }

        public bool XoaMH(string _MaMon)
        {
            string query = string.Format("delete from MonHoc  Where MaMon ='{0}'", _MaMon);
            if (sqlHelper.NonQuery(query))
                return true;
            else return false;
        }
        public bool CheckErr(string _MaMon, string _TenMon, string _HeSo)
        {
            float heso;
            if (_MaMon == "") { MessageBox.Show("Trống Mã Môn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (_TenMon == "") { MessageBox.Show("Trống Tên Môn ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (_HeSo == "") { MessageBox.Show("Trống Hệ Số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            else
            {
                if (!float.TryParse(_HeSo, out heso))
                {
                    MessageBox.Show("Lỗi Hệ Số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
                }
            }
            return true;
        }

        */
        #endregion
    }
}