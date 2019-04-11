using QLKS.DAO;
using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class fQLKS : Form
    {
        public fQLKS()
        {
            InitializeComponent();
            LoadTable();
        }

        public void LoadTable()
        {
            List<Table> tablelist = TableDAO.Instance.LoadTableList();

            foreach(Table item in tablelist)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight};
                btn.Text = item.Maphong + Environment.NewLine + item.Tenlp;
                btn.Click += Btn_Click;
                btn.Tag = item;

                switch (item.Tinhtrang)
                {
                    case true:
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
                
            //string query = "select * from phong";
            //DgvQLKS.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void ShowInfoRoom(int maphong)
        {

        }
        #region
        private void Btn_Click(object sender, EventArgs e)
        {
           
        }
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccoutProfile f = new AccoutProfile();
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        //int index;
        //private void DgvQLKS_Click(object sender, EventArgs e)
        //{
        //    index = DgvQLKS.CurrentRow.Index;
        //    txbMaPhong.Text = DgvQLKS.Rows[index].Cells[0].Value.ToString();
        //    cbTenLoaiPhong.Text = DgvQLKS.Rows[index].Cells[1].Value.ToString();
        //    cbTinhTrang.Text = DgvQLKS.Rows[index].Cells[2].Value.ToString();
            
        //}

        private void btHuy_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }
        string them;
        private void btThem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=dataQLKS;Integrated Security=True");
            //    kn.Open();
            //    them = "insert into phong values('"+txbMaPhong.Text+"','"+cbTenLoaiPhong.Text+"','"+cbTinhTrang.Text +"')";
            //    SqlCommand commandthem = new SqlCommand(them, kn);
            //    commandthem.ExecuteNonQuery();
            //    LoadTable();
            //}
            //catch
            //{
            //    MessageBox.Show("Lỗi , Không thêm được!");
            //}
            //finally
            //{
            //    SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=dataQLKS;Integrated Security=True");
            //    kn.Close();
            //}
        }

        string xoaphong;
        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=dataQLKS;Integrated Security=True");
                kn.Open();
                xoaphong = "delete phong where maphong = '" + txbMaPhong.Text + "'";              
                SqlCommand comm = new SqlCommand(xoaphong, kn);
                comm.ExecuteNonQuery();
                LoadTable();

            }
            catch
            {
                MessageBox.Show("Lỗi! xóa không được:");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=dataQLKS;Integrated Security=True");
                kn.Close();
            }
        }

        string sua;
        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=dataQLKS;Integrated Security=True");
                kn.Open();
                sua = "update phong set tenlp ='"+cbTenLoaiPhong.Text+"', tinhtrang = '"+ cbTinhTrang.Text+"' where maphong = '" + txbMaPhong.Text+"'";
                SqlCommand commandsua = new SqlCommand(sua, kn);
                commandsua.ExecuteNonQuery();
                LoadTable();
            }
            catch
            {
                MessageBox.Show("Lỗi !");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=dataQLKS;Integrated Security=True");
                kn.Close();
            }
        }

        private void AdminToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Booking b = new Booking();
            this.Hide();
            b.ShowDialog();
        }

        private void ThôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLKH f = new fQLKH();
            this.Hide();
            f.ShowDialog();
        }

        private void flpTable_Click(object sender, EventArgs e)
        {
            
        }
    }
}
