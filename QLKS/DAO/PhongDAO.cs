using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class PhongDAO
    {
        private static PhongDAO instance;

        public static PhongDAO Instance
        {
            get { if (instance == null) instance = new PhongDAO(); return PhongDAO.instance; }
            private set { PhongDAO.instance = value; }
        }

        private PhongDAO() { }

        //public bool InsertRoom(string maphong, string tenlp, bool tinhtrang)
        //{
        //    string query = string.Format("select * from phong");

        //    string result = DataProvider.Instance.ExecuteQuery(query);

        //    return result.Rows.Count > 0;
        //}

        //public List<> GetListInfo(string maphong)
        //{
        //    List<BillInfo> listBillInfo = new List<BillInfo>();

        //    DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BillInfo WHERE idBill = " + id);

        //    foreach (DataRow item in data.Rows)
        //    {
        //        BillInfo info = new BillInfo(item);
        //        listBillInfo.Add(info);
        //    }

        //    return listBillInfo;
        //}
    }
}
