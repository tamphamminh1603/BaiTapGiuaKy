using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class Table
    {
        public Table(string maphong, string tenlp, bool tinhtrang)
        {
            this.Maphong = maphong;
            this.Tenlp = tenlp;
            this.Tinhtrang = tinhtrang;
        }

        public Table(DataRow row)
        {
            this.Maphong = row["maphong"].ToString();
            this.Tenlp = row["tenlp"].ToString();
            Tinhtrang = (bool)row["tinhtrang"];
        }

        private string maphong;
        private string tenlp;
        private bool tinhtrang;

        public string Maphong { get => maphong; set => maphong = value; }
        public string Tenlp { get => tenlp; set => tenlp = value; }
        public bool Tinhtrang { get => tinhtrang; set => tinhtrang = value; }

    }
}
