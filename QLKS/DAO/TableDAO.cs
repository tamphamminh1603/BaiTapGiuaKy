using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWidth = 80;
        public static int TableHeight = 80;

        private TableDAO() { }

        //public string GetListTableByMP(string MaPhong)
        //{
        //    return (string)DataProvider.Instance.ExecuteScalar("SELECT * FROM phong WHERE maphong = " + MaPhong +" AND tinhtrang = 0");
        //    if (data.Rows.Count > 0)
        //    {
        //         = new Bill(data.Rows[0]);
        //        return bill.ID;
        //    }
        //}

        //public string InsertRoom(string maphong)
        //{
        //    DataTable data = new DataTable();
        //    if (data.Rows.Count > 0)
        //    {
        //        Table room = new Table(data.Rows[0]);
        //        return room.Maphong;
        //    }
        //    return "";
        //}
        public List<Table> GetListInfo(string maphong)
        {
            List<Table> listTable = new List<Table>();
            string query = "Select maphong from phong where maphong = '" + maphong + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Table info = new Table(item);
                listTable.Add(info);
            }

            return listTable;
        }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_phong");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }
     
    }
}
