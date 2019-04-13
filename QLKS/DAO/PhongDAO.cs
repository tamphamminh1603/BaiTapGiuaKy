using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
        //public string GetListTableByMP(string MaPhong)
        //{
        //    return (string)DataProvider.Instance.ExecuteScalar("");
        //}

        //public string InsertRoom(string maphong)
        //{
        //    DataTable data = new DataTable();
        //    if(data.Rows.Count > 0)
        //    {
        //        Table room = new Table(data.Rows[0]);
        //        return room.Maphong;
        //    }
        //    return "";
        //}

        //public List<Table> GetListInfo(string maphong)
        //{
        //    List<Table> listTable = new List<Table>();

        //    DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM phong WHERE maphong = " + maphong);

        //    foreach (DataRow item in data.Rows)
        //    {
        //        Table info = new Table(item);
        //        listTable.Add(info);
        //    }

        //    return listTable;
        //}
    }
}
